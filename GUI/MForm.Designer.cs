namespace GUI
{
    partial class MForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pcAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Container = new DevExpress.XtraEditors.PanelControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navSach = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnKhoSach = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSachYeuCau = new DevExpress.XtraNavBar.NavBarItem();
            this.navTheLoai = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnTheLoai = new DevExpress.XtraNavBar.NavBarItem();
            this.navTacGia = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnTacGia = new DevExpress.XtraNavBar.NavBarItem();
            this.navNhaPhanPhoi = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnNhaPhanPhoi = new DevExpress.XtraNavBar.NavBarItem();
            this.navPhieuMuon = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnPhieuMuon = new DevExpress.XtraNavBar.NavBarItem();
            this.navDocGia = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnDocGia = new DevExpress.XtraNavBar.NavBarItem();
            this.navBaoCao = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnBaoCao = new DevExpress.XtraNavBar.NavBarItem();
            this.navNhanVien = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.timerDoiAnh = new System.Windows.Forms.Timer(this.components);
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dropDownButton1);
            this.layoutControl1.Controls.Add(this.btnDangXuat);
            this.layoutControl1.Controls.Add(this.pcAvatar);
            this.layoutControl1.Controls.Add(this.Container);
            this.layoutControl1.Controls.Add(this.navBarControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(300, 364, 812, 500);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBorderColor = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1308, 781);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pcAvatar
            // 
            this.pcAvatar.Location = new System.Drawing.Point(264, 2);
            this.pcAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pcAvatar.MenuManager = this.barManager1;
            this.pcAvatar.Name = "pcAvatar";
            this.pcAvatar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pcAvatar.Properties.Appearance.Options.UseBackColor = true;
            this.pcAvatar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcAvatar.Properties.ReadOnly = true;
            this.pcAvatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pcAvatar.Size = new System.Drawing.Size(43, 36);
            this.pcAvatar.StyleController = this.layoutControl1;
            this.pcAvatar.TabIndex = 7;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1308, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 781);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1308, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 781);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1308, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 781);
            // 
            // Container
            // 
            this.Container.Appearance.BackColor = System.Drawing.Color.White;
            this.Container.Appearance.Options.UseBackColor = true;
            this.Container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Container.Location = new System.Drawing.Point(264, 43);
            this.Container.Margin = new System.Windows.Forms.Padding(5);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1042, 736);
            this.Container.TabIndex = 5;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBaoCao;
            this.navBarControl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBaoCao,
            this.navSach,
            this.navTheLoai,
            this.navTacGia,
            this.navNhaPhanPhoi,
            this.navPhieuMuon,
            this.navDocGia,
            this.navNhanVien});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnKhoSach,
            this.btnTheLoai,
            this.btnTacGia,
            this.btnDocGia,
            this.btnPhieuMuon,
            this.btnNhaPhanPhoi,
            this.btnNhanVien,
            this.btnBaoCao,
            this.btnSachYeuCau});
            this.navBarControl.Location = new System.Drawing.Point(2, 2);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(4);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 257;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(257, 777);
            this.navBarControl.TabIndex = 4;
            this.navBarControl.Text = "navBarControl1";
            // 
            // navSach
            // 
            this.navSach.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSach.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSach.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSach.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSach.Caption = "Sách";
            this.navSach.Expanded = true;
            this.navSach.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navSach.ImageOptions.LargeImage")));
            this.navSach.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSach.ImageOptions.SmallImage")));
            this.navSach.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnKhoSach),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSachYeuCau)});
            this.navSach.Name = "navSach";
            // 
            // btnKhoSach
            // 
            this.btnKhoSach.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoSach.Appearance.Options.UseFont = true;
            this.btnKhoSach.Caption = "Kho Sách";
            this.btnKhoSach.Name = "btnKhoSach";
            this.btnKhoSach.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnKhoSach_LinkClicked);
            // 
            // btnSachYeuCau
            // 
            this.btnSachYeuCau.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachYeuCau.Appearance.Options.UseFont = true;
            this.btnSachYeuCau.Caption = "Sách Yêu Cầu";
            this.btnSachYeuCau.Name = "btnSachYeuCau";
            this.btnSachYeuCau.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSachYeuCau_LinkClicked);
            // 
            // navTheLoai
            // 
            this.navTheLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTheLoai.Appearance.Options.UseFont = true;
            this.navTheLoai.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTheLoai.AppearanceBackground.Options.UseFont = true;
            this.navTheLoai.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTheLoai.AppearanceHotTracked.Options.UseFont = true;
            this.navTheLoai.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTheLoai.AppearancePressed.Options.UseFont = true;
            this.navTheLoai.Caption = "Thể Loại";
            this.navTheLoai.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navTheLoai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navTheLoai.ImageOptions.LargeImage")));
            this.navTheLoai.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navTheLoai.ImageOptions.SmallImage")));
            this.navTheLoai.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnTheLoai)});
            this.navTheLoai.Name = "navTheLoai";
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Caption = "Danh Sách Thể Loại";
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnTheLoai_LinkClicked);
            // 
            // navTacGia
            // 
            this.navTacGia.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTacGia.Appearance.Options.UseFont = true;
            this.navTacGia.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTacGia.AppearanceBackground.Options.UseFont = true;
            this.navTacGia.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTacGia.AppearanceHotTracked.Options.UseFont = true;
            this.navTacGia.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navTacGia.AppearancePressed.Options.UseFont = true;
            this.navTacGia.Caption = "Tác Giả";
            this.navTacGia.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navTacGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navTacGia.ImageOptions.LargeImage")));
            this.navTacGia.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navTacGia.ImageOptions.SmallImage")));
            this.navTacGia.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnTacGia)});
            this.navTacGia.Name = "navTacGia";
            // 
            // btnTacGia
            // 
            this.btnTacGia.Caption = "Danh Sách Các Tác Giả";
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnTacGia_LinkClicked);
            // 
            // navNhaPhanPhoi
            // 
            this.navNhaPhanPhoi.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhaPhanPhoi.Appearance.Options.UseFont = true;
            this.navNhaPhanPhoi.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhaPhanPhoi.AppearanceBackground.Options.UseFont = true;
            this.navNhaPhanPhoi.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhaPhanPhoi.AppearanceHotTracked.Options.UseFont = true;
            this.navNhaPhanPhoi.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhaPhanPhoi.AppearancePressed.Options.UseFont = true;
            this.navNhaPhanPhoi.Caption = "Nhà Phân Phối";
            this.navNhaPhanPhoi.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navNhaPhanPhoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navNhaPhanPhoi.ImageOptions.LargeImage")));
            this.navNhaPhanPhoi.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navNhaPhanPhoi.ImageOptions.SmallImage")));
            this.navNhaPhanPhoi.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnNhaPhanPhoi)});
            this.navNhaPhanPhoi.Name = "navNhaPhanPhoi";
            // 
            // btnNhaPhanPhoi
            // 
            this.btnNhaPhanPhoi.Caption = "Danh Sách Nhà Phân Phối";
            this.btnNhaPhanPhoi.Name = "btnNhaPhanPhoi";
            this.btnNhaPhanPhoi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnNhaPhanPhoi_LinkClicked);
            // 
            // navPhieuMuon
            // 
            this.navPhieuMuon.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPhieuMuon.Appearance.Options.UseFont = true;
            this.navPhieuMuon.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPhieuMuon.AppearanceBackground.Options.UseFont = true;
            this.navPhieuMuon.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPhieuMuon.AppearanceHotTracked.Options.UseFont = true;
            this.navPhieuMuon.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPhieuMuon.AppearancePressed.Options.UseFont = true;
            this.navPhieuMuon.Caption = "Ghi Mượn";
            this.navPhieuMuon.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navPhieuMuon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navPhieuMuon.ImageOptions.LargeImage")));
            this.navPhieuMuon.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navPhieuMuon.ImageOptions.SmallImage")));
            this.navPhieuMuon.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPhieuMuon)});
            this.navPhieuMuon.Name = "navPhieuMuon";
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.Caption = "Phiếu Mượn";
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnPhieuMuon_LinkClicked);
            // 
            // navDocGia
            // 
            this.navDocGia.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDocGia.Appearance.Options.UseFont = true;
            this.navDocGia.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDocGia.AppearanceBackground.Options.UseFont = true;
            this.navDocGia.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDocGia.AppearanceHotTracked.Options.UseFont = true;
            this.navDocGia.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDocGia.AppearancePressed.Options.UseFont = true;
            this.navDocGia.Caption = "Độc Giả";
            this.navDocGia.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navDocGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navDocGia.ImageOptions.LargeImage")));
            this.navDocGia.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navDocGia.ImageOptions.SmallImage")));
            this.navDocGia.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDocGia)});
            this.navDocGia.Name = "navDocGia";
            // 
            // btnDocGia
            // 
            this.btnDocGia.Caption = "Danh Sách Độc Giả";
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDocGia_LinkClicked);
            // 
            // navBaoCao
            // 
            this.navBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBaoCao.Appearance.Options.UseFont = true;
            this.navBaoCao.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBaoCao.AppearanceBackground.Options.UseFont = true;
            this.navBaoCao.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBaoCao.AppearanceHotTracked.Options.UseFont = true;
            this.navBaoCao.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBaoCao.AppearancePressed.Options.UseFont = true;
            this.navBaoCao.Caption = "Tổng Quan";
            this.navBaoCao.Expanded = true;
            this.navBaoCao.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBaoCao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBaoCao.ImageOptions.LargeImage")));
            this.navBaoCao.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBaoCao.ImageOptions.SmallImage")));
            this.navBaoCao.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnBaoCao)});
            this.navBaoCao.Name = "navBaoCao";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Caption = "Xem Biểu Đồ Báo Cáo";
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnBaoCao_LinkClicked);
            // 
            // navNhanVien
            // 
            this.navNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhanVien.Appearance.Options.UseFont = true;
            this.navNhanVien.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhanVien.AppearanceBackground.Options.UseFont = true;
            this.navNhanVien.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhanVien.AppearanceHotTracked.Options.UseFont = true;
            this.navNhanVien.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navNhanVien.AppearancePressed.Options.UseFont = true;
            this.navNhanVien.Caption = "Nhân Viên";
            this.navNhanVien.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navNhanVien.ImageOptions.LargeImage")));
            this.navNhanVien.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navNhanVien.ImageOptions.SmallImage")));
            this.navNhanVien.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnNhanVien)});
            this.navNhanVien.Name = "navNhanVien";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Appearance.Options.UseFont = true;
            this.btnNhanVien.Caption = "Danh Sách Nhân Viên";
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnNhanVien_LinkClicked);
            // 
            // Root
            // 
            this.Root.AppearanceGroup.Options.UseBorderColor = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlGroup1,
            this.simpleSeparator2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1308, 781);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Container;
            this.layoutControlItem2.Location = new System.Drawing.Point(262, 41);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1046, 740);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(261, 781);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.simpleSeparator1,
            this.layoutControlItem8,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(262, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1046, 41);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(178, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(765, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 40);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1046, 1);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.pcAvatar;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(47, 40);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(47, 40);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(47, 40);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(261, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(1, 781);
            // 
            // timerDoiAnh
            // 
            this.timerDoiAnh.Interval = 1000;
            this.timerDoiAnh.Tick += new System.EventHandler(this.timerDoiAnh_Tick);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnDangXuat;
            this.layoutControlItem5.Location = new System.Drawing.Point(943, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(103, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDangXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Options.UseBackColor = true;
            this.btnDangXuat.Appearance.Options.UseFont = true;
            this.btnDangXuat.ImageOptions.Image = global::GUI.Properties.Resources.redo_32x32;
            this.btnDangXuat.Location = new System.Drawing.Point(1207, 2);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(99, 36);
            this.btnDangXuat.StyleController = this.layoutControl1;
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(311, 2);
            this.dropDownButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropDownButton1.MenuManager = this.barManager1;
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(127, 27);
            this.dropDownButton1.StyleController = this.layoutControl1;
            this.dropDownButton1.TabIndex = 8;
            this.dropDownButton1.Text = "dropDownButton1";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dropDownButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(47, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(131, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // MForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1308, 781);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = global::GUI.Properties.Resources.library_logo_design_precious_astonishing_131;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Chính";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MForm_FormClosed);
            this.Load += new System.EventHandler(this.MForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navDocGia;
        private DevExpress.XtraNavBar.NavBarGroup navSach;
        private DevExpress.XtraNavBar.NavBarItem btnKhoSach;
        private DevExpress.XtraNavBar.NavBarGroup navTheLoai;
        private DevExpress.XtraNavBar.NavBarGroup navTacGia;
        private DevExpress.XtraNavBar.NavBarGroup navPhieuMuon;
        private DevExpress.XtraNavBar.NavBarGroup navNhaPhanPhoi;
        private DevExpress.XtraNavBar.NavBarGroup navNhanVien;
        private DevExpress.XtraNavBar.NavBarGroup navBaoCao;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraNavBar.NavBarItem btnTheLoai;
        private DevExpress.XtraNavBar.NavBarItem btnDocGia;
        private DevExpress.XtraNavBar.NavBarItem btnTacGia;
        private DevExpress.XtraNavBar.NavBarItem btnBaoCao;
        private DevExpress.XtraNavBar.NavBarItem btnPhieuMuon;
        private DevExpress.XtraNavBar.NavBarItem btnNhaPhanPhoi;
        private DevExpress.XtraNavBar.NavBarItem btnNhanVien;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PictureEdit pcAvatar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.Timer timerDoiAnh;
        private DevExpress.XtraEditors.PanelControl Container;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraNavBar.NavBarItem btnSachYeuCau;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}