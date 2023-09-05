using DAL.Services.NhanVien.DTO;
using DAL.Services.NhanVien;
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
using System.Data.Entity;
using DAL.Services.NhaPhanPhois.DTO;
using GUI.Form_NhanVien;
using DAL.Services.Sachs.DTO;
using DAL.Services.DocGias.DTO;
using DAL.Services.PhieuMuons;
using DevExpress.XtraGrid.Views.Grid;

namespace GUI.Form_NhaPhanPhoi
{
    public partial class NhaPhanPhoi_DanhSach : DevExpress.XtraEditors.XtraUserControl
    {
        #region khai báo
        INhaPhanPhoiService nhaPhanPhoiService = new NhaPhanPhoiService();
        ISachService sachService = new SachService();
        public NhaPhanPhoi_DanhSach()
        {
            InitializeComponent();
        }
        #endregion


        private void NhaPhanPhoi_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuNhaPhanPhoi().ContinueWith(x =>
            {
                if(x.IsFaulted || x.IsCanceled)
                {
                    MessageBox.Show("Lỗi show dữ liệu nhà phân phối");
                }
            });
        }

        private async Task showDuLieuNhaPhanPhoi()
        {
            var danhSach = await nhaPhanPhoiService.QueryFilterDto().ToListAsync();
            BindingList<NhaPhanPhoi_DTO> listNhaPhanPhoi = new BindingList<NhaPhanPhoi_DTO>(danhSach);
            gridNhaPhanPhoi.DataSource = listNhaPhanPhoi;
            dtgNhaPhanPhoi.OptionsBehavior.Editable = false;
            dtgNhaPhanPhoi.OptionsView.ColumnAutoWidth = true;
            dtgNhaPhanPhoi.BestFitColumns();
        }

        #region Event 
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nhanVienMoi = new NhaPhanPhoiCreateOrUpdate();
            nhanVienMoi.FormClosed += childFormClose;
            nhanVienMoi.Show(this);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgNhaPhanPhoi.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgNhaPhanPhoi.FocusedRowHandle;
                string ID_NhaPhanPhoiCapNhat = dtgNhaPhanPhoi.GetRowCellDisplayText(selectedRowHandle, "NhaPhanPhoiId");
                var nhanVienCapNhat = new NhaPhanPhoiCreateOrUpdate(ID_NhaPhanPhoiCapNhat);
                nhanVienCapNhat.FormClosed += childFormClose;
                nhanVienCapNhat.Show(this);
            }
            else
            {
                showDuLieuNhaPhanPhoi().ContinueWith(x =>
                {
                    if (x.IsFaulted)
                    {
                        MessageBox.Show("Lỗi Show Nhà Phân Phối");
                    }
                });
            }
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            NhaPhanPhoi_DanhSach2_Load(null, null);
        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgNhaPhanPhoi.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgNhaPhanPhoi.FocusedRowHandle;
                string ID_Xoa = dtgNhaPhanPhoi.GetRowCellDisplayText(selectedRowHandle, "NhaPhanPhoiId");
                if (XtraMessageBox.Show("Bạn có muốn xóa nhà phân phối này?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    await nhaPhanPhoiService.DeleteNhaPhanPhoiById(ID_Xoa);
                    MessageBox.Show("Đã Xóa");
                    await showDuLieuNhaPhanPhoi();
                }
            }
        }
        #endregion
        #region CusTom DetailView
        private void dtgNhaPhanPhoi_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            var listSachNhaPhanPhoi =  sachService.QueryFilterDto().ToList();
            GridView view = sender as GridView;
            NhaPhanPhoi_DTO sachNhaPhanPhoi = view.GetRow(e.RowHandle) as NhaPhanPhoi_DTO;
            if (sachNhaPhanPhoi != null)
                e.IsEmpty = !listSachNhaPhanPhoi.Any(x => x.NhaPhanPhoiId == sachNhaPhanPhoi.NhaPhanPhoiId);
        }

        private  void dtgNhaPhanPhoi_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            var listPhieuMuonDocGia =  sachService.QueryFilterDto().ToList();
            GridView view = sender as GridView;
            NhaPhanPhoi_DTO sachNhaPhanPhoi = view.GetRow(e.RowHandle) as NhaPhanPhoi_DTO;
            if (sachNhaPhanPhoi != null)
                e.ChildList = listPhieuMuonDocGia.Where(x => x.NhaPhanPhoiId == sachNhaPhanPhoi.NhaPhanPhoiId).ToList();
        }

        private void dtgNhaPhanPhoi_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void dtgNhaPhanPhoi_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "SachCuaNhaPhanPhoi";
        }
        #endregion
    }
}
