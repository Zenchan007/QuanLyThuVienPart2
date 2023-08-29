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

namespace GUI.Form_NhaPhanPhoi
{
    public partial class NhaPhanPhoi_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {
        INhaPhanPhoiService nhaPhanPhoiService = new NhaPhanPhoiService();
        public NhaPhanPhoi_DanhSach2()
        {
            InitializeComponent();
        }

      

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
               
                await nhaPhanPhoiService.DeleteNhaPhanPhoiById(ID_Xoa);
                MessageBox.Show("Đã Xóa");
                await showDuLieuNhaPhanPhoi();
            }
        }
    }
}
