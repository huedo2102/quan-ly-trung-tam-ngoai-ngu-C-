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
    public partial class FrmLop : Form
    {
        private void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        private void loadCbbGiaoVien()
        {
            cbbGiaoVien.DataSource = Database.Query("SELECT *,(Ho+' '+Ten) AS hoten FROM GiaoVien", new Dictionary<string, object>());
        }

        private void loadDgvLop()
        {
            string strQuery = "SELECT DISTINCT Lop.MaLop,TenLop,MaGiaoVien,NgayBatDau,NgayKetThuc,MaNgoaiNgu,DiaDiem,ThoiGian,GhiChu FROM Lop WHERE Lop.MaLop!=''";
           
          
            Dictionary<string, object> parameters = new Dictionary<string, object>();
          
            if (chbMaLop.Checked)
            {
                strQuery += " AND Lop.MaLop=@maLop";
                parameters.Add("@maLop", tboMaLop.Text);
            }
            if (chbTenLop.Checked)
            {
                strQuery += " AND Lop.TenLop LIKE '%' + @tenLop + '%'";
                parameters.Add("@tenLop", tboTenLop.Text);
            }
          
            if (chbNgayBatDau.Checked)
            {
                strQuery += " AND Lop.NgayBatDau>=@ngayBatDau";
                parameters.Add("@ngayBatDau", dtpNgayBatDau.Value.AddDays(1).Date);
            }
            if (chbNgayKetThuc.Checked)
            {
                strQuery += " AND Lop.NgayKetThuc<=@ngayKetThuc";
                parameters.Add("@ngayKetThuc", dtpNgayKetThuc.Value.AddDays(1).Date);
            }

            if (chbDiaDiem.Checked)
            {
                strQuery += " AND Lop.DiaDiem LIKE '%' + @diaDiem + '%'";
                parameters.Add("@diaDiem", tboDiaDiem.Text);
            }
            if (chbThoiGian.Checked)
            {
                strQuery += " AND Lop.ThoiGian LIKE '%' + @thoiGian + '%'";
                parameters.Add("@thoiGian", tboThoiGian.Text);
            }
            if (chbNgoaiNgu.Checked)
            {
                strQuery += " AND MaNgoaiNgu = @maNgoaiNgu";
                parameters.Add("@maNgoaiNgu", cbbNgoaiNgu.SelectedValue);
            }
            if (chbGiaoVien.Checked)
            {
                strQuery += " AND MaGiaoVien = @maGiaoVien";
                parameters.Add("@maGiaoVien", cbbGiaoVien.SelectedValue);
            }
           
            dgvLop.DataSource = Database.Query(strQuery, parameters);
            btoSua.Enabled = btoXoa.Enabled = dgvLop.Rows.Count > 0;
     
        }
        public FrmLop()
        {
            InitializeComponent();
            loadDgvLop();
            loadCbbNgoaiNgu();
            loadCbbGiaoVien();
        }
        private void grbTimKiem_Enter(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyLop_Load(object sender, EventArgs e)
        {

        }

        private void chbMaLop_CheckedChanged(object sender, EventArgs e)
        {
            tboMaLop.Enabled = chbMaLop.Checked;
        }

        private void chbTenLop_CheckedChanged(object sender, EventArgs e)
        {
            tboTenLop.Enabled = chbTenLop.Checked;
        }

        private void chbNgayBatDau_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayBatDau.Enabled = chbNgayBatDau.Checked;
        }

        private void chbNgayKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayKetThuc.Enabled = chbNgayKetThuc.Checked;
        }

        private void chbDiaDiem_CheckedChanged(object sender, EventArgs e)
        {
            tboDiaDiem.Enabled = chbDiaDiem.Checked;
        }

        private void chbThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            tboThoiGian.Enabled = chbThoiGian.Checked;
        }

        private void chbNgoaiNgu_CheckedChanged(object sender, EventArgs e)
        {
            cbbNgoaiNgu.Enabled = chbNgoaiNgu.Checked;
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            FrmThemLop form = new FrmThemLop();
            form.ShowDialog();
            loadDgvLop();
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
           
            loadDgvLop();


        }

        private void chbHienThiThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            dgvLop.Columns["colThoiGian"].Visible = chbHienThiThoiGian.Checked;
        }

        private void chbHIenThiNgoaiNgu_CheckedChanged(object sender, EventArgs e)
        {
            dgvLop.Columns["colNgoaiNgu"].Visible = chbHienThiNgoaiNgu.Checked;
        }

        private void chbHienThiGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            dgvLop.Columns["colGhiChu"].Visible = chbHienThiGhiChu.Checked;
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin lớp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maLop = dgvLop.CurrentRow.Cells["colMaLop"].Value.ToString();
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                //Xóa giáo viên có mã ứng với mã vừa lấy
                string strCommand = "DELETE DangKy WHERE MaLop=@maLop";
                parameters.Add("@maLop", maLop);
                Database.Execute(strCommand, parameters);
                strCommand = "DELETE Lop WHERE MaLop=@maLop";
                
                Database.Execute(strCommand, parameters);
                
                //Nạp lại bảng dữ liệu
                loadDgvLop();
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            //Lấy ra mã giáo viên ở dòng đang chọn
            string maLop = dgvLop.CurrentRow.Cells["colMaLop"].Value.ToString();
            //Truyền mã giáo viên đó sang form sửa giáo viên
            FrmSuaLop form = new FrmSuaLop(maLop);
            //Hiển thị form sửa giáo viên
            form.ShowDialog();
            //Nạp lại bảng dữ liệu
            loadDgvLop();
        }

        private void chbGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            cbbGiaoVien.Enabled = chbGiaoVien.Checked;
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            string maLop = dgvLop.CurrentRow.Cells["colMaLop"].Value.ToString();
            FrmDanhSachLop form = new FrmDanhSachLop(maLop);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strQuery = "SELECT * FROM Lop";
            DataTable table = Database.Query(strQuery, new Dictionary<string, object>());
            dgvLop.DataSource = table;
            btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
        }

        private void tboMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbbNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}