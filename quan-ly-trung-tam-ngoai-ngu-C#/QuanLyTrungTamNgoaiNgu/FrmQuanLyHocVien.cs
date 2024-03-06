using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FrmQuanLyHocVien : Form
    {
        
        private void loadDgvHocVien()
        {
            string strQuery = "SELECT DISTINCT HocVien.MaHocVien,Ho,Ten,NgaySinh,IIF(GioiTinh IS NULL,N'Không',IIF(GioiTinh='TRUE','Nam',N'Nữ')) GioiTinh,DiaChi,DienThoai,Email FROM HocVien WHERE HocVien.MaHocVien!=''";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaHocVien.Checked)
            {
                strQuery += " AND HocVien.MaHocVien=@maHocVien";
                parameters.Add("@maHocVien", int.Parse(tboMaHocVien.Text));
            }
            if (chbHo.Checked)
            {
                strQuery += " AND Ho LIKE '%' + @ho + '%'";
                parameters.Add("@ho", tboHo.Text);
            }
            if (chbTen.Checked)
            {
                strQuery += " AND Ten LIKE '%' + @ten + '%'";
                parameters.Add("@ten", tboTen.Text);
            }
            if (chbNgaySinhTu.Checked)
            {
                strQuery += " AND NgaySinh>=@ngaySinhTu";
                parameters.Add("@ngaySinhTu", dtpNgaySinhTu.Value.Date);
            }
            if (chbNgaySinhDen.Checked)
            {
                strQuery += " AND NgaySinh<=@ngaySinhDen";
                parameters.Add("@ngaySinhDen", dtpNgaySinhDen.Value.AddDays(1).Date);
            }
            if (chbGioiTinh.Checked)
            {
                strQuery += " AND GioiTinh=@gioiTinh";
                parameters.Add("@gioiTinh", rdbNam.Checked);
            }
            if (chbDiaChi.Checked)
            {
                strQuery += " AND DiaChi LIKE '%' + @diaChi + '%'";
                parameters.Add("@diaChi", tboDiaChi.Text);
            }
            if (chbDienThoai.Checked)
            {
                strQuery += " AND DienThoai LIKE '%' + @dienThoai + '%'";
                parameters.Add("@dienThoai", tboDienThoai.Text);
            }
            if (chbEmail.Checked)
            {
                strQuery += " AND Email LIKE '%' + @email + '%'";
                parameters.Add("@email", tboEmail.Text);
            }
            
            dgvHocVien.DataSource = Database.Query(strQuery, parameters);
            btoSua.Enabled = btoXoa.Enabled = dgvHocVien.Rows.Count > 0;
        }
        public FrmQuanLyHocVien()
        {
            InitializeComponent();
            loadDgvHocVien();
            
        }

        private void chbMaHocVien_CheckedChanged(object sender, EventArgs e)
        {
            tboMaHocVien.Enabled = chbMaHocVien.Checked;
        }

        private void chbHo_CheckedChanged(object sender, EventArgs e)
        {
            tboHo.Enabled = chbHo.Checked;
        }

        private void chbTen_CheckedChanged(object sender, EventArgs e)
        {
            tboTen.Enabled = chbTen.Checked;
        }

        private void chbNgaySinhTu_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhTu.Enabled = chbNgaySinhTu.Checked;
        }

        private void chbNgaySinhDen_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhDen.Enabled = chbNgaySinhDen.Checked;
        }

        private void chbDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            tboDienThoai.Enabled = chbDienThoai.Checked;
        }

        private void chbEmail_CheckedChanged(object sender, EventArgs e)
        {
            tboEmail.Enabled = chbEmail.Checked;
        }

        

        private void btoThem_Click(object sender, EventArgs e)
        {
            FrmThemHocVien form = new FrmThemHocVien();
            form.ShowDialog();
            loadDgvHocVien();
        }

        private void chbDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            tboDiaChi.Enabled = chbDiaChi.Checked;
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvHocVien();
        }

        private void chbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            grbGioiTinh.Enabled = chbGioiTinh.Checked;
        }

        private void dgvHocVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboMaHocVienHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colMaHocVien"].Value.ToString();
            tboHoTenHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colHo"].Value.ToString() + " " + dgvHocVien.Rows[e.RowIndex].Cells["colTen"].Value.ToString();
            dtpNgaySinhHienThi.Value = DateTime.Parse(dgvHocVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            tboGioiTinhHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString();
            tboDiaChiHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            tboDienThoaiHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colDienThoai"].Value.ToString();
            tboEmailHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
            //Lấy ra mã học viên đang được chọn
            int maHocVien = int.Parse(tboMaHocVienHienThi.Text);
            
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHocVien", maHocVien);

            string strQuery = "SELECT DangKy.MaLop, Diem, TenLop FROM DangKy inner join Lop on DangKy.MaLop=Lop.MaLop where MaHocVien=" + maHocVien;
            
            DataTable trinhDoGiaoViens = Database.Query(strQuery, parameters);
            dgvLopDK.DataSource = trinhDoGiaoViens;
            treeView1.Nodes.Clear();
            TreeNode node = new TreeNode("Học viên đã đăng ký lớp:");
            for (int i = 0; i < trinhDoGiaoViens.Rows.Count; ++i)
            {
                node.Nodes.Add(trinhDoGiaoViens.Rows[i]["TenLop"].ToString());
                node.Expand();
            }
            treeView1.Nodes.Add(node);
            
        }

        private void chbHienThiNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colNgaySinh"].Visible = chbHienThiNgaySinh.Checked;
        }

        private void chbHienThiGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colGioiTinh"].Visible = chbHienThiGioiTinh.Checked;
        }

        private void chbHienThiDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colDiaChi"].Visible = chbHienThiDiaChi.Checked;
        }

        private void chbHienThiDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colDienThoai"].Visible = chbHienThiDienThoai.Checked;
        }

        private void chbHienThiEmail_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colEmail"].Visible = chbHienThiEmail.Checked;
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hồ sơ học viên này không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Lấy ra mã giáo viên của dòng đang chọn
                int maHocVien = (int)dgvHocVien.CurrentRow.Cells["colMaHocVien"].Value;
                //Xóa tất cả trình độ giáo viên ứng với mã vừa lấy
                string strCommand = "DELETE DangKy WHERE MaHocVien=@maHocVien";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maHocVien", maHocVien);
                Database.Execute(strCommand, parameters);
                //Xóa giáo viên có mã ứng với mã vừa lấy
                strCommand = "DELETE HocVien WHERE MaHocVien=@maHocVien";
                Database.Execute(strCommand, parameters);
                //Nạp lại bảng dữ liệu
                loadDgvHocVien();
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            //Lấy ra mã học viên ở dòng đang chọn
            int maHocVien = (int)dgvHocVien.CurrentRow.Cells["colMaHocVien"].Value;
            //Truyền mã học viên đó sang form sửa học viên
            FrmSuaHocVien form = new FrmSuaHocVien(maHocVien);
            //Hiển thị form sửa học viên
            form.ShowDialog();
            //Nạp lại bảng dữ liệu
            loadDgvHocVien();
        }
    }
}
