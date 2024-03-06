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
    public partial class FrmNhatKy : Form
    {
        public FrmNhatKy()
        {
            InitializeComponent();
            loadDgvNhatKy();
            loadCbbTaiKhoan();
        }
        private void loadDgvNhatKy(){
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F7JKEJ8;Initial Catalog=QuanLyTrungTamNgoaiNgu;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhatKy", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Tải dữ liệu lên dataGridView
            dataGridView1.DataSource = dt;

        }
        private void loadCbbTaiKhoan()
        {
            comboBox1.DataSource = Database.Query("SELECT * FROM NguoiDung", new Dictionary<string, object>());
        }
        private void loadDgvHocVien2()
        {
            string strQuery = "SELECT * FROM NhatKy WHERE 1=1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (checkBox1.Checked)
            {
                strQuery += " AND TenDangNhap=@tenDangNhap";
                parameters.Add("@tenDangNhap", comboBox1.SelectedValue.ToString());
            }
            if (checkBox2.Checked)
            {
                strQuery += " AND NoiDung LIKE '%' + @noiDung + '%'";
                parameters.Add("@noiDung", textBox1.Text);
            }
            if (checkBox3.Checked)
            {
                strQuery += " AND ThoiDiem>=@ngaySinhTu";
                parameters.Add("@ngaySinhTu", dateTimePicker1.Value.Date);
            }
            if (checkBox4.Checked)
            {
                strQuery += " AND ThoiDiem<=@ngaySinhTu";
                parameters.Add("@ngaySinhTu", dateTimePicker2.Value.Date);
            }
            DataTable HocViens = Database.Query(strQuery, parameters);
            //Đẩy dữ liệu lên data gridview
            dataGridView1.DataSource = HocViens;
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvHocVien2();
        }
        
        
    }
}
