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
    public partial class FrmDanhSachLop : Form
    {
        private string maLop;
        public FrmDanhSachLop(string maLop)
        {
            InitializeComponent();
            
            this.maLop = maLop;
            loadDgvDSL();
        }
        public FrmDanhSachLop()
        {
            InitializeComponent();
            loadDgvDSL();
        }
        private void loadDgvDSL()
        {
            string a="SELECT DangKy.MaHocVien,DangKy.MaLop,DangKy.Diem,HocVien.Ho,HocVien.Ten,HocVien.NgaySinh,HocVien.GioiTinh,HocVien.DiaChi,HocVien.DienThoai,HocVien.Email FROM DangKy INNER JOIN HocVien ON DangKy.MaHocVien=HocVien.MaHocVien and MaLop="+maLop;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F7JKEJ8;Initial Catalog=QuanLyTrungTamNgoaiNgu;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(a, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Tải dữ liệu lên dataGridView
            dataGridView1.DataSource = dt;

        }
    }
}
