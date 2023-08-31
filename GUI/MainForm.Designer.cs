﻿namespace GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnSach = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnKhoSach = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSachYeuCau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTacGia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTheLoai = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNhaPhanPhoi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPhieuMuon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDocGia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnSach,
            this.btnTacGia,
            this.btnTheLoai,
            this.btnNhaPhanPhoi,
            this.btnPhieuMuon,
            this.btnBaoCao,
            this.btnDocGia,
            this.btnNhanVien,
            this.btnUser,
            this.btnDangXuat});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(312, 781);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnSach
            // 
            this.btnSach.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Appearance.Default.Options.UseFont = true;
            this.btnSach.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Appearance.Disabled.Options.UseFont = true;
            this.btnSach.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Appearance.Hovered.Options.UseFont = true;
            this.btnSach.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Appearance.Normal.Options.UseFont = true;
            this.btnSach.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Appearance.Pressed.Options.UseFont = true;
            this.btnSach.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnKhoSach,
            this.btnSachYeuCau});
            this.btnSach.Expanded = true;
            this.btnSach.Name = "btnSach";
            this.btnSach.Text = "Sách";
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnKhoSach
            // 
            this.btnKhoSach.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoSach.Appearance.Default.Options.UseFont = true;
            this.btnKhoSach.Name = "btnKhoSach";
            this.btnKhoSach.Text = "Kho Sách";
            this.btnKhoSach.Click += new System.EventHandler(this.btnKhoSach_Click);
            // 
            // btnSachYeuCau
            // 
            this.btnSachYeuCau.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachYeuCau.Appearance.Default.Options.UseFont = true;
            this.btnSachYeuCau.Name = "btnSachYeuCau";
            this.btnSachYeuCau.Text = "Element2";
            // 
            // btnTacGia
            // 
            this.btnTacGia.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Appearance.Default.Options.UseFont = true;
            this.btnTacGia.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Appearance.Disabled.Options.UseFont = true;
            this.btnTacGia.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Appearance.Hovered.Options.UseFont = true;
            this.btnTacGia.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Appearance.Normal.Options.UseFont = true;
            this.btnTacGia.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Appearance.Pressed.Options.UseFont = true;
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTacGia.Text = "Tác Giả";
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.Appearance.Default.Options.UseFont = true;
            this.btnTheLoai.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.Appearance.Disabled.Options.UseFont = true;
            this.btnTheLoai.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.Appearance.Hovered.Options.UseFont = true;
            this.btnTheLoai.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.Appearance.Normal.Options.UseFont = true;
            this.btnTheLoai.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.Appearance.Pressed.Options.UseFont = true;
            this.btnTheLoai.Expanded = true;
            this.btnTheLoai.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTheLoai.Text = "Thể Loại";
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnNhaPhanPhoi
            // 
            this.btnNhaPhanPhoi.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaPhanPhoi.Appearance.Default.Options.UseFont = true;
            this.btnNhaPhanPhoi.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaPhanPhoi.Appearance.Disabled.Options.UseFont = true;
            this.btnNhaPhanPhoi.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaPhanPhoi.Appearance.Hovered.Options.UseFont = true;
            this.btnNhaPhanPhoi.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaPhanPhoi.Appearance.Normal.Options.UseFont = true;
            this.btnNhaPhanPhoi.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaPhanPhoi.Appearance.Pressed.Options.UseFont = true;
            this.btnNhaPhanPhoi.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnNhaPhanPhoi.Name = "btnNhaPhanPhoi";
            this.btnNhaPhanPhoi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNhaPhanPhoi.Text = "Nhà Phân Phối";
            this.btnNhaPhanPhoi.Click += new System.EventHandler(this.btnNhaPhanPhoi_Click);
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.Appearance.Default.Options.UseFont = true;
            this.btnPhieuMuon.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.Appearance.Disabled.Options.UseFont = true;
            this.btnPhieuMuon.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.Appearance.Hovered.Options.UseFont = true;
            this.btnPhieuMuon.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.Appearance.Normal.Options.UseFont = true;
            this.btnPhieuMuon.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.Appearance.Pressed.Options.UseFont = true;
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Text = "Phiếu Mượn";
            this.btnPhieuMuon.Click += new System.EventHandler(this.btnPhieuMuon_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Default.Options.UseFont = true;
            this.btnBaoCao.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Disabled.Options.UseFont = true;
            this.btnBaoCao.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Hovered.Options.UseFont = true;
            this.btnBaoCao.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Normal.Options.UseFont = true;
            this.btnBaoCao.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Pressed.Options.UseFont = true;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Appearance.Default.Options.UseFont = true;
            this.btnNhanVien.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Appearance.Disabled.Options.UseFont = true;
            this.btnNhanVien.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Appearance.Hovered.Options.UseFont = true;
            this.btnNhanVien.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Appearance.Normal.Options.UseFont = true;
            this.btnNhanVien.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Appearance.Pressed.Options.UseFont = true;
            this.btnNhanVien.Expanded = true;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Appearance.Default.Options.UseFont = true;
            this.btnDocGia.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Appearance.Disabled.Options.UseFont = true;
            this.btnDocGia.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Appearance.Hovered.Options.UseFont = true;
            this.btnDocGia.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Appearance.Normal.Options.UseFont = true;
            this.btnDocGia.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Appearance.Pressed.Options.UseFont = true;
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDocGia.Text = "Độc Giả";
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnUser
            // 
            this.btnUser.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Appearance.Default.Options.UseFont = true;
            this.btnUser.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Appearance.Disabled.Options.UseFont = true;
            this.btnUser.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Appearance.Hovered.Options.UseFont = true;
            this.btnUser.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Appearance.Normal.Options.UseFont = true;
            this.btnUser.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Appearance.Pressed.Options.UseFont = true;
            this.btnUser.Name = "btnUser";
            this.btnUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUser.Text = "User";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Default.Options.UseFont = true;
            this.btnDangXuat.Appearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Disabled.Options.UseFont = true;
            this.btnDangXuat.Appearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Hovered.Options.UseFont = true;
            this.btnDangXuat.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Normal.Options.UseFont = true;
            this.btnDangXuat.Appearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Pressed.Options.UseFont = true;
            this.btnDangXuat.Expanded = true;
            this.btnDangXuat.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1511, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Container);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(312, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1199, 781);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Container
            // 
            this.Container.Location = new System.Drawing.Point(12, 12);
            this.Container.Margin = new System.Windows.Forms.Padding(4);
            this.Container.MinimumSize = new System.Drawing.Size(1037, 681);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1175, 757);
            this.Container.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1199, 781);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Container;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1179, 761);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1511, 820);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSach;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTacGia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTheLoai;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhaPhanPhoi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDocGia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPhieuMuon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBaoCao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKhoSach;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSachYeuCau;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUser;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer Container;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}