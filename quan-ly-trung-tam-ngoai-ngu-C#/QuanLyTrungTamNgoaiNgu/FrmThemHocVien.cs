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
    public partial class FrmThemHocVien : Form
    {


        public FrmThemHocVien()
        {
            InitializeComponent();
            
        }

        

        private void btoLuu_Click(object sender, EventArgs e)
        {
            if (tboHo.Text == "" || tboTen.Text == "" || tboDiaChi.Text == "" || tboDienThoai.Text == "" || tboEmail.Text == "")
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                string strCommand = "INSERT HocVien (Ho,Ten,NgaySinh,GioiTinh,DiaChi,DienThoai,Email) VALUES (@ho,@ten,@ngaySinh,@gioiTinh,@diaChi,@dienThoai,@email)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@ho", tboHo.Text);
                parameters.Add("@ten", tboTen.Text);
                parameters.Add("@ngaySinh", dtpNgaySinh.Value);
                if (chbGioiTinh.Checked == false)
                    parameters.Add("@gioiTinh", null);
                else
                    parameters.Add("@gioiTinh", rdbNam.Checked);
                parameters.Add("@diaChi", tboDiaChi.Text);
                parameters.Add("@dienThoai", tboDienThoai.Text);
                parameters.Add("@email", tboEmail.Text);
                Database.Execute(strCommand, parameters);
                int maHocVien = (int)Database.Query("SELECT MAX(MaHocVien) FROM HocVien", new Dictionary<string, object>()).Rows[0][0];

                MessageBox.Show("Đã thêm học viên thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

       
        private void chbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            grbGioiTinh.Enabled = chbGioiTinh.Checked;
        }

        
    }
}
