using DAL.Services.PhieuMuons.DTO;
using DAL.Services.Sachs.DTO;
using DAL.Services.TheLoais;
using DAL.Services.TheLoais.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GUI.Form_TheLoai
{
    public partial class TheLoai_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {
        ITheLoaiService theLoaiService = new TheLoaiService();
        ISachService sachService = new SachService();
        List<Sach_DTO> ListSach;
        public TheLoai_DanhSach2()
        {
            InitializeComponent();
        }

        private void TheLoai_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuTheLoai();
        }

        private void showDuLieuTheLoai()
        {
            var danhSach = theLoaiService.QueryFilterDto().ToList();
             ListSach = sachService.QueryFilterDto().ToList();
            BindingList<TheLoai_DTO> listTheLoai = new BindingList<TheLoai_DTO>(danhSach);
            gridTheLoai.DataSource = listTheLoai;
            dtgTheLoai.OptionsBehavior.Editable = false;
            dtgTheLoai.OptionsView.ColumnAutoWidth = true;
            dtgTheLoai.BestFitColumns();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgTheLoai.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgTheLoai.FocusedRowHandle;
                string idXoa = dtgTheLoai.GetRowCellDisplayText(selectedRowHandle, "TheLoaiId");
                await theLoaiService.DeleteTheLoaiById(idXoa);
                MessageBox.Show("Đã Xóa");
                showDuLieuTheLoai();
            }
        }

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
    }
}
