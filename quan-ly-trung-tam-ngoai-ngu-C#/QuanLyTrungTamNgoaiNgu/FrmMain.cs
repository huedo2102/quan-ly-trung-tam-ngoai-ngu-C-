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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mniNgoaiNgu_Click(object sender, EventArgs e)
        {
            FrmQuanLyNgoaiNgu form = new FrmQuanLyNgoaiNgu();
            for (int i = 0; i <  this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniBangCap_Click(object sender, EventArgs e)
        {
            FrmQuanLyBangCap form = new FrmQuanLyBangCap();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniGiaoVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyGiaoVien form = new FrmQuanLyGiaoVien();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmDangNhap form = new FrmDangNhap();
            form.ShowDialog();
            if (form.Authentication == false)
                Application.Exit();
            else
            {
                string strQuery = "SELECT * FROM dbo.ufLayPhanQuyen(@tenDangNhap)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", Program.TenDangNhap);
                DataTable chucNangs = Database.Query(strQuery, parameters);
                List<string> lstChucNang = new List<string>();
                for (int i = 0; i < chucNangs.Rows.Count; ++i)
                    lstChucNang.Add(chucNangs.Rows[i]["TenChucNang"].ToString());
                mniNgoaiNgu.Enabled = lstChucNang.Contains("QuanLyNgoaiNgu");
                mniBangCap.Enabled = lstChucNang.Contains("QuanLyBangCap");
                mniGiaoVien.Enabled = lstChucNang.Contains("QuanLyGiaoVien");
                mniHocVien.Enabled = lstChucNang.Contains("QuanLyHocVien");
                mniHeThong.Enabled = lstChucNang.Contains("QuanLyHeThong");
                quảnLýLớpHọcToolStripMenuItem.Enabled = lstChucNang.Contains("QuanLyLopHoc");
                đăngKýToolStripMenuItem.Enabled = lstChucNang.Contains("QuanLyDangKy");
            }

            
        }

        private void mniHocVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyHocVien form = new FrmQuanLyHocVien();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKy form = new FrmDangKy();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLop form = new FrmLop();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void nhậtKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhatKy form = new FrmNhatKy();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung form = new FrmQuanLyNguoiDung();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }
    }
}
