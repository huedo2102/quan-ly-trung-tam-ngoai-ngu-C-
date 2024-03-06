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
    public partial class FrmDangNhap : Form
    {
        private bool authentication = false;
        public bool Authentication
        {
            get { return authentication; }
        }
        public FrmDangNhap()
        {
            InitializeComponent();
            tboMatKhau.UseSystemPasswordChar = true;
            checkBox1.Text = "Ẩn/Hiện mật khẩu";
            tboTenDangNhap.Focus();
            tboTenDangNhap.ForeColor = Color.LightGray;
            tboTenDangNhap.Text = "Username";
            this.tboTenDangNhap.Leave += new System.EventHandler(this.tboTenDangNhap_Leave);
            this.tboTenDangNhap.Enter += new System.EventHandler(this.tboTenDangNhap_Enter);

            tboMatKhau.ForeColor = Color.LightGray;
            tboMatKhau.Text = "Password";
            this.tboMatKhau.Leave += new System.EventHandler(this.tboMatKhau_Leave);
            this.tboMatKhau.Enter += new System.EventHandler(this.tboMatKhau_Enter);
            tboTenDangNhap.Focus();
        }

        private void btoThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoDangNhap_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spDangNhap @tenDangNhap,@matKhau";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            parameters.Add("@matKhau", tboMatKhau.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                authentication = true;
                Program.TenDangNhap = tboTenDangNhap.Text;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tboTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (tboTenDangNhap.Text == "Username")
            {
                tboTenDangNhap.Text = "";
                tboTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void tboTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (tboTenDangNhap.Text == "")
            {
                tboTenDangNhap.Text = "Username";
                tboTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void tboMatKhau_Enter(object sender, EventArgs e)
        {
            if (tboMatKhau.Text == "Password")
            {
                tboMatKhau.Text = "";
                tboMatKhau.ForeColor = Color.Gray;
            }
        }

        private void tboMatKhau_Leave(object sender, EventArgs e)
        {
            if (tboMatKhau.Text == "")
            {
                tboMatKhau.Text = "Password";
                tboMatKhau.ForeColor = Color.Gray;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tboMatKhau.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                
            }
            else
            {
                tboMatKhau.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                

            }
        }
    }
}
