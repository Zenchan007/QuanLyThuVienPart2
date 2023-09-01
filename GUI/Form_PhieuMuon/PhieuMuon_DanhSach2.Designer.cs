namespace GUI.Form_PhieuMuon
{
    partial class PhieuMuon_DanhSach2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMuon_DanhSach2));
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhieuMuon = new DevExpress.XtraGrid.GridControl();
            this.dtgPhieuMuon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDocGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHenTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuPhat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetail
            // 
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvDetail.GridControl = this.gridPhieuMuon;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsView.ShowGroupPanel = false;
            this.gvDetail.ViewCaption = "Sách Mượn";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Phiếu Mượn";
            this.gridColumn1.FieldName = "PhieuMuonId";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Sách Mượn";
            this.gridColumn2.FieldName = "TenSachMuon";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tác Giả Sách Mượn";
            this.gridColumn3.FieldName = "TacGiaSachMuon";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Lượng Mượn";
            this.gridColumn4.FieldName = "SoLuongSachMuon";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridPhieuMuon
            // 
            gridLevelNode1.LevelTemplate = this.gvDetail;
            gridLevelNode1.RelationName = "Sách Mượn";
            this.gridPhieuMuon.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridPhieuMuon.Location = new System.Drawing.Point(12, 12);
            this.gridPhieuMuon.MainView = this.dtgPhieuMuon;
            this.gridPhieuMuon.MenuManager = this.barManager1;
            this.gridPhieuMuon.Name = "gridPhieuMuon";
            this.gridPhieuMuon.Size = new System.Drawing.Size(829, 535);
            this.gridPhieuMuon.TabIndex = 4;
            this.gridPhieuMuon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgPhieuMuon,
            this.gvDetail});
            // 
            // dtgPhieuMuon
            // 
            this.dtgPhieuMuon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenDocGia,
            this.TenNhanVien,
            this.NgayMuon,
            this.NgayHenTra,
            this.SoLuongMuon,
            this.TrangThai,
            this.IDTrangThai});
            this.dtgPhieuMuon.GridControl = this.gridPhieuMuon;
            this.dtgPhieuMuon.Name = "dtgPhieuMuon";
            this.dtgPhieuMuon.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.dtgPhieuMuon_CustomDrawCell);
            this.dtgPhieuMuon.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.dtgPhieuMuon_MasterRowEmpty);
            this.dtgPhieuMuon.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.dtgPhieuMuon_MasterRowGetChildList);
            this.dtgPhieuMuon.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.dtgPhieuMuon_MasterRowGetRelationName);
            this.dtgPhieuMuon.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.dtgPhieuMuon_MasterRowGetRelationCount);
            // 
            // ID
            // 
            this.ID.Caption = "ID Phiếu Mượn";
            this.ID.FieldName = "PhieuMuonId";
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 94;
            // 
            // TenDocGia
            // 
            this.TenDocGia.Caption = "Tên Độc Giả";
            this.TenDocGia.FieldName = "TenDocGia";
            this.TenDocGia.MinWidth = 25;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.Visible = true;
            this.TenDocGia.VisibleIndex = 2;
            this.TenDocGia.Width = 94;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Caption = "Tên Nhân Viên";
            this.TenNhanVien.FieldName = "TenNhanVien";
            this.TenNhanVien.MinWidth = 25;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Visible = true;
            this.TenNhanVien.VisibleIndex = 1;
            this.TenNhanVien.Width = 94;
            // 
            // NgayMuon
            // 
            this.NgayMuon.Caption = "Ngày Mượn";
            this.NgayMuon.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayMuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayMuon.FieldName = "NgayMuon";
            this.NgayMuon.MinWidth = 25;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.UnboundDataType = typeof(System.DateTime);
            this.NgayMuon.Visible = true;
            this.NgayMuon.VisibleIndex = 3;
            this.NgayMuon.Width = 94;
            // 
            // NgayHenTra
            // 
            this.NgayHenTra.Caption = "Ngày Hẹn Trả";
            this.NgayHenTra.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayHenTra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayHenTra.FieldName = "NgayHenTra";
            this.NgayHenTra.MinWidth = 25;
            this.NgayHenTra.Name = "NgayHenTra";
            this.NgayHenTra.UnboundDataType = typeof(System.DateTime);
            this.NgayHenTra.Visible = true;
            this.NgayHenTra.VisibleIndex = 4;
            this.NgayHenTra.Width = 94;
            // 
            // SoLuongMuon
            // 
            this.SoLuongMuon.Caption = "Số Lượng Sách Mượn";
            this.SoLuongMuon.FieldName = "SoLuongMuon";
            this.SoLuongMuon.MinWidth = 25;
            this.SoLuongMuon.Name = "SoLuongMuon";
            this.SoLuongMuon.Width = 94;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng Thái";
            this.TrangThai.FieldName = "TenTrangThai";
            this.TrangThai.MinWidth = 25;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 5;
            this.TrangThai.Width = 94;
            // 
            // IDTrangThai
            // 
            this.IDTrangThai.Caption = "ID Trạng Thái";
            this.IDTrangThai.FieldName = "TrangThaiId";
            this.IDTrangThai.MinWidth = 25;
            this.IDTrangThai.Name = "IDTrangThai";
            this.IDTrangThai.Width = 94;
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
            this.btnXoa,
            this.btnPhieuPhat});
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhieuPhat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm Phiếu Mượn";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Cập Nhật Phiếu Mượn";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa Phiếu Mượn";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhieuPhat
            // 
            this.btnPhieuPhat.Caption = "Ghi Phiếu Phạt";
            this.btnPhieuPhat.Id = 3;
            this.btnPhieuPhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuPhat.ImageOptions.Image")));
            this.btnPhieuPhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuPhat.ImageOptions.LargeImage")));
            this.btnPhieuPhat.Name = "btnPhieuPhat";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(853, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(853, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 559);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(853, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 559);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridPhieuMuon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(853, 559);
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
            this.Root.Size = new System.Drawing.Size(853, 559);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridPhieuMuon;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(833, 539);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // PhieuMuon_DanhSach2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PhieuMuon_DanhSach2";
            this.Size = new System.Drawing.Size(853, 589);
            this.Load += new System.EventHandler(this.PhieuMuon_DanhSach2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridPhieuMuon;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgPhieuMuon;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenDocGia;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn NgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHenTra;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongMuon;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraBars.BarButtonItem btnPhieuPhat;
        private DevExpress.XtraGrid.Columns.GridColumn IDTrangThai;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
