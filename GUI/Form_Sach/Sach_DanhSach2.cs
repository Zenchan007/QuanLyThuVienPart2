using DAL.Services.Sachs.DTO;
using DevExpress.DashboardCommon.Viewer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using GUI.Form_PhieuMuon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;

namespace GUI.Form_Sach
{
    public partial class Sach_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {
        ISachService _isachService = new SachService();
        public Sach_DanhSach2()
        {
            InitializeComponent();
        }

        private void Sach_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuSach();
        }

        private void showDuLieuSach()
        {
            var danhSach = _isachService.QueryFilterDto().ToList();
            BindingList<Sach_DTO> listSach = new BindingList<Sach_DTO>(danhSach);
            gridSach.DataSource = listSach;
            dtgSach.OptionsBehavior.Editable = false;
            dtgSach.OptionsView.ColumnAutoWidth = true;
            dtgSach.BestFitColumns();
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sachMoi = new SachCreateOrUpdate();
            sachMoi.FormClosed += childFormClose;
            sachMoi.Show(this);
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            Sach_DanhSach2_Load(null, null);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dtgSach.FocusedRowHandle >= 0)
            {
                int  selectedRowHandle = dtgSach.FocusedRowHandle;
                string ID_SachCapNhat = dtgSach.GetRowCellDisplayText(selectedRowHandle, "SachId");
                var sachCapNhat = new SachCreateOrUpdate(Int32.Parse(ID_SachCapNhat));
                sachCapNhat.FormClosed += childFormClose;
                sachCapNhat.Show(this);
            }
            else
            {
                showDuLieuSach();
            }
        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgSach.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgSach.FocusedRowHandle;
                string ID_Xoa = dtgSach.GetRowCellDisplayText(selectedRowHandle, "SachId");
                int ID = Int32.Parse(ID_Xoa);
                await _isachService.DeleteSachById(ID);
                MessageBox.Show("Đã Xóa");
                showDuLieuSach();
            }
        }

        private void btnGhiMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var phieuMuonMoi = new PhieuMuonCreateOrUpdate2();
            phieuMuonMoi.Show(this);
        }
    }
}
