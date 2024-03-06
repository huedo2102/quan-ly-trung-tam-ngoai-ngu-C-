namespace QuanLyTrungTamNgoaiNgu
{
    partial class FrmSuaLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaLop));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoGiaoVien = new System.Windows.Forms.Button();
            this.cbbMaGiaoVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.tboMaLop = new System.Windows.Forms.TextBox();
            this.btoNgoaiNgu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboDiaDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tboGhiChu = new System.Windows.Forms.TextBox();
            this.tboThoiGian = new System.Windows.Forms.TextBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.tboTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(297, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btoGiaoVien);
            this.groupBox1.Controls.Add(this.cbbMaGiaoVien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.tboMaLop);
            this.groupBox1.Controls.Add(this.btoNgoaiNgu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbNgoaiNgu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboDiaDiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tboGhiChu);
            this.groupBox1.Controls.Add(this.tboThoiGian);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Controls.Add(this.tboTenLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(680, 347);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btoGiaoVien
            // 
            this.btoGiaoVien.Location = new System.Drawing.Point(617, 157);
            this.btoGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.btoGiaoVien.Name = "btoGiaoVien";
            this.btoGiaoVien.Size = new System.Drawing.Size(22, 20);
            this.btoGiaoVien.TabIndex = 42;
            this.btoGiaoVien.Text = "...";
            this.btoGiaoVien.UseVisualStyleBackColor = true;
            this.btoGiaoVien.Click += new System.EventHandler(this.btoGiaoVien_Click);
            // 
            // cbbMaGiaoVien
            // 
            this.cbbMaGiaoVien.DisplayMember = "hoten";
            this.cbbMaGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaGiaoVien.FormattingEnabled = true;
            this.cbbMaGiaoVien.Location = new System.Drawing.Point(466, 157);
            this.cbbMaGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaGiaoVien.Name = "cbbMaGiaoVien";
            this.cbbMaGiaoVien.Size = new System.Drawing.Size(147, 25);
            this.cbbMaGiaoVien.TabIndex = 41;
            this.cbbMaGiaoVien.ValueMember = "MaGiaoVien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Giáo viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ngày kết thúc";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(326, 75);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(86, 24);
            this.dtpNgayKetThuc.TabIndex = 35;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl.Location = new System.Drawing.Point(4, 25);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 18);
            this.lbl.TabIndex = 34;
            this.lbl.Text = "Mã lớp";
            // 
            // tboMaLop
            // 
            this.tboMaLop.Location = new System.Drawing.Point(100, 22);
            this.tboMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.tboMaLop.Name = "tboMaLop";
            this.tboMaLop.ReadOnly = true;
            this.tboMaLop.Size = new System.Drawing.Size(86, 24);
            this.tboMaLop.TabIndex = 33;
            // 
            // btoNgoaiNgu
            // 
            this.btoNgoaiNgu.Location = new System.Drawing.Point(242, 157);
            this.btoNgoaiNgu.Margin = new System.Windows.Forms.Padding(2);
            this.btoNgoaiNgu.Name = "btoNgoaiNgu";
            this.btoNgoaiNgu.Size = new System.Drawing.Size(22, 20);
            this.btoNgoaiNgu.TabIndex = 31;
            this.btoNgoaiNgu.Text = "...";
            this.btoNgoaiNgu.UseVisualStyleBackColor = true;
            this.btoNgoaiNgu.Click += new System.EventHandler(this.btoNgoaiNgu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngoại ngữ";
            // 
            // cbbNgoaiNgu
            // 
            this.cbbNgoaiNgu.DisplayMember = "TenNgoaiNgu";
            this.cbbNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNgoaiNgu.FormattingEnabled = true;
            this.cbbNgoaiNgu.Location = new System.Drawing.Point(100, 157);
            this.cbbNgoaiNgu.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNgoaiNgu.Name = "cbbNgoaiNgu";
            this.cbbNgoaiNgu.Size = new System.Drawing.Size(138, 25);
            this.cbbNgoaiNgu.TabIndex = 30;
            this.cbbNgoaiNgu.ValueMember = "MaNgoaiNgu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thời gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Địa Điểm";
            // 
            // tboDiaDiem
            // 
            this.tboDiaDiem.Location = new System.Drawing.Point(100, 99);
            this.tboDiaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.tboDiaDiem.Name = "tboDiaDiem";
            this.tboDiaDiem.Size = new System.Drawing.Size(346, 24);
            this.tboDiaDiem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label9.Location = new System.Drawing.Point(4, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên Lớp";
            // 
            // tboGhiChu
            // 
            this.tboGhiChu.Location = new System.Drawing.Point(7, 217);
            this.tboGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.tboGhiChu.Multiline = true;
            this.tboGhiChu.Name = "tboGhiChu";
            this.tboGhiChu.Size = new System.Drawing.Size(669, 76);
            this.tboGhiChu.TabIndex = 7;
            // 
            // tboThoiGian
            // 
            this.tboThoiGian.Location = new System.Drawing.Point(100, 124);
            this.tboThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.tboThoiGian.Name = "tboThoiGian";
            this.tboThoiGian.Size = new System.Drawing.Size(139, 24);
            this.tboThoiGian.TabIndex = 6;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(100, 75);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(86, 24);
            this.dtpNgayBatDau.TabIndex = 2;
            // 
            // tboTenLop
            // 
            this.tboTenLop.Location = new System.Drawing.Point(100, 49);
            this.tboTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.tboTenLop.Name = "tboTenLop";
            this.tboTenLop.Size = new System.Drawing.Size(346, 24);
            this.tboTenLop.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "SỬA THÔNG TIN LỚP";
            // 
            // FrmSuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmSuaLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA LỚP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tboMaLop;
        private System.Windows.Forms.Button btoNgoaiNgu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbNgoaiNgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboDiaDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboGhiChu;
        private System.Windows.Forms.TextBox tboThoiGian;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.TextBox tboTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btoGiaoVien;
        private System.Windows.Forms.ComboBox cbbMaGiaoVien;
        private System.Windows.Forms.Label label1;
    }
}