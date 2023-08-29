using DAL.Services.NhanVien;
using DAL.Services.NhanVien.DTO;
using DAL.Services.TheLoais.DTO;
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

namespace GUI.Form_NhanVien
{
    public partial class NhanVien_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {
        INhanVienService nhanVienService = new NhanVienService();
        public NhanVien_DanhSach2()
        {
            InitializeComponent();
        }

        private void NhanVien_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuNhanVien().ContinueWith(x =>
            {
                if(x.IsFaulted)
                {
                    MessageBox.Show("Lỗi show dữ liệu nhân viên");
                }
            });
        }

        private async Task showDuLieuNhanVien()
        {
            var danhSach = await nhanVienService.QueryFilterDto().ToListAsync();
            BindingList<NhanVien_DTO> listNhanVien = new BindingList<NhanVien_DTO>(danhSach);
            gridNhanVien.DataSource = listNhanVien;
            dtgNhanVien.OptionsBehavior.Editable = false;
            dtgNhanVien.OptionsView.ColumnAutoWidth = true;
            dtgNhanVien.BestFitColumns();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nhanVienMoi = new NhanVien_ThongTinTaiKhoan();
            nhanVienMoi.FormClosed += childFormClose;
            nhanVienMoi.Show(this);
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            NhanVien_DanhSach2_Load(null, null);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgNhanVien.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgNhanVien.FocusedRowHandle;
                string ID_NhanVienCapNhat = dtgNhanVien.GetRowCellDisplayText(selectedRowHandle, "NhanVienId");
                var nhanVienCapNhat = new NhanVien_ThongTinTaiKhoan(Int32.Parse(ID_NhanVienCapNhat));
                nhanVienCapNhat.FormClosed += childFormClose;
                nhanVienCapNhat.Show(this);
            }
            else
            {
                showDuLieuNhanVien().ContinueWith(x =>
                {
                    if (x.IsFaulted)
                    {
                        MessageBox.Show("Lỗi Show Nhân Viên");
                    }
                });
            }
        }

        private async void btnXoa_ItemClickAsync(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgNhanVien.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgNhanVien.FocusedRowHandle;
                string ID_Xoa = dtgNhanVien.GetRowCellDisplayText(selectedRowHandle, "NhanVienId");
                int ID = Int32.Parse(ID_Xoa);
                await nhanVienService.DeleteNhanVienById(ID);
                MessageBox.Show("Đã Xóa");
                await showDuLieuNhanVien();
            }
        }
    }
}
