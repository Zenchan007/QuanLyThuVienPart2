using DAL.Services.NhaPhanPhois.DTO;
using DAL.Services.NhaPhanPhois;
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
using DAL.Services.TacGias;
using System.Data.Entity;
using DAL.Services.TacGias.DTO;
using GUI.Form_NhaPhanPhoi;
using DAL.Services.Sachs.DTO;
using DAL.Services.DocGias.DTO;
using DAL.Services.PhieuMuons;
using DevExpress.XtraGrid.Views.Grid;

namespace GUI.Form_TacGia
{
    public partial class TacGia_DanhSach : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai Báo
        ITacGiaService tacGiaService = new TacGiaService();
        ISachService sachService = new SachService();
        public TacGia_DanhSach()
        {
            InitializeComponent();
        }
        #endregion

        private void TacGia_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuTacGia().ContinueWith(x =>
            {
                if (x.IsFaulted || x.IsCanceled)
                {
                    MessageBox.Show("Lỗi show dữ liệu tác giả");
                }
            });
        }

        #region Event
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tacGiaMoi = new TacGiaCreateOrUpdate();
            tacGiaMoi.FormClosed += childFormClose;
            tacGiaMoi.Show(this);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgTacGia.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgTacGia.FocusedRowHandle;
                string ID_TacGiaCapNhat = dtgTacGia.GetRowCellDisplayText(selectedRowHandle, "TacGiaId");
                var tacGiaCapNhat = new TacGiaCreateOrUpdate(Int32.Parse(ID_TacGiaCapNhat));
                tacGiaCapNhat.FormClosed += childFormClose;
                tacGiaCapNhat.Show(this);
            }
            else
            {
                showDuLieuTacGia().ContinueWith(x =>
                {
                    if (x.IsFaulted)
                    {
                        MessageBox.Show("Lỗi Show dữ liệu tác giả");
                    }
                });
            }
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            TacGia_DanhSach2_Load(null, null);
        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgTacGia.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgTacGia.FocusedRowHandle;
                string ID_Xoa = dtgTacGia.GetRowCellDisplayText(selectedRowHandle, "TacGiaId");
                var ID = Int32.Parse(ID_Xoa);
                await tacGiaService.DeleteTacGiaById(ID);
                MessageBox.Show("Đã Xóa");
                await showDuLieuTacGia();
            }
        }
        private async Task showDuLieuTacGia()
        {
            var danhSach = await tacGiaService.QueryFilterDto().ToListAsync();
            BindingList<TacGia_DTO> listTacGia = new BindingList<TacGia_DTO>(danhSach);
            gridTacGia.DataSource = listTacGia;
            dtgTacGia.OptionsBehavior.Editable = false;
            dtgTacGia.OptionsView.ColumnAutoWidth = true;
            dtgTacGia.BestFitColumns();
        }
        #endregion
        #region CusTom DetailView
        private void dtgTacGia_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            var listPhieuMuonDocGia =  sachService.QueryFilterDto().ToList();
            GridView view = sender as GridView;
            TacGia_DTO tacGiaSach = view.GetRow(e.RowHandle) as TacGia_DTO;
            if (tacGiaSach != null)
                e.IsEmpty = !listPhieuMuonDocGia.Any(x => x.TacGiaId == tacGiaSach.TacGiaId);
        }

        private  void dtgTacGia_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            var listPhieuMuonDocGia =  sachService.QueryFilterDto().ToList();
            GridView view = sender as GridView;
            TacGia_DTO tacGiaSach = view.GetRow(e.RowHandle) as TacGia_DTO;
            if (tacGiaSach != null)
                e.ChildList = listPhieuMuonDocGia.Where(x => x.TacGiaId == tacGiaSach.TacGiaId).ToList();
        }

        private void dtgTacGia_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 0;
        }

        private void dtgTacGia_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "SachCuaTacGia";
        }
        #endregion
    }
}