using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyTrungTamNgoaiNgu
{
    public partial class FrmThemLop : Form
    {
        private void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        private void loadCbbGiaoVien()
        {
            cbbMaGiaoVien.DataSource = Database.Query("SELECT *,(Ho+' '+Ten) AS hoten FROM GiaoVien", new Dictionary<string, object>());
        }
        public FrmThemLop()
        {
            InitializeComponent();
            loadCbbNgoaiNgu();
            loadCbbGiaoVien();
        }

        private void FrmThemLop_Load(object sender, EventArgs e)
        {

        }


        private void btoLuu_Click(object sender, EventArgs e)
        {
            if (tboMaLop.Text == "" || tboTenLop.Text == "" || tboDiaDiem.Text == "" || tboThoiGian.Text == "")
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                try
                {
                    string strCommand = "INSERT Lop (MaLop,TenLop,MaGiaoVien,NgayBatDau,NgayKetThuc,MaNgoaiNgu,DiaDiem,ThoiGian,GhiChu) VALUES (@maLop,@tenLop,@maGiaoVien,@ngayBatDau,@ngayKetThuc,@maNgoaiNgu,@diaDiem,@thoiGian,@Ghichu)";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@maLop", tboMaLop.Text);
                    parameters.Add("@tenLop", tboTenLop.Text);
                    parameters.Add("@maGiaoVien", cbbMaGiaoVien.SelectedValue.ToString());
                    parameters.Add("@ngayBatDau", dtpNgayBatDau.Value);
                    parameters.Add("@ngayKetThuc", dtpNgayKetThuc.Value);
                    parameters.Add("@maNgoaiNgu", cbbNgoaiNgu.SelectedValue.ToString());
                    parameters.Add("@diaDiem", tboDiaDiem.Text);
                    parameters.Add("@thoiGian", tboThoiGian.Text);
                    parameters.Add("@ghiChu", tboGhiChu.Text);
                    Database.Execute(strCommand, parameters);
                    MessageBox.Show("Đã thêm lớp thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trùng mã lớp", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            
        }

        private void btoNgoaiNgu_Click(object sender, EventArgs e)
        {
            FrmQuanLyNgoaiNgu form = new FrmQuanLyNgoaiNgu();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            loadCbbNgoaiNgu();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmThemLop_Load_1(object sender, EventArgs e)
        {

        }

        private void cbbNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btoGiaoVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyGiaoVien form = new FrmQuanLyGiaoVien();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            loadCbbGiaoVien();
        }

        private void tboMaLop_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (tboMaLop.Text.Length >= 3)
            {
                errorProvider1.SetError(tboMaLop, "Chỉ nhập 3 kí tự!");
                tboMaLop.Text = "";
            }
        }
    }
}
