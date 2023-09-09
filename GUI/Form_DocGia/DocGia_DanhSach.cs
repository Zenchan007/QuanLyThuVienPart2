using DAL.Services.DocGias;
using DAL.Services.DocGias.DTO;
using DAL.Services.NhanVien;
using DAL.Services.PhieuMuons;
using DAL.Services.PhieuMuons.DTO;
using DAL.Services.Sachs.DTO;
using DAL.Services.TheLoais.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace GUI.Form_DocGia
{
    public partial class DocGia_DanhSach : UserControl
    {
        IDocGiaService docGiaService = new DocGiaService();
        IPhieuMuonService phieuMuonService = new PhieuMuonService();
        public DocGia_DanhSach()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var docGiaMoi = new DocGiaCreateOrUpdate();
            docGiaMoi.FormClosed += childFormClose;
            docGiaMoi.Show(this);
            this.Enabled = false;
            
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            DocGia_DanhSach2_Load(null, null);
        }

        private void DocGia_DanhSach2_Load(object sender, EventArgs e)
        {
            this.Enabled =true;
            showDuLieuDocGia().ContinueWith(x =>
           {
               if (x.IsFaulted)
               {
                   MessageBox.Show("Lỗi show Dữ liệu");
               }
           });
        }

        private async Task showDuLieuDocGia()
        {
            var danhSach = await docGiaService.QueryFilterDto().ToListAsync();
            BindingList<DocGia_DTO> listDocGia = new BindingList<DocGia_DTO>(danhSach);
            gridDocGia.DataSource = listDocGia;
            dtgDocGia.OptionsBehavior.Editable = false;
            dtgDocGia.OptionsView.ColumnAutoWidth = true;
            dtgDocGia.BestFitColumns();
        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dtgDocGia.FocusedRowHandle >= 0)
                {
                    int selectedRowHandle = dtgDocGia.FocusedRowHandle;
                    string ID_Xoa = dtgDocGia.GetRowCellDisplayText(selectedRowHandle, "DocGiaId");
                    int ID = Int32.Parse(ID_Xoa);
                    if (XtraMessageBox.Show("Bạn có muốn xóa độc giả này?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        await docGiaService.DeleteDocGiaById(ID);
                        MessageBox.Show("Đã Xóa");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await showDuLieuDocGia();
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgDocGia.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgDocGia.FocusedRowHandle;
                string ID_DocGiaCapNhat = dtgDocGia.GetRowCellDisplayText(selectedRowHandle, "DocGiaId");
                var docGiaCapNhat = new DocGiaCreateOrUpdate(Int32.Parse(ID_DocGiaCapNhat));
                docGiaCapNhat.FormClosed += childFormClose;
                this.Enabled = false;
                docGiaCapNhat.Show(this);
                
            }
            else
            {
                showDuLieuDocGia().ContinueWith(x =>
                {
                    if (x.IsFaulted)
                    {
                        MessageBox.Show("Lỗi Show Nhân Viên");
                    }
                });
            }
        }

        private  void dtgDocGia_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            var listPhieuMuonDocGia =  phieuMuonService.QueryFilterDto().ToList();
            GridView view = sender as GridView;
            DocGia_DTO phieuMuonDocGia = view.GetRow(e.RowHandle) as DocGia_DTO    ;
            if (phieuMuonDocGia != null)
                e.IsEmpty = !listPhieuMuonDocGia.Any(x => x.DocGiaId == phieuMuonDocGia.DocGiaId);
        }
        private  void dtgDocGia_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {

            var listPhieuMuonDocGia =  phieuMuonService.QueryFilterDto().ToList();
            GridView view = sender as GridView;
            DocGia_DTO phieuMuonDocGia = view.GetRow(e.RowHandle) as DocGia_DTO;
            if (phieuMuonDocGia != null)
                e.ChildList = listPhieuMuonDocGia.Where(x => x.DocGiaId == phieuMuonDocGia.DocGiaId).ToList();
        }

        private void dtgDocGia_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

       

        private void dtgDocGia_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "PhieuMuonCuaDocGia";
        }
    }
}
