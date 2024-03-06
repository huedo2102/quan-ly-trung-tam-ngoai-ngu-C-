
namespace QuanLyTrungTamNgoaiNgu
{
    partial class FrmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboMatKhau = new System.Windows.Forms.TextBox();
            this.tboTenDangNhap = new System.Windows.Forms.TextBox();
            this.btoThoat = new System.Windows.Forms.Button();
            this.btoDangNhap = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboMatKhau);
            this.groupBox1.Controls.Add(this.tboTenDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tboMatKhau
            // 
            this.tboMatKhau.Location = new System.Drawing.Point(117, 56);
            this.tboMatKhau.Name = "tboMatKhau";
            this.tboMatKhau.Size = new System.Drawing.Size(257, 25);
            this.tboMatKhau.TabIndex = 1;
            this.tboMatKhau.Enter += new System.EventHandler(this.tboMatKhau_Enter);
            this.tboMatKhau.Leave += new System.EventHandler(this.tboMatKhau_Leave);
            // 
            // tboTenDangNhap
            // 
            this.tboTenDangNhap.Location = new System.Drawing.Point(117, 25);
            this.tboTenDangNhap.Name = "tboTenDangNhap";
            this.tboTenDangNhap.Size = new System.Drawing.Size(257, 25);
            this.tboTenDangNhap.TabIndex = 0;
            this.tboTenDangNhap.Enter += new System.EventHandler(this.tboTenDangNhap_Enter);
            this.tboTenDangNhap.Leave += new System.EventHandler(this.tboTenDangNhap_Leave);
            // 
            // btoThoat
            // 
            this.btoThoat.Image = ((System.Drawing.Image)(resources.GetObject("btoThoat.Image")));
            this.btoThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThoat.Location = new System.Drawing.Point(292, 213);
            this.btoThoat.Name = "btoThoat";
            this.btoThoat.Size = new System.Drawing.Size(100, 35);
            this.btoThoat.TabIndex = 15;
            this.btoThoat.Text = "Thoát";
            this.btoThoat.UseVisualStyleBackColor = true;
            this.btoThoat.Click += new System.EventHandler(this.btoThoat_Click);
            // 
            // btoDangNhap
            // 
            this.btoDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btoDangNhap.Image")));
            this.btoDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoDangNhap.Location = new System.Drawing.Point(178, 213);
            this.btoDangNhap.Name = "btoDangNhap";
            this.btoDangNhap.Size = new System.Drawing.Size(110, 35);
            this.btoDangNhap.TabIndex = 14;
            this.btoDangNhap.Text = "Đăng nhập";
            this.btoDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoDangNhap.UseVisualStyleBackColor = true;
            this.btoDangNhap.Click += new System.EventHandler(this.btoDangNhap_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 260);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btoThoat);
            this.Controls.Add(this.btoDangNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboMatKhau;
        private System.Windows.Forms.TextBox tboTenDangNhap;
        private System.Windows.Forms.Button btoThoat;
        private System.Windows.Forms.Button btoDangNhap;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}