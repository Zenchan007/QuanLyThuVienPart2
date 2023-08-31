using DAL.Services.TacGias.DTO;
using DAL.Services.TacGias;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Services.PhieuMuons;
using System.Data.Entity;
using DAL.Services.PhieuMuons.DTO;
using GUI.Form_Sach;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DAL.Services.PhieuMuon_Sachs;
using DAL.Services.PhieuMuon_PhieuMuon_Sachs;
using DAL.Services.PhieuMuon_Sach_Sachs;

namespace GUI.Form_PhieuMuon
{
    public partial class PhieuMuon_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {

        IPhieuMuonService phieuMuonService = new PhieuMuonService();
        IPhieuMuon_SachsService muon_SachsService = new PhieuMuon_SachsService();
        List<PhieuMuon_Sach_DTO> listSachMuon;
        public PhieuMuon_DanhSach2()
        {
            InitializeComponent();
        }

        private void PhieuMuon_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuPhieuMuon();
        }

        private async void showDuLieuPhieuMuon()
        {
            var danhSach = await phieuMuonService.QueryFilterDto().ToListAsync();
            listSachMuon = await muon_SachsService.QueryFilterDto().ToListAsync();
            BindingList<PhieuMuon_DTO> listTacGia = new BindingList<PhieuMuon_DTO>(danhSach);
            gridPhieuMuon.DataSource = listTacGia;
            dtgPhieuMuon.OptionsBehavior.Editable = false;
            dtgPhieuMuon.OptionsView.ColumnAutoWidth = true;
            dtgPhieuMuon.BestFitColumns();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var phieuMuonMoi = new PhieuMuonCreateOrUpdate2();
            phieuMuonMoi.FormClosed += childFormClose;
            phieuMuonMoi.Show(this);
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            PhieuMuon_DanhSach2_Load(null, null);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgPhieuMuon.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgPhieuMuon.FocusedRowHandle;
                var ID_PhieuMuonCapNhat = dtgPhieuMuon.GetRowCellDisplayText(selectedRowHandle, "PhieuMuonId");
                var phieuMuonCapNhat = new PhieuMuonCreateOrUpdate2(Int32.Parse(ID_PhieuMuonCapNhat));
                phieuMuonCapNhat.FormClosed += childFormClose;
                phieuMuonCapNhat.Show(this);
            }
            else
            {
                showDuLieuPhieuMuon();
            }
        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgPhieuMuon.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgPhieuMuon.FocusedRowHandle;
                var ID_Xoa = dtgPhieuMuon.GetRowCellDisplayText(selectedRowHandle, "PhieuMuonId");
                
                await phieuMuonService.DeletePhieuMuonById(Int32.Parse(ID_Xoa));
                MessageBox.Show("Đã Xóa");
                showDuLieuPhieuMuon();
            }
        }

        private void dtgPhieuMuon_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.VisibleIndex == 0 && view.IsMasterRowEmpty(e.RowHandle))
                (e.Cell as GridCellInfo).CellButtonRect = Rectangle.Empty;
        }

        #region Event
        #endregion

        #region CusTomeDetailView
        private void dtgPhieuMuon_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            PhieuMuon_DTO sachMuon = view.GetRow(e.RowHandle) as PhieuMuon_DTO;
            if(sachMuon != null)
                e.IsEmpty = !listSachMuon.Any(x => x.PhieuMuonId == sachMuon.PhieuMuonId);
        }

        private void dtgPhieuMuon_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            PhieuMuon_DTO sachMuon = view.GetRow(e.RowHandle) as PhieuMuon_DTO;
            if (sachMuon != null)
                e.ChildList = listSachMuon.Where(x=> x.PhieuMuonId == sachMuon.PhieuMuonId).ToList();
        }

        private void dtgPhieuMuon_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void dtgPhieuMuon_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
        #endregion
        private void dtgPhieuMuon_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            
        }
    }
}
