using DAL.Services.PhieuMuons.DTO;
using DAL.Services.Sachs.DTO;
using DAL.Services.TacGias;
using DAL.Services.TheLoais;
using DAL.Services.TheLoais.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using GUI.Form_NhaPhanPhoi;
using GUI.Form_Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GUI.Form_TheLoai
{
    public partial class TheLoai_DanhSach : DevExpress.XtraEditors.XtraUserControl
    {
        ITheLoaiService theLoaiService = new TheLoaiService();
        ISachService sachService = new SachService();
        List<Sach_DTO> ListSach;
        public TheLoai_DanhSach()
        {
            InitializeComponent();
        }

        private void TheLoai_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuTheLoai().ContinueWith(x =>
            {
                if (x.IsFaulted || x.IsCanceled)
                {
                    MessageBox.Show("Lỗi how Dữ liệu Thể Loại");
                }
            });
        }

        private async Task showDuLieuTheLoai()
        {
            var danhSach = await theLoaiService.GetListTheLoaiDto();
            ListSach = await sachService.GetListSachDto();
            BindingList<TheLoai_DTO> listTheLoai = new BindingList<TheLoai_DTO>(danhSach);
            gridTheLoai.DataSource = listTheLoai;
            dtgTheLoai.OptionsBehavior.Editable = false;
            dtgTheLoai.OptionsView.ColumnAutoWidth = true;
            dtgTheLoai.BestFitColumns();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var theLoaiMoi = new TheLoai_CreateOrUpdate();
            theLoaiMoi.FormClosed += childFormClose;
            theLoaiMoi.Show(this);
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            TheLoai_DanhSach2_Load(null, null);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgTheLoai.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgTheLoai.FocusedRowHandle;
                string ID_NhaPhanPhoiCapNhat = dtgTheLoai.GetRowCellDisplayText(selectedRowHandle, "TheLoaiId");
                var theLoaiCapNhat = new TheLoai_CreateOrUpdate(ID_NhaPhanPhoiCapNhat);
                theLoaiCapNhat.FormClosed += childFormClose;
                theLoaiCapNhat.Show(this);
            }
            else
            {
                showDuLieuTheLoai().ContinueWith(x =>
                {
                    if (x.IsFaulted)
                    {
                        MessageBox.Show("Lỗi Show Nhà Phân Phối");
                    }
                });
            }
        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgTheLoai.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgTheLoai.FocusedRowHandle;
                string idXoa = dtgTheLoai.GetRowCellDisplayText(selectedRowHandle, "TheLoaiId");
                if (XtraMessageBox.Show("Bạn có muốn xóa thể loại này", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    await theLoaiService.DeleteTheLoaiById(idXoa);
                    MessageBox.Show("Đã Xóa");
                    await showDuLieuTheLoai();
                }
            }
        }

        #region DetailView
        private void dtgTheLoai_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            TheLoai_DTO theLoai = view.GetRow(e.RowHandle) as TheLoai_DTO;
            if (theLoai != null)
                e.IsEmpty = !ListSach.Any(x => x.TheLoais.Contains(theLoai.TheLoaiId));
        }

        private void dtgTheLoai_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            TheLoai_DTO theLoai = view.GetRow(e.RowHandle) as TheLoai_DTO;
            if (theLoai != null)
                e.ChildList = ListSach.Where(x => x.TheLoais.Contains(theLoai.TheLoaiId)).ToList();
        }

        private void dtgTheLoai_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void dtgTheLoai_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "SachTheLoai";
        }

        private void dtgTheLoai_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {

        }
        #endregion
    }
}