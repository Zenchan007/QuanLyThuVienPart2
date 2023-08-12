namespace GUI.Form_PhieuMuon
{
    partial class CRUD_PhieuMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenPhieuMuon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbTrangThai = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuMuon_Sach = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKiemTra = new FontAwesome.Sharp.IconButton();
            this.cbbTenSach = new System.Windows.Forms.ComboBox();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgPhieuMuon_Sach = new System.Windows.Forms.DataGridView();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon_Sach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 933);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1717, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1717, 172);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtTenPhieuMuon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1717, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTenPhieuMuon
            // 
            this.txtTenPhieuMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenPhieuMuon.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhieuMuon.Location = new System.Drawing.Point(647, 65);
            this.txtTenPhieuMuon.Name = "txtTenPhieuMuon";
            this.txtTenPhieuMuon.Size = new System.Drawing.Size(423, 42);
            this.txtTenPhieuMuon.TabIndex = 0;
            this.txtTenPhieuMuon.Text = "Tên Phiếu Mượn";
            this.txtTenPhieuMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 761);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 761);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Mượn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDocGia);
            this.panel4.Controls.Add(this.txtNhanVien);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 497);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 199);
            this.panel4.TabIndex = 13;
            // 
            // txtDocGia
            // 
            this.txtDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocGia.Enabled = false;
            this.txtDocGia.Location = new System.Drawing.Point(149, 157);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(201, 30);
            this.txtDocGia.TabIndex = 25;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Location = new System.Drawing.Point(149, 57);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(201, 30);
            this.txtNhanVien.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Độc Giả";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nhân Viên Ghi";
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(3, 696);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(493, 62);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm Thông Tin Phiếu Mượn";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbTrangThai);
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Controls.Add(this.dtpNgayTra);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dtpNgayMuon);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 226);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Thời Gian";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTrangThai.AutoSize = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(267, 152);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(96, 22);
            this.cbbTrangThai.TabIndex = 22;
            this.cbbTrangThai.Text = "Trạng Thái";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(258, 177);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 30);
            this.comboBox3.TabIndex = 21;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(262, 80);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(201, 30);
            this.dtpNgayTra.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày Trả Dự Kiến";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(28, 80);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(201, 30);
            this.dtpNgayMuon.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số Ngày";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày Mượn";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(28, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 30);
            this.textBox3.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemPhieuMuon_Sach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnKiemTra);
            this.groupBox3.Controls.Add(this.cbbTenSach);
            this.groupBox3.Controls.Add(this.cbbTacGia);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 245);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Sách";
            // 
            // btnThemPhieuMuon_Sach
            // 
            this.btnThemPhieuMuon_Sach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemPhieuMuon_Sach.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemPhieuMuon_Sach.IconColor = System.Drawing.Color.Black;
            this.btnThemPhieuMuon_Sach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemPhieuMuon_Sach.Location = new System.Drawing.Point(262, 190);
            this.btnThemPhieuMuon_Sach.Name = "btnThemPhieuMuon_Sach";
            this.btnThemPhieuMuon_Sach.Size = new System.Drawing.Size(201, 32);
            this.btnThemPhieuMuon_Sach.TabIndex = 17;
            this.btnThemPhieuMuon_Sach.Text = "Thêm Vào Phiếu Mượn";
            this.btnThemPhieuMuon_Sach.UseVisualStyleBackColor = true;
            this.btnThemPhieuMuon_Sach.Click += new System.EventHandler(this.btnThemPhieuMuon_Sach_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Tác Giả";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Sách";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKiemTra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnKiemTra.IconColor = System.Drawing.Color.Black;
            this.btnKiemTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKiemTra.Location = new System.Drawing.Point(262, 137);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(201, 32);
            this.btnKiemTra.TabIndex = 13;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // cbbTenSach
            // 
            this.cbbTenSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTenSach.FormattingEnabled = true;
            this.cbbTenSach.Location = new System.Drawing.Point(28, 89);
            this.cbbTenSach.Name = "cbbTenSach";
            this.cbbTenSach.Size = new System.Drawing.Size(201, 30);
            this.cbbTenSach.TabIndex = 5;
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(28, 192);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(201, 30);
            this.cbbTacGia.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Location = new System.Drawing.Point(262, 89);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(201, 30);
            this.txtSoLuong.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgPhieuMuon_Sach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(499, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1218, 761);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách - Số Lượng";
            // 
            // dtgPhieuMuon_Sach
            // 
            this.dtgPhieuMuon_Sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPhieuMuon_Sach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPhieuMuon_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuMuon_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSach,
            this.TenTacGia,
            this.TenTheLoai,
            this.SoLuong,
            this.Xoa});
            this.dtgPhieuMuon_Sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPhieuMuon_Sach.Location = new System.Drawing.Point(4, 27);
            this.dtgPhieuMuon_Sach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPhieuMuon_Sach.Name = "dtgPhieuMuon_Sach";
            this.dtgPhieuMuon_Sach.RowHeadersWidth = 51;
            this.dtgPhieuMuon_Sach.RowTemplate.Height = 24;
            this.dtgPhieuMuon_Sach.Size = new System.Drawing.Size(1210, 730);
            this.dtgPhieuMuon_Sach.TabIndex = 0;
            this.dtgPhieuMuon_Sach.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieuMuon_Sach_CellMouseEnter);
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách Mượn";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // TenTacGia
            // 
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // CRUD_PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 1033);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_PhieuMuon";
            this.Text = "CRUD_PhieuMuon";
            this.Load += new System.EventHandler(this.CRUD_PhieuMuon_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon_Sach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgPhieuMuon_Sach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbTenSach;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnKiemTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnThemPhieuMuon_Sach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDocGia;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTenPhieuMuon;
        private System.Windows.Forms.Label cbbTrangThai;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}