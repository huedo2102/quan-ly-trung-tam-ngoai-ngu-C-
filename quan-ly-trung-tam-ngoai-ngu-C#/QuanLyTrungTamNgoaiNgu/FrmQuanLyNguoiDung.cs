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
    public partial class FrmQuanLyNguoiDung : Form
    {
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;
            textBox5.UseSystemPasswordChar = true;
            loadCbbNguoiDung();
            loadCbbNguoiDung2();
            loadCbbChucNang();
            loadForm();
        }
        private void loadForm() {
            string strQuery = "select TenDangNhap, TenChucNang from PhanQuyen inner join ChucNang on PhanQuyen.MaChucNang=ChucNang.MaChucNang"
                + " WHERE TenDangNhap=@tenDangNhap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", comboBox1.SelectedValue.ToString());
            DataTable trinhDoGiaoViens = Database.Query(strQuery, parameters);

            //Đẩy dữ liệu lên treeview
            treeView1.Nodes.Clear();
            TreeNode node = new TreeNode("Tài khoản " + comboBox1.SelectedValue.ToString() + " có các chức năng:");
            for (int i = 0; i < trinhDoGiaoViens.Rows.Count; ++i)
            {
                node.Nodes.Add(trinhDoGiaoViens.Rows[i]["TenChucNang"].ToString());
                node.Expand();
            }
            treeView1.Nodes.Add(node);
        }
        private void loadCbbChucNang()
        {

            comboBox2.DataSource = Database.Query("SELECT * FROM ChucNang", new Dictionary<string, object>());
        }
        private void loadCbbNguoiDung()
        {

            comboBox3.DataSource = Database.Query("SELECT * FROM NguoiDung", new Dictionary<string, object>());
        }
        private void loadCbbNguoiDung2()
        {

            comboBox1.DataSource = Database.Query("SELECT * FROM NguoiDung", new Dictionary<string, object>());
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox3.Text==""||textBox2.Text=="")
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (textBox3.Text != textBox2.Text)
                MessageBox.Show("Xác nhận lại mật khẩu chưa chính xác", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                int a=1;
                if (radioButton1.Checked == true)
                {
                    a = 1;
                }
                else if (radioButton2.Checked == true)
                {
                    a = 0;
                }
                try
                {
                    string strCommand = "INSERT NguoiDung (TenDangNhap,MatKhau,TrangThai) VALUES (@tenDangNhap,@matKhau,@trangThai)";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@tenDangNhap", textBox1.Text);
                    parameters.Add("@matKhau", textBox2.Text);
                    parameters.Add("@trangThai", a);

                    Database.Execute(strCommand, parameters);

                    MessageBox.Show("Đã thêm người dùng thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCbbNguoiDung();
                    loadCbbNguoiDung2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tên đăng nhập này có rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }


            
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" && textBox5.Text == ""){
                int a = 1;
                if (radioButton4.Checked == true)
                {
                    a = 1;
                }
                else if (radioButton3.Checked == true)
                {
                    a = 0;
                }
                string strCommand = "UPDATE NguoiDung SET TrangThai=@trangThai WHERE TenDangNhap=@tenDangNhap";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", comboBox3.SelectedValue.ToString());
                parameters.Add("@trangThai", a);

                Database.Execute(strCommand, parameters);
                MessageBox.Show("Đã cập nhật thông tin người dùng thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCbbNguoiDung2();
                loadCbbNguoiDung();
            }

                //MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (textBox4.Text != textBox5.Text)
                MessageBox.Show("Xác nhận lại mật khẩu chưa chính xác", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int a = 1;
                if (radioButton4.Checked == true)
                {
                    a = 1;
                }
                else if (radioButton3.Checked == true)
                {
                    a = 0;
                }
                string strCommand = "UPDATE NguoiDung SET MatKhau=@matKhau,TrangThai=@trangThai WHERE TenDangNhap=@tenDangNhap";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", comboBox3.SelectedValue.ToString());
                parameters.Add("@matKhau", textBox5.Text);
                parameters.Add("@trangThai", a);

                Database.Execute(strCommand, parameters);
                MessageBox.Show("Đã cập nhật thông tin người dùng thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCbbNguoiDung2();
                loadCbbNguoiDung();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strCommand = "EXEC spXoaNguoiDung @tenDangNhap";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", comboBox3.SelectedValue.ToString());
                
                try
                {
                    Database.Execute(strCommand, parameters);
                    loadCbbNguoiDung();
                    loadCbbNguoiDung2();
                    MessageBox.Show("Xóa người dùng thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strCommand = "INSERT PhanQuyen (TenDangNhap,MaChucNang) VALUES (@tenDangNhap,@maChucNang)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@tenDangNhap", comboBox1.SelectedValue.ToString());
                parameters.Add("@maChucNang", comboBox2.SelectedValue.ToString());
                Database.Execute(strCommand, parameters);
                MessageBox.Show("Đã thêm chức năng", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản có chức năng này rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa chức năng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strCommand = "DELETE PhanQuyen WHERE TenDangNhap=@tenDangNhap AND MaChucNang=@maChucNang";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@tenDangNhap", comboBox1.SelectedValue.ToString());
                parameters.Add("@maChucNang", comboBox2.SelectedValue.ToString());
                Database.Execute(strCommand, parameters);
                MessageBox.Show("Đã xóa chức năng thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadForm();
                
                loadCbbChucNang();
            }
            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox1.Text = "Ẩn/Hiện mật khẩu";
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox1.Text = "Ẩn/Hiện mật khẩu";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                
                textBox4.UseSystemPasswordChar = true;
                textBox5.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox2.Text = "Ẩn/Hiện mật khẩu";
            }
            else
            {
                textBox4.UseSystemPasswordChar = false;
                textBox5.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox2.Text = "Ẩn/Hiện mật khẩu";

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
