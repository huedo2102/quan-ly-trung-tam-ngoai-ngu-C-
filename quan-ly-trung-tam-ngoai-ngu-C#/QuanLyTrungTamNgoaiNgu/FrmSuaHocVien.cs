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
    public partial class FrmSuaHocVien : Form
    {
        private int maHocVien;

        
        private void loadForm()
        {
            //Lấy ra các thông tin của học viên dựa vào mã học viên
            string strQuery = "SELECT * FROM HocVien WHERE MaHocVien=@maHocVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHocVien", maHocVien);
            DataRow HocVien = Database.Query(strQuery, parameters).Rows[0];
            //Nạp các thông tin lấy được lên form
            tboMaHocVien.Text = HocVien["MaHocVien"].ToString();
            tboHo.Text = HocVien["Ho"].ToString();
            tboTen.Text = HocVien["Ten"].ToString();
            dtpNgaySinh.Value = DateTime.Parse(HocVien["NgaySinh"].ToString());
            if (HocVien["GioiTinh"] == null)
                chbGioiTinh.Checked = false;
            else if (HocVien["GioiTinh"].ToString().ToLower() == "true")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
            tboDiaChi.Text = HocVien["DiaChi"].ToString();
            tboDienThoai.Text = HocVien["DienThoai"].ToString();
            tboEmail.Text = HocVien["Email"].ToString();
            
            
            
        }
        public FrmSuaHocVien(int maHocVien)
        {
            InitializeComponent();
            
            //Nhận mã học viên được truyền vào
            this.maHocVien = maHocVien;
            //Dựa vào mã học viên nhận được, lấy ra các thông tin của học viên và nạp lên form
            loadForm();
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string strCommand = "UPDATE HocVien SET Ho=@ho,Ten=@ten,NgaySinh=@ngaySinh,GioiTinh=@gioiTinh,DiaChi=@diaChi,DienThoai=@dienThoai,Email=@email WHERE MaHocVien=@maHocVien";
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
            parameters.Add("@maHocVien", maHocVien);
            Database.Execute(strCommand, parameters);
            MessageBox.Show("Đã cập nhật thông tin học viên thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
