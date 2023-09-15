using DAL.Services.DocGias;
using DAL.Services.Sachs.DTO;
using DAL.Services.SachYeuCaus;
using DAL.Services.SachYeuCaus.DTO;
using DAL.Services.TacGias;
using DAL.Services.TacGias.DTO;
using DevExpress.XtraEditors;
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

namespace GUI.Form_SachYeuCau
{
    public partial class SachYeuCauDanhSach : DevExpress.XtraEditors.XtraUserControl
    {
        ISachYeuCauService _sachYeuCauService = new SachYeuCauService();
        ISachService sachService = new SachService();
        public SachYeuCauDanhSach()
        {
            InitializeComponent();
        }

        private async Task showDuLieuSachYeuCau()
        {
            var danhSach = await _sachYeuCauService.GetListSachYeuCauDto();
            BindingList<SachYeuCau_DTO> listTacGia = new BindingList<SachYeuCau_DTO>(danhSach);
            gridSachYeuCau.DataSource = listTacGia;
            dtgSachYeuCau.OptionsBehavior.Editable = false;
            dtgSachYeuCau.OptionsView.ColumnAutoWidth = true;
            dtgSachYeuCau.BestFitColumns();
        }

        private void SachYeuCauDanhSach_Load(object sender, EventArgs e)
        {
            showDuLieuSachYeuCau().ContinueWith(x =>
            {
                if (x.IsFaulted || x.IsCanceled)
                {
                    MessageBox.Show("Lỗi show Dữ liệu sách yêu cầu");
                }
            });
        }

        private async void btnThemSachYC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenSachYC.Text))
            {
                var sachYCMoi = new SachYeuCauCreateInput
                {
                    TenSachYC = txtTenSachYC.Text,
                    TacGiaYC = txtTacGiaYC.Text,
                };
                await _sachYeuCauService.CreateSachYeuCau(sachYCMoi);
                txtTenSachYC.Text = string.Empty;
                txtTacGiaYC.Text = string.Empty;
            }
            await showDuLieuSachYeuCau();
            
        }

        private async void btnXoaSachYC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgSachYeuCau.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgSachYeuCau.FocusedRowHandle;
                string ID_Xoa = dtgSachYeuCau.GetRowCellDisplayText(selectedRowHandle, "SachYeuCauId");
                var ID = Int32.Parse(ID_Xoa);
                await _sachYeuCauService.DeleteSachYeuCauById(ID);
                MessageBox.Show("Đã Xóa");
                await showDuLieuSachYeuCau();
            }
        }

        private async void btnNhapSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SachCreateOrUpdate sachNhap;
            if (dtgSachYeuCau.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgSachYeuCau.FocusedRowHandle;
                var tenSachNhap = dtgSachYeuCau.GetRowCellDisplayText(selectedRowHandle, "TenSachYC") ?? string.Empty;
                var tenTacGia = dtgSachYeuCau.GetRowCellDisplayText(selectedRowHandle, "TacGiaYC") ?? string.Empty;
                if (!string.IsNullOrEmpty(tenSachNhap) && !string.IsNullOrEmpty(tenTacGia))
                {
                    var matchingSach = await sachService.GetSachByTenVaTacGia(tenSachNhap, tenTacGia);
                    if (matchingSach == null)
                    {
                        sachNhap = new SachCreateOrUpdate(tenSachNhap, tenTacGia);
                    }
                    else
                    {
                        sachNhap = new SachCreateOrUpdate(matchingSach.ID);
                    }
                    sachNhap.Show(this);
                }
            }
        }
    }
}
