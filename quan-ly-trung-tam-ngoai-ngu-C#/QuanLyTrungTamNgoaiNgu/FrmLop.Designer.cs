namespace QuanLyTrungTamNgoaiNgu
{
    partial class FrmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLop));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.btoThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbHienThiThoiGian = new System.Windows.Forms.CheckBox();
            this.chbHienThiNgoaiNgu = new System.Windows.Forms.CheckBox();
            this.chbHienThiGhiChu = new System.Windows.Forms.CheckBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbGiaoVien = new System.Windows.Forms.ComboBox();
            this.chbGiaoVien = new System.Windows.Forms.CheckBox();
            this.tboDiaDiem = new System.Windows.Forms.TextBox();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.chbDiaDiem = new System.Windows.Forms.CheckBox();
            this.cbbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.chbNgoaiNgu = new System.Windows.Forms.CheckBox();
            this.chbThoiGian = new System.Windows.Forms.CheckBox();
            this.tboThoiGian = new System.Windows.Forms.TextBox();
            this.chbNgayKetThuc = new System.Windows.Forms.CheckBox();
            this.chbNgayBatDau = new System.Windows.Forms.CheckBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.chbTenLop = new System.Windows.Forms.CheckBox();
            this.tboTenLop = new System.Windows.Forms.TextBox();
            this.chbMaLop = new System.Windows.Forms.CheckBox();
            this.tboMaLop = new System.Windows.Forms.TextBox();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnXemDS);
            this.groupBox2.Controls.Add(this.btoXoa);
            this.groupBox2.Controls.Add(this.btoSua);
            this.groupBox2.Controls.Add(this.btoThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(242, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(780, 53);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật";
            // 
            // btnXemDS
            // 
            this.btnXemDS.Location = new System.Drawing.Point(368, 13);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(164, 33);
            this.btnXemDS.TabIndex = 12;
            this.btnXemDS.Text = "Xem danh sách lớp";
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(164, 20);
            this.btoXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(75, 28);
            this.btoXoa.TabIndex = 11;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoSua.Location = new System.Drawing.Point(84, 20);
            this.btoSua.Margin = new System.Windows.Forms.Padding(2);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(75, 28);
            this.btoSua.TabIndex = 10;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(4, 20);
            this.btoThem.Margin = new System.Windows.Forms.Padding(2);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(75, 28);
            this.btoThem.TabIndex = 9;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "QUẢN LÝ LỚP";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chbHienThiThoiGian);
            this.groupBox3.Controls.Add(this.chbHienThiNgoaiNgu);
            this.groupBox3.Controls.Add(this.chbHienThiGhiChu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(246, 383);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(786, 77);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chế độ hiển thị";
            // 
            // chbHienThiThoiGian
            // 
            this.chbHienThiThoiGian.AutoSize = true;
            this.chbHienThiThoiGian.Checked = true;
            this.chbHienThiThoiGian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHienThiThoiGian.Location = new System.Drawing.Point(6, 33);
            this.chbHienThiThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.chbHienThiThoiGian.Name = "chbHienThiThoiGian";
            this.chbHienThiThoiGian.Size = new System.Drawing.Size(87, 22);
            this.chbHienThiThoiGian.TabIndex = 2;
            this.chbHienThiThoiGian.Text = "Thời gian";
            this.chbHienThiThoiGian.UseVisualStyleBackColor = true;
            this.chbHienThiThoiGian.CheckedChanged += new System.EventHandler(this.chbHienThiThoiGian_CheckedChanged);
            // 
            // chbHienThiNgoaiNgu
            // 
            this.chbHienThiNgoaiNgu.AutoSize = true;
            this.chbHienThiNgoaiNgu.Checked = true;
            this.chbHienThiNgoaiNgu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHienThiNgoaiNgu.Location = new System.Drawing.Point(97, 33);
            this.chbHienThiNgoaiNgu.Margin = new System.Windows.Forms.Padding(2);
            this.chbHienThiNgoaiNgu.Name = "chbHienThiNgoaiNgu";
            this.chbHienThiNgoaiNgu.Size = new System.Drawing.Size(94, 22);
            this.chbHienThiNgoaiNgu.TabIndex = 1;
            this.chbHienThiNgoaiNgu.Text = "Ngoại ngữ";
            this.chbHienThiNgoaiNgu.UseVisualStyleBackColor = true;
            this.chbHienThiNgoaiNgu.CheckedChanged += new System.EventHandler(this.chbHIenThiNgoaiNgu_CheckedChanged);
            // 
            // chbHienThiGhiChu
            // 
            this.chbHienThiGhiChu.AutoSize = true;
            this.chbHienThiGhiChu.Checked = true;
            this.chbHienThiGhiChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHienThiGhiChu.Location = new System.Drawing.Point(204, 33);
            this.chbHienThiGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.chbHienThiGhiChu.Name = "chbHienThiGhiChu";
            this.chbHienThiGhiChu.Size = new System.Drawing.Size(78, 22);
            this.chbHienThiGhiChu.TabIndex = 0;
            this.chbHienThiGhiChu.Text = "Ghi chú";
            this.chbHienThiGhiChu.UseVisualStyleBackColor = true;
            this.chbHienThiGhiChu.CheckedChanged += new System.EventHandler(this.chbHienThiGhiChu_CheckedChanged);
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.AllowUserToResizeColumns = false;
            this.dgvLop.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLop,
            this.colTenLop,
            this.colMaGiaoVien,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colNgoaiNgu,
            this.colDiaDiem,
            this.colThoiGian,
            this.colGhiChu});
            this.dgvLop.Location = new System.Drawing.Point(242, 154);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLop.MultiSelect = false;
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.RowTemplate.Height = 28;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(748, 223);
            this.dgvLop.TabIndex = 31;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTimKiem.Controls.Add(this.button1);
            this.grbTimKiem.Controls.Add(this.cbbGiaoVien);
            this.grbTimKiem.Controls.Add(this.chbGiaoVien);
            this.grbTimKiem.Controls.Add(this.tboDiaDiem);
            this.grbTimKiem.Controls.Add(this.btoTimKiem);
            this.grbTimKiem.Controls.Add(this.chbDiaDiem);
            this.grbTimKiem.Controls.Add(this.cbbNgoaiNgu);
            this.grbTimKiem.Controls.Add(this.chbNgoaiNgu);
            this.grbTimKiem.Controls.Add(this.chbThoiGian);
            this.grbTimKiem.Controls.Add(this.tboThoiGian);
            this.grbTimKiem.Controls.Add(this.chbNgayKetThuc);
            this.grbTimKiem.Controls.Add(this.chbNgayBatDau);
            this.grbTimKiem.Controls.Add(this.dtpNgayKetThuc);
            this.grbTimKiem.Controls.Add(this.dtpNgayBatDau);
            this.grbTimKiem.Controls.Add(this.chbTenLop);
            this.grbTimKiem.Controls.Add(this.tboTenLop);
            this.grbTimKiem.Controls.Add(this.chbMaLop);
            this.grbTimKiem.Controls.Add(this.tboMaLop);
            this.grbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiem.Location = new System.Drawing.Point(20, 59);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.grbTimKiem.Size = new System.Drawing.Size(218, 401);
            this.grbTimKiem.TabIndex = 30;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tiêu chí tìm kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "Hiển thị toàn bộ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbGiaoVien
            // 
            this.cbbGiaoVien.DisplayMember = "hoten";
            this.cbbGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiaoVien.Enabled = false;
            this.cbbGiaoVien.FormattingEnabled = true;
            this.cbbGiaoVien.Location = new System.Drawing.Point(91, 279);
            this.cbbGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGiaoVien.Name = "cbbGiaoVien";
            this.cbbGiaoVien.Size = new System.Drawing.Size(123, 25);
            this.cbbGiaoVien.TabIndex = 24;
            this.cbbGiaoVien.ValueMember = "MaGiaoVien";
            // 
            // chbGiaoVien
            // 
            this.chbGiaoVien.AutoSize = true;
            this.chbGiaoVien.Location = new System.Drawing.Point(3, 280);
            this.chbGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.chbGiaoVien.Name = "chbGiaoVien";
            this.chbGiaoVien.Size = new System.Drawing.Size(89, 22);
            this.chbGiaoVien.TabIndex = 23;
            this.chbGiaoVien.Text = "Giáo viên";
            this.chbGiaoVien.UseVisualStyleBackColor = true;
            this.chbGiaoVien.CheckedChanged += new System.EventHandler(this.chbGiaoVien_CheckedChanged);
            // 
            // tboDiaDiem
            // 
            this.tboDiaDiem.Enabled = false;
            this.tboDiaDiem.Location = new System.Drawing.Point(4, 178);
            this.tboDiaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.tboDiaDiem.Name = "tboDiaDiem";
            this.tboDiaDiem.Size = new System.Drawing.Size(180, 24);
            this.tboDiaDiem.TabIndex = 22;
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(52, 356);
            this.btoTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(75, 28);
            this.btoTimKiem.TabIndex = 20;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // chbDiaDiem
            // 
            this.chbDiaDiem.AutoSize = true;
            this.chbDiaDiem.Location = new System.Drawing.Point(4, 156);
            this.chbDiaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.chbDiaDiem.Name = "chbDiaDiem";
            this.chbDiaDiem.Size = new System.Drawing.Size(85, 22);
            this.chbDiaDiem.TabIndex = 21;
            this.chbDiaDiem.Text = "Địa điểm";
            this.chbDiaDiem.UseVisualStyleBackColor = true;
            this.chbDiaDiem.CheckedChanged += new System.EventHandler(this.chbDiaDiem_CheckedChanged);
            // 
            // cbbNgoaiNgu
            // 
            this.cbbNgoaiNgu.DisplayMember = "TenNgoaiNgu";
            this.cbbNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNgoaiNgu.Enabled = false;
            this.cbbNgoaiNgu.FormattingEnabled = true;
            this.cbbNgoaiNgu.Location = new System.Drawing.Point(92, 239);
            this.cbbNgoaiNgu.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNgoaiNgu.Name = "cbbNgoaiNgu";
            this.cbbNgoaiNgu.Size = new System.Drawing.Size(122, 25);
            this.cbbNgoaiNgu.TabIndex = 17;
            this.cbbNgoaiNgu.ValueMember = "MaNgoaiNgu";
            // 
            // chbNgoaiNgu
            // 
            this.chbNgoaiNgu.AutoSize = true;
            this.chbNgoaiNgu.Location = new System.Drawing.Point(4, 240);
            this.chbNgoaiNgu.Margin = new System.Windows.Forms.Padding(2);
            this.chbNgoaiNgu.Name = "chbNgoaiNgu";
            this.chbNgoaiNgu.Size = new System.Drawing.Size(94, 22);
            this.chbNgoaiNgu.TabIndex = 16;
            this.chbNgoaiNgu.Text = "Ngoại ngữ";
            this.chbNgoaiNgu.UseVisualStyleBackColor = true;
            this.chbNgoaiNgu.CheckedChanged += new System.EventHandler(this.chbNgoaiNgu_CheckedChanged);
            // 
            // chbThoiGian
            // 
            this.chbThoiGian.AutoSize = true;
            this.chbThoiGian.Location = new System.Drawing.Point(4, 213);
            this.chbThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.chbThoiGian.Name = "chbThoiGian";
            this.chbThoiGian.Size = new System.Drawing.Size(87, 22);
            this.chbThoiGian.TabIndex = 13;
            this.chbThoiGian.Text = "Thời gian";
            this.chbThoiGian.UseVisualStyleBackColor = true;
            this.chbThoiGian.CheckedChanged += new System.EventHandler(this.chbThoiGian_CheckedChanged);
            // 
            // tboThoiGian
            // 
            this.tboThoiGian.Enabled = false;
            this.tboThoiGian.Location = new System.Drawing.Point(95, 211);
            this.tboThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.tboThoiGian.Name = "tboThoiGian";
            this.tboThoiGian.Size = new System.Drawing.Size(95, 24);
            this.tboThoiGian.TabIndex = 12;
            // 
            // chbNgayKetThuc
            // 
            this.chbNgayKetThuc.AutoSize = true;
            this.chbNgayKetThuc.Location = new System.Drawing.Point(4, 120);
            this.chbNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.chbNgayKetThuc.Name = "chbNgayKetThuc";
            this.chbNgayKetThuc.Size = new System.Drawing.Size(117, 22);
            this.chbNgayKetThuc.TabIndex = 9;
            this.chbNgayKetThuc.Text = "Ngày kết thúc";
            this.chbNgayKetThuc.UseVisualStyleBackColor = true;
            this.chbNgayKetThuc.CheckedChanged += new System.EventHandler(this.chbNgayKetThuc_CheckedChanged);
            // 
            // chbNgayBatDau
            // 
            this.chbNgayBatDau.AutoSize = true;
            this.chbNgayBatDau.Location = new System.Drawing.Point(4, 95);
            this.chbNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.chbNgayBatDau.Name = "chbNgayBatDau";
            this.chbNgayBatDau.Size = new System.Drawing.Size(117, 22);
            this.chbNgayBatDau.TabIndex = 8;
            this.chbNgayBatDau.Text = "Ngày bắt đầu ";
            this.chbNgayBatDau.UseVisualStyleBackColor = true;
            this.chbNgayBatDau.CheckedChanged += new System.EventHandler(this.chbNgayBatDau_CheckedChanged);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Enabled = false;
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(122, 120);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(94, 24);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Enabled = false;
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(122, 93);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(92, 24);
            this.dtpNgayBatDau.TabIndex = 6;
            // 
            // chbTenLop
            // 
            this.chbTenLop.AutoSize = true;
            this.chbTenLop.Location = new System.Drawing.Point(4, 49);
            this.chbTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.chbTenLop.Name = "chbTenLop";
            this.chbTenLop.Size = new System.Drawing.Size(81, 22);
            this.chbTenLop.TabIndex = 5;
            this.chbTenLop.Text = "Tên Lớp";
            this.chbTenLop.UseVisualStyleBackColor = true;
            this.chbTenLop.CheckedChanged += new System.EventHandler(this.chbTenLop_CheckedChanged);
            // 
            // tboTenLop
            // 
            this.tboTenLop.Enabled = false;
            this.tboTenLop.Location = new System.Drawing.Point(88, 49);
            this.tboTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.tboTenLop.Name = "tboTenLop";
            this.tboTenLop.Size = new System.Drawing.Size(95, 24);
            this.tboTenLop.TabIndex = 4;
            // 
            // chbMaLop
            // 
            this.chbMaLop.AutoSize = true;
            this.chbMaLop.Location = new System.Drawing.Point(4, 21);
            this.chbMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.chbMaLop.Name = "chbMaLop";
            this.chbMaLop.Size = new System.Drawing.Size(77, 22);
            this.chbMaLop.TabIndex = 1;
            this.chbMaLop.Text = "Mã Lớp";
            this.chbMaLop.UseVisualStyleBackColor = true;
            this.chbMaLop.CheckedChanged += new System.EventHandler(this.chbMaLop_CheckedChanged);
            // 
            // tboMaLop
            // 
            this.tboMaLop.Enabled = false;
            this.tboMaLop.Location = new System.Drawing.Point(89, 20);
            this.tboMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.tboMaLop.Name = "tboMaLop";
            this.tboMaLop.Size = new System.Drawing.Size(95, 24);
            this.tboMaLop.TabIndex = 0;
            // 
            // colMaLop
            // 
            this.colMaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaLop.DataPropertyName = "MaLop";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMaLop.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.ReadOnly = true;
            // 
            // colTenLop
            // 
            this.colTenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Tên Lớp";
            this.colTenLop.MinimumWidth = 200;
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Mã giáo viên";
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.ReadOnly = true;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgayBatDau.DataPropertyName = "NgayBatDau";
            this.colNgayBatDau.HeaderText = "Ngày bắt đầu ";
            this.colNgayBatDau.MinimumWidth = 110;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgayKetThuc.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.colNgayKetThuc.DefaultCellStyle = dataGridViewCellStyle4;
            this.colNgayKetThuc.FillWeight = 110F;
            this.colNgayKetThuc.HeaderText = "Ngày kết thúc";
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.ReadOnly = true;
            // 
            // colNgoaiNgu
            // 
            this.colNgoaiNgu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgoaiNgu.DataPropertyName = "MaNgoaiNgu";
            this.colNgoaiNgu.HeaderText = "Ngoại ngữ";
            this.colNgoaiNgu.Name = "colNgoaiNgu";
            this.colNgoaiNgu.ReadOnly = true;
            // 
            // colDiaDiem
            // 
            this.colDiaDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaDiem.DataPropertyName = "DiaDiem";
            this.colDiaDiem.HeaderText = "Địa điểm";
            this.colDiaDiem.Name = "colDiaDiem";
            this.colDiaDiem.ReadOnly = true;
            // 
            // colThoiGian
            // 
            this.colThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThoiGian.DataPropertyName = "ThoiGian";
            this.colThoiGian.HeaderText = "Thời gian";
            this.colThoiGian.MinimumWidth = 130;
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.grbTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ LỚP";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbHienThiThoiGian;
        private System.Windows.Forms.CheckBox chbHienThiNgoaiNgu;
        private System.Windows.Forms.CheckBox chbHienThiGhiChu;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox tboDiaDiem;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.CheckBox chbDiaDiem;
        private System.Windows.Forms.ComboBox cbbNgoaiNgu;
        private System.Windows.Forms.CheckBox chbNgoaiNgu;
        private System.Windows.Forms.CheckBox chbThoiGian;
        private System.Windows.Forms.TextBox tboThoiGian;
        private System.Windows.Forms.CheckBox chbNgayKetThuc;
        private System.Windows.Forms.CheckBox chbNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.CheckBox chbTenLop;
        private System.Windows.Forms.TextBox tboTenLop;
        private System.Windows.Forms.CheckBox chbMaLop;
        private System.Windows.Forms.TextBox tboMaLop;
        private System.Windows.Forms.ComboBox cbbGiaoVien;
        private System.Windows.Forms.CheckBox chbGiaoVien;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}