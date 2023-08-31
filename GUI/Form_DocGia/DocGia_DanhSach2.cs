using DAL.Services.DocGias;
using DAL.Services.DocGias.DTO;
using DAL.Services.NhanVien;
using DAL.Services.TheLoais.DTO;
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
    public partial class DocGia_DanhSach2 : UserControl
    {
        IDocGiaService docGiaService = new DocGiaService();
        public DocGia_DanhSach2()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var docGiaMoi = new DocGiaCreateOrUpdate();
            docGiaMoi.FormClosed += childFormClose;
            docGiaMoi.Show(this);
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            DocGia_DanhSach2_Load(null, null);
        }

        private void DocGia_DanhSach2_Load(object sender, EventArgs e)
        {
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
                    await docGiaService.DeleteDocGiaById(ID);
                    MessageBox.Show("Đã Xóa");
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
                var nhanVienCapNhat = new DocGiaCreateOrUpdate(Int32.Parse(ID_DocGiaCapNhat));
                nhanVienCapNhat.FormClosed += childFormClose;
                nhanVienCapNhat.Show(this);
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
    }
}
