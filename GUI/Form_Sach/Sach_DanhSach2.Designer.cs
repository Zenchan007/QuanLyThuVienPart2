namespace GUI.Form_Sach
{
	partial class Sach_DanhSach2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach_DanhSach2));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridSach = new DevExpress.XtraGrid.GridControl();
            this.dtgSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayXb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barBtn = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiMuon = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridSach);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1350, 689);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridSach
            // 
            this.gridSach.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridSach.Location = new System.Drawing.Point(12, 12);
            this.gridSach.MainView = this.dtgSach;
            this.gridSach.Name = "gridSach";
            this.gridSach.Size = new System.Drawing.Size(1326, 665);
            this.gridSach.TabIndex = 4;
            this.gridSach.Tag = "Sách";
            this.gridSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgSach});
            // 
            // dtgSach
            // 
            this.dtgSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenSach,
            this.TenTacGia,
            this.NgayXb,
            this.DonGia,
            this.SoLuong});
            this.dtgSach.GridControl = this.gridSach;
            this.dtgSach.Name = "dtgSach";
            // 
            // ID
            // 
            this.ID.Caption = "ID Sách";
            this.ID.FieldName = "SachId";
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.Width = 94;
            // 
            // TenSach
            // 
            this.TenSach.Caption = "Tên Sách";
            this.TenSach.FieldName = "TenSach";
            this.TenSach.MinWidth = 25;
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 0;
            this.TenSach.Width = 94;
            // 
            // TenTacGia
            // 
            this.TenTacGia.Caption = "Tên Tác Giả";
            this.TenTacGia.FieldName = "TenTacGia";
            this.TenTacGia.MinWidth = 25;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.Visible = true;
            this.TenTacGia.VisibleIndex = 1;
            this.TenTacGia.Width = 94;
            // 
            // NgayXb
            // 
            this.NgayXb.Caption = "Ngày Xuất Bản";
            this.NgayXb.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayXb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayXb.FieldName = "NgayXb";
            this.NgayXb.MinWidth = 25;
            this.NgayXb.Name = "NgayXb";
            this.NgayXb.UnboundDataType = typeof(System.DateTime);
            this.NgayXb.Visible = true;
            this.NgayXb.VisibleIndex = 2;
            this.NgayXb.Width = 94;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.MinWidth = 25;
            this.DonGia.Name = "DonGia";
            this.DonGia.UnboundDataType = typeof(double);
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            this.DonGia.Width = 94;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 25;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1350, 689);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridSach;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1330, 669);
            this.layoutControlItem1.Text = "Danh Sách Sách";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barBtn});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnUpdate,
            this.btnXoa,
            this.btnGhiMuon});
            this.barManager1.MaxItemId = 4;
            // 
            // barBtn
            // 
            this.barBtn.BarName = "Tools";
            this.barBtn.DockCol = 0;
            this.barBtn.DockRow = 1;
            this.barBtn.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barBtn.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiMuon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barBtn.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm Sách";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Cập Nhật";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhiMuon
            // 
            this.btnGhiMuon.Caption = "Ghi Mượn";
            this.btnGhiMuon.Id = 3;
            this.btnGhiMuon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiMuon.ImageOptions.Image")));
            this.btnGhiMuon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiMuon.ImageOptions.LargeImage")));
            this.btnGhiMuon.Name = "btnGhiMuon";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1350, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 719);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1350, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 689);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1350, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 689);
            // 
            // Sach_DanhSach2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Sach_DanhSach2";
            this.Size = new System.Drawing.Size(1350, 719);
            this.Load += new System.EventHandler(this.Sach_DanhSach2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridSach;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgSach;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barBtn;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhiMuon;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn NgayXb;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
