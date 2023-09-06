namespace GUI.Form_SachYeuCau
{
    partial class SachYeuCauDanhSach
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTenSachYC = new DevExpress.XtraEditors.TextEdit();
            this.txtTacGiaYC = new DevExpress.XtraEditors.TextEdit();
            this.gridSachYeuCau = new DevExpress.XtraGrid.GridControl();
            this.dtgSachYeuCau = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_SachYeuCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSachYC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTacGiaYC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemSachYC = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaSachYC = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapSach = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSachYC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTacGiaYC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSachYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSachYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTenSachYC);
            this.layoutControl1.Controls.Add(this.txtTacGiaYC);
            this.layoutControl1.Controls.Add(this.gridSachYeuCau);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 329, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(890, 635);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTenSachYC
            // 
            this.txtTenSachYC.Location = new System.Drawing.Point(129, 12);
            this.txtTenSachYC.Name = "txtTenSachYC";
            this.txtTenSachYC.Size = new System.Drawing.Size(224, 22);
            this.txtTenSachYC.StyleController = this.layoutControl1;
            this.txtTenSachYC.TabIndex = 6;
            // 
            // txtTacGiaYC
            // 
            this.txtTacGiaYC.Location = new System.Drawing.Point(474, 12);
            this.txtTacGiaYC.Name = "txtTacGiaYC";
            this.txtTacGiaYC.Size = new System.Drawing.Size(404, 22);
            this.txtTacGiaYC.StyleController = this.layoutControl1;
            this.txtTacGiaYC.TabIndex = 5;
            // 
            // gridSachYeuCau
            // 
            this.gridSachYeuCau.Location = new System.Drawing.Point(12, 38);
            this.gridSachYeuCau.MainView = this.dtgSachYeuCau;
            this.gridSachYeuCau.Name = "gridSachYeuCau";
            this.gridSachYeuCau.Size = new System.Drawing.Size(866, 585);
            this.gridSachYeuCau.TabIndex = 4;
            this.gridSachYeuCau.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgSachYeuCau});
            // 
            // dtgSachYeuCau
            // 
            this.dtgSachYeuCau.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_SachYeuCau,
            this.TenSachYC,
            this.TenTacGiaYC});
            this.dtgSachYeuCau.GridControl = this.gridSachYeuCau;
            this.dtgSachYeuCau.Name = "dtgSachYeuCau";
            // 
            // ID_SachYeuCau
            // 
            this.ID_SachYeuCau.Caption = "ID Sách Yêu Cầu";
            this.ID_SachYeuCau.FieldName = "SachYeuCauId";
            this.ID_SachYeuCau.MinWidth = 25;
            this.ID_SachYeuCau.Name = "ID_SachYeuCau";
            this.ID_SachYeuCau.Visible = true;
            this.ID_SachYeuCau.VisibleIndex = 0;
            this.ID_SachYeuCau.Width = 94;
            // 
            // TenSachYC
            // 
            this.TenSachYC.Caption = "Tên Sách Yêu Cầu";
            this.TenSachYC.FieldName = "TenSachYC";
            this.TenSachYC.MinWidth = 25;
            this.TenSachYC.Name = "TenSachYC";
            this.TenSachYC.Visible = true;
            this.TenSachYC.VisibleIndex = 1;
            this.TenSachYC.Width = 94;
            // 
            // TenTacGiaYC
            // 
            this.TenTacGiaYC.Caption = "Tên Tác Giả Yêu Cầu";
            this.TenTacGiaYC.FieldName = "TacGiaYC";
            this.TenTacGiaYC.MinWidth = 25;
            this.TenTacGiaYC.Name = "TenTacGiaYC";
            this.TenTacGiaYC.Visible = true;
            this.TenTacGiaYC.VisibleIndex = 2;
            this.TenTacGiaYC.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(890, 635);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridSachYeuCau;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(870, 589);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem2.Control = this.txtTacGiaYC;
            this.layoutControlItem2.Location = new System.Drawing.Point(345, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(525, 26);
            this.layoutControlItem2.Text = "Tác Giả Yêu Cầu";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem3.Control = this.txtTenSachYC;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(345, 26);
            this.layoutControlItem3.Text = "Tên Sách Yêu Cầu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(105, 16);
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
            this.btnThemSachYC,
            this.btnXoaSachYC,
            this.btnNhapSach});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemSachYC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaSachYC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNhapSach, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemSachYC
            // 
            this.btnThemSachYC.Caption = "Thêm Sách Yêu Cầu";
            this.btnThemSachYC.Id = 0;
            this.btnThemSachYC.ImageOptions.Image = global::GUI.Properties.Resources.add_16x16;
            this.btnThemSachYC.ImageOptions.LargeImage = global::GUI.Properties.Resources.add_32x321;
            this.btnThemSachYC.Name = "btnThemSachYC";
            this.btnThemSachYC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemSachYC_ItemClick);
            // 
            // btnXoaSachYC
            // 
            this.btnXoaSachYC.Caption = "Xóa Sách Yêu Cầu";
            this.btnXoaSachYC.Id = 1;
            this.btnXoaSachYC.ImageOptions.Image = global::GUI.Properties.Resources.cancel_16x16;
            this.btnXoaSachYC.ImageOptions.LargeImage = global::GUI.Properties.Resources.cancel_32x323;
            this.btnXoaSachYC.Name = "btnXoaSachYC";
            this.btnXoaSachYC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaSachYC_ItemClick);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Caption = "Thêm Sách Yêu Cầu Vào Kho Sách";
            this.btnNhapSach.Id = 2;
            this.btnNhapSach.ImageOptions.Image = global::GUI.Properties.Resources.converttorange_16x16;
            this.btnNhapSach.ImageOptions.LargeImage = global::GUI.Properties.Resources.converttorange_32x32;
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapSach_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(890, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 665);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(890, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 635);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(890, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 635);
            // 
            // SachYeuCauDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SachYeuCauDanhSach";
            this.Size = new System.Drawing.Size(890, 665);
            this.Load += new System.EventHandler(this.SachYeuCauDanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSachYC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTacGiaYC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSachYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSachYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridSachYeuCau;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgSachYeuCau;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_SachYeuCau;
        private DevExpress.XtraGrid.Columns.GridColumn TenSachYC;
        private DevExpress.XtraGrid.Columns.GridColumn TenTacGiaYC;
        private DevExpress.XtraEditors.TextEdit txtTenSachYC;
        private DevExpress.XtraEditors.TextEdit txtTacGiaYC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemSachYC;
        private DevExpress.XtraBars.BarButtonItem btnXoaSachYC;
        private DevExpress.XtraBars.BarButtonItem btnNhapSach;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
