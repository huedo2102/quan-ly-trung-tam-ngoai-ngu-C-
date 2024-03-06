
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
    public partial class FrmSuaGiaoVien : Form
    {
        private int maGiaoVien;
        private DataTable trinhDoGiaoViens = new DataTable();
        private void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = Database.Query("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }
        private void loadCbbBangCap()
        {
            cbbBangCap.DataSource = Database.Query("SELECT * FROM BangCap", new Dictionary<string, object>());
        }
        private void loadForm()
        {
            //Lấy ra các thông tin của giáo viên dựa vào mã giáo viên
            string strQuery = "SELECT * FROM GiaoVien WHERE MaGiaoVien=@maGiaoVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            DataRow giaoVien = Database.Query(strQuery, parameters).Rows[0];
            //Nạp các thông tin lấy được lên form
            tboMaGiaoVien.Text = giaoVien["MaGiaoVien"].ToString();
            tboHo.Text = giaoVien["Ho"].ToString();
            tboTen.Text = giaoVien["Ten"].ToString();
            dtpNgaySinh.Value = DateTime.Parse(giaoVien["NgaySinh"].ToString());
            if (giaoVien["GioiTinh"] == null)
                chbGioiTinh.Checked = false;
            else if (giaoVien["GioiTinh"].ToString().ToLower() == "true")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
            tboDiaChi.Text = giaoVien["DiaChi"].ToString();
            tboDienThoai.Text = giaoVien["DienThoai"].ToString();
            tboEmail.Text = giaoVien["Email"].ToString();
            //Lấy ra danh sách các trình độ ngoại ngữ ứng với mã giáo viên
            strQuery = "SELECT TrinhDoGiaoVien.MaNgoaiNgu,TrinhDoGiaoVien.MaBangCap,TenNgoaiNgu,TenBangCap,GhiChu"
                + " FROM TrinhDoGiaoVien"
                + " INNER JOIN NgoaiNgu ON TrinhDoGiaoVien.MaNgoaiNgu = NgoaiNgu.MaNgoaiNgu"
                + " INNER JOIN BangCap ON TrinhDoGiaoVien.MaBangCap = BangCap.MaBangCap"
                + " WHERE MaGiaoVien=@maGiaoVien";
            DataTable trinhDoGiaoViens = Database.Query(strQuery, parameters);
            //Đẩy dữ liệu lên data gridview
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
        }
        public FrmSuaGiaoVien(int maGiaoVien)
        {
            InitializeComponent();
            loadCbbNgoaiNgu();
            loadCbbBangCap();
            dgvTrinhDoGiaoVien.AutoGenerateColumns = false;
            trinhDoGiaoViens.Columns.Add("MaNgoaiNgu");
            trinhDoGiaoViens.Columns.Add("TenNgoaiNgu");
            trinhDoGiaoViens.Columns.Add("MaBangCap");
            trinhDoGiaoViens.Columns.Add("TenBangCap");
            trinhDoGiaoViens.Columns.Add("GhiChu");
            //Nhận mã giáo viên được truyền vào
            this.maGiaoVien = maGiaoVien;
            //Dựa vào mã giáo viên nhận được, lấy ra các thông tin của giáo viên và nạp lên form
            loadForm();
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            
            try
            {
                string strCommand = "UPDATE GiaoVien SET Ho=@ho,Ten=@ten,NgaySinh=@ngaySinh,GioiTinh=@gioiTinh,DiaChi=@diaChi,DienThoai=@dienThoai,Email=@email WHERE MaGiaoVien=@maGiaoVien";
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
                parameters.Add("@maGiaoVien", maGiaoVien);
                Database.Execute(strCommand, parameters);

                strCommand = "INSERT TrinhDoGiaoVien VALUES(@maGiaoVien,@maNgoaiNgu,@maBangCap,@ghiChu)";
                for (int i = 0; i < trinhDoGiaoViens.Rows.Count; ++i)
                {
                    parameters = new Dictionary<string, object>();
                    parameters.Add("@maGiaoVien", maGiaoVien);
                    parameters.Add("@maNgoaiNgu", trinhDoGiaoViens.Rows[i]["MaNgoaiNgu"]);
                    parameters.Add("@maBangCap", trinhDoGiaoViens.Rows[i]["MaBangCap"]);
                    parameters.Add("@ghiChu", trinhDoGiaoViens.Rows[i]["GhiChu"]);
                    Database.Execute(strCommand, parameters);
                }
                MessageBox.Show("Đã cập nhật thông tin giáo viên thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Giáo viên đã có ngoại ngữ và bằng cấp này rồi", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btoNgoaiNgu_Click(object sender, EventArgs e)
        {
            FrmQuanLyNgoaiNgu form = new FrmQuanLyNgoaiNgu();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            loadCbbNgoaiNgu();
        }

        private void btoBangCap_Click(object sender, EventArgs e)
        {
            FrmQuanLyBangCap form = new FrmQuanLyBangCap();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            loadCbbBangCap();
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            erpMessage.Clear();
            for (int i = 0; i < trinhDoGiaoViens.Rows.Count; ++i)
                if (trinhDoGiaoViens.Rows[i]["MaNgoaiNgu"].ToString() == cbbNgoaiNgu.SelectedValue.ToString() && trinhDoGiaoViens.Rows[i]["MaBangCap"].ToString() == cbbBangCap.SelectedValue.ToString())
                {
                    erpMessage.SetError(cbbNgoaiNgu, "Ngoại ngữ và bằng cấp này đã được thêm");
                    erpMessage.SetError(cbbBangCap, "Ngoại ngữ và bằng cấp này đã được thêm");
                    return;
                }
            DataRow trinhDoGiaoVien = trinhDoGiaoViens.NewRow();
            trinhDoGiaoVien["MaNgoaiNgu"] = cbbNgoaiNgu.SelectedValue.ToString();
            trinhDoGiaoVien["TenNgoaiNgu"] = cbbNgoaiNgu.Text;
            trinhDoGiaoVien["MaBangCap"] = cbbBangCap.SelectedValue.ToString();
            trinhDoGiaoVien["TenBangCap"] = cbbBangCap.Text;
            trinhDoGiaoVien["GhiChu"] = tboGhiChu.Text;
            
            trinhDoGiaoViens.Rows.Add(trinhDoGiaoVien);
            
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
            btoXoa.Enabled = dgvTrinhDoGiaoVien.Rows.Count > 0;
            //loadForm();
            
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            trinhDoGiaoViens.Rows.RemoveAt(dgvTrinhDoGiaoVien.CurrentRow.Index);
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoViens;
            btoXoa.Enabled = dgvTrinhDoGiaoVien.Rows.Count > 0;

            
            
        }

        private void dgvTrinhDoGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTrinhDoGiaoVien.CurrentRow.Index;
            cbbNgoaiNgu.SelectedValue = dgvTrinhDoGiaoVien.Rows[i].Cells[0].Value.ToString();
            cbbBangCap.SelectedValue = dgvTrinhDoGiaoVien.Rows[i].Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa trình độ giáo viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maNgoaiNgu = dgvTrinhDoGiaoVien.CurrentRow.Cells["colMaNgoaiNgu"].Value.ToString();
                string maBangCap = dgvTrinhDoGiaoVien.CurrentRow.Cells["colMaBangCap"].Value.ToString();
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                //Xóa giáo viên có mã ứng với mã vừa lấy
                string strCommand = "DELETE TrinhDoGiaoVien WHERE MaGiaoVien=@maGiaoVien AND MaNgoaiNgu=@maNgoaiNgu AND MaBangCap=@maBangCap";
                parameters.Add("@maGiaoVien", maGiaoVien);
                parameters.Add("@maNgoaiNgu", maNgoaiNgu);
                parameters.Add("@maBangCap", maBangCap);
                Database.Execute(strCommand, parameters);
                

                //Nạp lại bảng dữ liệu
                loadForm();
            }
        }
    }
}
