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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaPhanPhoi_DanhSach));
            this.dtgSachNhaPhanPhoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SachId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayXb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNhaPhanPhoi = new DevExpress.XtraGrid.GridControl();
            this.dtgNhaPhanPhoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaPhanPhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSachNhaPhanPhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaPhanPhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhaPhanPhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSachNhaPhanPhoi
            // 
            this.dtgSachNhaPhanPhoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SachId,
            this.TenSach,
            this.TenTacGia,
            this.NgayXb,
            this.SoLuong});
            this.dtgSachNhaPhanPhoi.GridControl = this.gridNhaPhanPhoi;
            this.dtgSachNhaPhanPhoi.Name = "dtgSachNhaPhanPhoi";
            this.dtgSachNhaPhanPhoi.OptionsView.ShowGroupPanel = false;
            this.dtgSachNhaPhanPhoi.ViewCaption = "Sách Thuộc Nhà Phân Phối ";
            // 
            // SachId
            // 
            this.SachId.Caption = "ID Sách";
            this.SachId.FieldName = "SachId";
            this.SachId.MinWidth = 25;
            this.SachId.Name = "SachId";
            this.SachId.Visible = true;
            this.SachId.VisibleIndex = 0;
            this.SachId.Width = 94;
            // 
            // TenSach
            // 
            this.TenSach.Caption = "Tên Sách";
            this.TenSach.FieldName = "TenSach";
            this.TenSach.MinWidth = 25;
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 1;
            this.TenSach.Width = 94;
            // 
            // TenTacGia
            // 
            this.TenTacGia.Caption = "Tên Tác Giả";
            this.TenTacGia.FieldName = "TenTacGia";
            this.TenTacGia.MinWidth = 25;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.Visible = true;
            this.TenTacGia.VisibleIndex = 2;
            this.TenTacGia.Width = 94;
            // 
            // NgayXb
            // 
            this.NgayXb.Caption = "Ngày Xuất Bản";
            this.NgayXb.FieldName = "NgayXb";
            this.NgayXb.MinWidth = 25;
            this.NgayXb.Name = "NgayXb";
            this.NgayXb.Visible = true;
            this.NgayXb.VisibleIndex = 3;
            this.NgayXb.Width = 94;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 25;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 94;
            // 
            // gridNhaPhanPhoi
            // 
            gridLevelNode1.LevelTemplate = this.dtgSachNhaPhanPhoi;
            gridLevelNode1.RelationName = "SachCuaNhaPhanPhoi";
            this.gridNhaPhanPhoi.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridNhaPhanPhoi.Location = new System.Drawing.Point(12, 12);
            this.gridNhaPhanPhoi.MainView = this.dtgNhaPhanPhoi;
            this.gridNhaPhanPhoi.MenuManager = this.barManager1;
            this.gridNhaPhanPhoi.Name = "gridNhaPhanPhoi";
            this.gridNhaPhanPhoi.Size = new System.Drawing.Size(788, 526);
            this.gridNhaPhanPhoi.TabIndex = 4;
            this.gridNhaPhanPhoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgNhaPhanPhoi,
            this.dtgSachNhaPhanPhoi});
            // 
            // dtgNhaPhanPhoi
            // 
            this.dtgNhaPhanPhoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenNhaPhanPhoi,
            this.SoDienThoai,
            this.DiaChi});
            this.dtgNhaPhanPhoi.GridControl = this.gridNhaPhanPhoi;
            this.dtgNhaPhanPhoi.Name = "dtgNhaPhanPhoi";
            this.dtgNhaPhanPhoi.OptionsView.ShowGroupPanel = false;
            this.dtgNhaPhanPhoi.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.dtgNhaPhanPhoi_MasterRowEmpty);
            this.dtgNhaPhanPhoi.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.dtgNhaPhanPhoi_MasterRowGetChildList);
            this.dtgNhaPhanPhoi.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.dtgNhaPhanPhoi_MasterRowGetRelationName);
            this.dtgNhaPhanPhoi.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.dtgNhaPhanPhoi_MasterRowGetRelationCount);
            // 
            // ID
            // 
            this.ID.Caption = "Mã Nhà Phân Phối";
            this.ID.FieldName = "NhaPhanPhoiId";
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 94;
            // 
            // TenNhaPhanPhoi
            // 
            this.TenNhaPhanPhoi.Caption = "Tên Nhà Phân Phối";
            this.TenNhaPhanPhoi.FieldName = "TenNhaPhanPhoi";
            this.TenNhaPhanPhoi.MinWidth = 25;
            this.TenNhaPhanPhoi.Name = "TenNhaPhanPhoi";
            this.TenNhaPhanPhoi.Visible = true;
            this.TenNhaPhanPhoi.VisibleIndex = 1;
            this.TenNhaPhanPhoi.Width = 94;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Số Điện Thoại / Gmail";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.MinWidth = 25;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 2;
            this.SoDienThoai.Width = 94;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            this.DiaChi.Width = 94;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnUpdate,
            this.btnXoa});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm Nhà Phân Phối";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Cập Nhật Thông Tin Nhà Phân Phối";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa Thông Tin Nhà Phân Phối";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(812, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 580);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(812, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(812, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridNhaPhanPhoi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(812, 550);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(812, 550);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridNhaPhanPhoi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(792, 530);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // NhaPhanPhoi_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "NhaPhanPhoi_DanhSach";
            this.Size = new System.Drawing.Size(812, 580);
            this.Load += new System.EventHandler(this.NhaPhanPhoi_DanhSach2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSachNhaPhanPhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaPhanPhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhaPhanPhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridNhaPhanPhoi;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgNhaPhanPhoi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaPhanPhoi;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgSachNhaPhanPhoi;
        private DevExpress.XtraGrid.Columns.GridColumn SachId;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn NgayXb;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
    }
}
