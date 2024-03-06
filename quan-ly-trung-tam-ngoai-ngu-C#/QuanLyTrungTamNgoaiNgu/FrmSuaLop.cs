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
    public partial class FrmSuaLop : Form
    {
        private string maLop;

        private void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        private void loadCbbGiaoVien()
        {
            cbbMaGiaoVien.DataSource = Database.Query("SELECT *,(Ho+' '+Ten) AS hoten FROM GiaoVien", new Dictionary<string, object>());
        }
        public FrmSuaLop()
        {
            InitializeComponent();
            
        }
        private void loadForm()
        {
            //Lấy ra các thông tin của giáo viên dựa vào mã giáo viên
            string strQuery = "SELECT * FROM Lop WHERE MaLop=@maLop";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maLop", maLop);
            DataRow lop = Database.Query(strQuery, parameters).Rows[0];
            //Nạp các thông tin lấy được lên form
            tboMaLop.Text = lop["MaLop"].ToString();
            tboTenLop.Text = lop["TenLop"].ToString();
            
            dtpNgayBatDau.Value = DateTime.Parse(lop["NgayBatDau"].ToString());
            string a = lop["NgayKetThuc"].ToString();
            if (a == "") { }
            else
            {
                dtpNgayKetThuc.Value = DateTime.Parse(lop["NgayKetThuc"].ToString());
            }
            
            
            tboDiaDiem.Text = lop["DiaDiem"].ToString();
            tboThoiGian.Text = lop["ThoiGian"].ToString();
            tboGhiChu.Text = lop["GhiChu"].ToString();
            loadCbbNgoaiNgu();
            loadCbbGiaoVien();
        }
        public FrmSuaLop(string maLop)
        {
            InitializeComponent();
            
            this.maLop = maLop;
            loadForm();
        }

        private void FrmSuaLop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strCommand = "UPDATE Lop SET TenLop=@tenLop,MaGiaoVien=@maGiaoVien,NgayBatDau=@ngayBatDau,NgayKetThuc=@ngayKetThuc,MaNgoaiNgu=@maNgoaiNgu,DiaDiem=@diaDiem,ThoiGian=@ThoiGian,GhiChu=@ghiChu WHERE MaLop="+maLop+"";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenLop", tboTenLop.Text);
            parameters.Add("@maGiaoVien", cbbMaGiaoVien.SelectedValue.ToString());
            parameters.Add("@ngayBatDau", dtpNgayBatDau.Value);
            parameters.Add("@ngayKetThuc", dtpNgayKetThuc.Value);
            
            parameters.Add("@maNgoaiNgu", cbbNgoaiNgu.SelectedValue.ToString());
            parameters.Add("@diaDiem", tboDiaDiem.Text);
            parameters.Add("@thoiGian", tboThoiGian.Text);
            parameters.Add("@ghiChu", tboGhiChu.Text);
           
            Database.Execute(strCommand, parameters);
            MessageBox.Show("Đã cập nhật thông tin lớp thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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

        private void btoGiaoVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyGiaoVien form = new FrmQuanLyGiaoVien();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            loadCbbNgoaiNgu();
        }
    }
}
