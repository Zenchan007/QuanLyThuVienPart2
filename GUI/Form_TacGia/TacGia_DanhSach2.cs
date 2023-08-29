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

namespace GUI.Form_TacGia
{
    public partial class TacGia_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {
        ITacGiaService tacGiaService = new TacGiaService();
        public TacGia_DanhSach2()
        {
            InitializeComponent();
        }

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
    }
}
