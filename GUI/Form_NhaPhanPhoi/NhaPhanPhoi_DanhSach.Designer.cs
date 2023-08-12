namespace GUI.Form_NhaPhanPhoi
{
    partial class NhaPhanPhoi_DanhSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTrangDau = new FontAwesome.Sharp.IconButton();
            this.btnTruoc = new FontAwesome.Sharp.IconButton();
            this.btnSau = new FontAwesome.Sharp.IconButton();
            this.btnTrangCuoi = new FontAwesome.Sharp.IconButton();
            this.txtTrang = new System.Windows.Forms.TextBox();
            this.dtgNhaPhanPhoi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaPhanPhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhaPhanPhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.dtgNhaPhanPhoi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1482, 638);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.btnTrangDau, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTruoc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSau, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTrangCuoi, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTrang, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 534);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1476, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnTrangDau
            // 
            this.btnTrangDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrangDau.IconChar = FontAwesome.Sharp.IconChar.BackwardFast;
            this.btnTrangDau.IconColor = System.Drawing.Color.Black;
            this.btnTrangDau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangDau.Location = new System.Drawing.Point(357, 21);
            this.btnTrangDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrangDau.Name = "btnTrangDau";
            this.btnTrangDau.Size = new System.Drawing.Size(106, 58);
            this.btnTrangDau.TabIndex = 0;
            this.btnTrangDau.UseVisualStyleBackColor = true;
            // 
            // btnTruoc
            // 
            this.btnTruoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTruoc.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnTruoc.IconColor = System.Drawing.Color.Black;
            this.btnTruoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTruoc.Location = new System.Drawing.Point(521, 21);
            this.btnTruoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(106, 58);
            this.btnTruoc.TabIndex = 1;
            this.btnTruoc.UseVisualStyleBackColor = true;
            // 
            // btnSau
            // 
            this.btnSau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSau.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnSau.IconColor = System.Drawing.Color.Black;
            this.btnSau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSau.Location = new System.Drawing.Point(849, 21);
            this.btnSau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(106, 58);
            this.btnSau.TabIndex = 2;
            this.btnSau.UseVisualStyleBackColor = true;
            // 
            // btnTrangCuoi
            // 
            this.btnTrangCuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrangCuoi.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            this.btnTrangCuoi.IconColor = System.Drawing.Color.Black;
            this.btnTrangCuoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangCuoi.Location = new System.Drawing.Point(1013, 21);
            this.btnTrangCuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrangCuoi.Name = "btnTrangCuoi";
            this.btnTrangCuoi.Size = new System.Drawing.Size(106, 58);
            this.btnTrangCuoi.TabIndex = 3;
            this.btnTrangCuoi.UseVisualStyleBackColor = true;
            // 
            // txtTrang
            // 
            this.txtTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrang.Enabled = false;
            this.txtTrang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrang.Location = new System.Drawing.Point(659, 33);
            this.txtTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrang.Name = "txtTrang";
            this.txtTrang.Size = new System.Drawing.Size(158, 33);
            this.txtTrang.TabIndex = 4;
            // 
            // dtgNhaPhanPhoi
            // 
            this.dtgNhaPhanPhoi.AllowUserToAddRows = false;
            this.dtgNhaPhanPhoi.AllowUserToDeleteRows = false;
            this.dtgNhaPhanPhoi.AllowUserToOrderColumns = true;
            this.dtgNhaPhanPhoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgNhaPhanPhoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgNhaPhanPhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhaPhanPhoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenNhaPhanPhoi,
            this.DiaChi,
            this.SoDienThoai,
            this.ChiTiet,
            this.Xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgNhaPhanPhoi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgNhaPhanPhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNhaPhanPhoi.Location = new System.Drawing.Point(3, 19);
            this.dtgNhaPhanPhoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgNhaPhanPhoi.Name = "dtgNhaPhanPhoi";
            this.dtgNhaPhanPhoi.ReadOnly = true;
            this.dtgNhaPhanPhoi.RowHeadersWidth = 51;
            this.dtgNhaPhanPhoi.RowTemplate.Height = 24;
            this.dtgNhaPhanPhoi.Size = new System.Drawing.Size(1476, 615);
            this.dtgNhaPhanPhoi.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã Nhà Phân Phối";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TenNhaPhanPhoi
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TenNhaPhanPhoi.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenNhaPhanPhoi.HeaderText = "Tên Nhà Phân Phối";
            this.TenNhaPhanPhoi.MinimumWidth = 6;
            this.TenNhaPhanPhoi.Name = "TenNhaPhanPhoi";
            this.TenNhaPhanPhoi.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "Chi Tiết";
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            this.ChiTiet.Text = "Xem";
            this.ChiTiet.UseColumnTextForButtonValue = true;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa Nhà Phân Phối";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // NhaPhanPhoi_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 738);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "NhaPhanPhoi_DanhSach";
            this.Text = "NhaPhanPhoi_DanhSach";
            this.Load += new System.EventHandler(this.NhaPhanPhoi_DanhSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhaPhanPhoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnTrangDau;
        private FontAwesome.Sharp.IconButton btnTruoc;
        private FontAwesome.Sharp.IconButton btnSau;
        private FontAwesome.Sharp.IconButton btnTrangCuoi;
        private System.Windows.Forms.TextBox txtTrang;
        private System.Windows.Forms.DataGridView dtgNhaPhanPhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaPhanPhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTiet;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}