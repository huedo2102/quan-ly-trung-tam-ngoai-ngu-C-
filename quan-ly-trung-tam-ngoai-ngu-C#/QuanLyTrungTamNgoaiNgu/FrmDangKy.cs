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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
            
            loadDgvLop();
            loadDgvHocVien();
        }
        private void loadDgvHocVien2()
        {
            string strQuery = "SELECT * FROM HocVien WHERE 1=1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaHocVien.Checked)
            {
                strQuery += " AND MaHocVien=@maHocVien";
                parameters.Add("@maHocVien", textBox2.Text);
            }
            if (chbTenHocVien.Checked)
            {
                strQuery += " AND Ten LIKE '%' + @tenHocVien + '%'";
                parameters.Add("@tenHocVien", textBox1.Text);
            }

            DataTable HocViens = Database.Query(strQuery, parameters);
            //Đẩy dữ liệu lên data gridview
            dgvHocVien.DataSource = HocViens;
        }

        private void loadDgvLop2()
        {
            string strQuery = "SELECT * FROM Lop WHERE 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaLop.Checked)
            {
                strQuery += " AND MaLop=@maLop";
                parameters.Add("@maLop",textBox4.Text);
            }
            if (chbTenLop.Checked)
            {
                strQuery += " AND TenLop LIKE '%'+@tenLop+'%'";
                parameters.Add("@tenLop", textBox5.Text);
            }

            DataTable Lops = Database.Query(strQuery, parameters);
            //Đẩy dữ liệu lên data gridview
            dgvLop.DataSource = Lops;
        }

        private void loadDgvHocVien()
        {
            string strQuery = "SELECT DISTINCT HocVien.MaHocVien,Ho,Ten,NgaySinh,IIF(GioiTinh IS NULL,N'Không',IIF(GioiTinh='TRUE','Nam',N'Nữ')) GioiTinh,DiaChi,DienThoai,Email FROM HocVien WHERE HocVien.MaHocVien!=''";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            
            dgvHocVien.DataSource = Database.Query(strQuery, parameters);
            
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void loadDgvLop()
        {
            string strQuery = "SELECT DISTINCT MaLop,TenLop,MaGiaoVien,NgayBatDau,NgayKetThuc,MaNgoaiNgu,DiaDiem,ThoiGian,GhiChu FROM Lop ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            dgvLop.DataSource = Database.Query(strQuery, parameters);
            
        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaHocVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtMaHocVien.Text=="")
                MessageBox.Show("Vui lòng chọn học viên", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(txtMaLop.Text == "")
                MessageBox.Show("Vui lòng chọn lớp", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                errorProvider1.Clear();

                string strCommand = "EXEC spThemDangKy @maHocVien,@maLop,@diem";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maHocVien", txtMaHocVien.Text);
                parameters.Add("@maLop", txtMaLop.Text);
                parameters.Add("@diem", txtDiem.Text);
                try
                {
                    Database.Execute(strCommand, parameters);
                    MessageBox.Show("Đã đăng ký thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Học viên đã đăng ký lớp này rồi")
                        errorProvider1.SetError(txtMaLop, ex.Message);

                    MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHocVien.Text == "")
                MessageBox.Show("Vui lòng chọn học viên", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtMaLop.Text == "")
                MessageBox.Show("Vui lòng chọn lớp", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //Lấy ra mã học viên của dòng đang chọn
                int maHocVien = (int)dgvHocVien.CurrentRow.Cells["colMaHocVien"].Value;
                string maLop = (string)dgvLop.CurrentRow.Cells["colMaLop"].Value;
                //Xóa học viên có mã ứng với mã vừa lấy
                string strCommand = "DELETE DangKy WHERE MaHocVien=@maHocVien and MaLop=@maLop";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maHocVien", maHocVien);
                parameters.Add("@maLop", maLop);
                try
                {
                    Database.Execute(strCommand, parameters);
                    MessageBox.Show("Đã xóa đăng ký thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dgvHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvHocVien.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaHocVien.Text = row.Cells[0].Value.ToString();
                txtTenHocVien.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvLop.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaLop.Text = row.Cells[0].Value.ToString();
                txtTenLop.Text = row.Cells[1].Value.ToString();

            }
        }

        

        private void btnTimHocVien_Click(object sender, EventArgs e)
        {
            loadDgvHocVien2();
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            loadDgvLop2();
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            string maLop = dgvLop.CurrentRow.Cells["colMaLop"].Value.ToString();
            FrmDanhSachLop form = new FrmDanhSachLop(maLop);
            form.ShowDialog();
        }

        private void chbTenHocVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTimLop_Click_1(object sender, EventArgs e)
        {
            loadDgvLop2();
        }
    }
}
