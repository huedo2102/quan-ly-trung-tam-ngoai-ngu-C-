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
    public partial class FrmQuanLyBangCap : Form
    {
        public FrmQuanLyBangCap()
        {
            InitializeComponent();
        }

        private void btoDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool checkForm()
        {
            eprError.Clear();
            bool ketQua = true;
            if (tboMaBangCap.Text.Trim() == "")
            {
                //MessageBox.Show("Chưa điền mã ngoại ngữ");
                eprError.SetError(tboMaBangCap, "Chưa điền mã bằng cấp");
                ketQua = false;
            }
            if (tboMaBangCap.Text.Length > 3)
            {
                //MessageBox.Show("Mã ngoại ngữ không đúng định dạng");
                eprError.SetError(tboMaBangCap, "Mã bằng cấp không đúng định dạng");
                ketQua = false;
            }
            if (tboTenBangCap.Text.Trim() == "")
            {
                //MessageBox.Show("Chưa điền tên ngoại ngữ");
                eprError.SetError(tboTenBangCap, "Chưa điền tên bằng cấp");
                ketQua = false;
            }
            if (tboTenBangCap.Text.Length > 30)
            {
                //MessageBox.Show("Tên ngoại ngữ không đúng định dạng");
                eprError.SetError(tboTenBangCap, "Tên bằng cấp không đúng định dạng");
                ketQua = false;
            }
            
            if (ketQua == false)
                lblStatus.Text = "Thông báo: dữ liệu không đúng định dạng";
            return ketQua;

        }

        private void btoThem_Click(object sender, EventArgs e)
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
            eprError.Clear();
            if (checkForm() == false)
                return;
            string strCommand = "EXEC spThemBangCap @maBangCap,@tenBangCap,@nguoiSua,@kichHoat";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maBangCap", tboMaBangCap.Text);
            parameters.Add("@tenBangCap", tboTenBangCap.Text);
            parameters.Add("@nguoiSua", Program.TenDangNhap);
            parameters.Add("@kichHoat", a);
            try
            {
                Database.Execute(strCommand, parameters);
                loadDgvBangCap();
                lblStatus.Text = "Thông báo: Thêm dữ liệu thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Trùng mã bằng cấp")
                    eprError.SetError(tboMaBangCap, ex.Message);
                else if (ex.Message == "Trùng tên bằng cấp")
                    eprError.SetError(tboTenBangCap, ex.Message);
                lblStatus.Text = "Thông báo: " + ex.Message;
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDgvBangCap()
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
            if (chbTimKiem.Checked == false)
            {
                string strQuery = "SELECT * FROM BangCap";
                DataTable table = Database.Query(strQuery, new Dictionary<string, object>());
                dgvBangCap.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
            else
            {
                string strQuery = "SELECT * FROM dbo.ufTimBangCap(@maBangCap,@tenBangCap,@kichHoat)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (chbMaBangCap.Checked)
                    parameters.Add("@maBangCap", tboMaBangCap.Text);
                else
                    parameters.Add("@maBangCap", "");
                if (chbTenBangCap.Checked)
                    parameters.Add("@tenBangCap", tboTenBangCap.Text);
                else
                    parameters.Add("@tenBangCap", "");
                if (chbKichHoat.Checked)
                    parameters.Add("@kichHoat", a);
                else
                    parameters.Add("@kichHoat", "");
                DataTable table = Database.Query(strQuery, parameters);
                dgvBangCap.DataSource = table;
                btoSua.Enabled = btoXoa.Enabled = table.Rows.Count > 0;
            }
        }

        private void FrmQuanLyBangCap_Load(object sender, EventArgs e)
        {
            loadDgvBangCap();
        }

        private void btoSua_Click(object sender, EventArgs e)
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
            if (checkForm() == false)
                return;
            string strQuery = "SELECT * FROM BangCap WHERE MaBangCap<>@maBangCap AND TenBangCap=@tenBangCap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maBangCap", dgvBangCap.CurrentRow.Cells["colMaBangCap"].Value.ToString());
            parameters.Add("@tenBangCap", tboTenBangCap.Text);
            DataTable table = Database.Query(strQuery, parameters);
            if (table.Rows.Count > 0)
            {
                eprError.SetError(tboTenBangCap, "Trùng tên bằng cấp");
                lblStatus.Text = "Thông báo: Trùng dữ liệu";
                return;
            }
            parameters.Add("@nguoiSua", Program.TenDangNhap);
            parameters.Add("@kichHoat", a);
            string strCommand = "UPDATE BangCap SET TenBangCap=@tenBangCap,NguoiSua=@nguoiSua,ThoiDiem=GETDATE(),KichHoat=@kichHoat WHERE MaBangCap=@maBangCap";
            Database.Execute(strCommand, parameters);
            loadDgvBangCap();
            lblStatus.Text = "Thông báo: Sửa dữ liệu thành công";
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bằng cấp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strCommand = "EXEC spXoaBangCap @maBangCap";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maBangCap", dgvBangCap.CurrentRow.Cells["colMaBangCap"].Value.ToString());
                try
                {
                    Database.Execute(strCommand, parameters);
                    loadDgvBangCap();
                    lblStatus.Text = "Thông báo: Xóa dữ liệu thành công";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Thông báo: " + ex.Message;
                }
            }
            
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            btoTimKiem.Enabled = chbTimKiem.Checked;
            loadDgvBangCap();
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadDgvBangCap();
        }

        private void dgvBangCap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tboMaBangCap.Text = dgvBangCap.Rows[e.RowIndex].Cells["colMaBangCap"].Value.ToString();
                tboTenBangCap.Text = dgvBangCap.Rows[e.RowIndex].Cells["colTenBangCap"].Value.ToString();

            }
        }


    }
}
