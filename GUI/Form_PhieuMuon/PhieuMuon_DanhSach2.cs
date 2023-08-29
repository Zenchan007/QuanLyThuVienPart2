using DAL.Services.TacGias.DTO;
using DAL.Services.TacGias;
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
using DAL.Services.PhieuMuons;
using System.Data.Entity;
using DAL.Services.PhieuMuons.DTO;
using GUI.Form_Sach;

namespace GUI.Form_PhieuMuon
{
    public partial class PhieuMuon_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {
        IPhieuMuonService phieuMuonService = new PhieuMuonService();
        public PhieuMuon_DanhSach2()
        {
            InitializeComponent();
        }

        private void PhieuMuon_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuPhieuMuon();
        }

        private async void showDuLieuPhieuMuon()
        {
            var danhSach = await phieuMuonService.QueryFilterDto().ToListAsync();
            BindingList<PhieuMuon_DTO> listTacGia = new BindingList<PhieuMuon_DTO>(danhSach);
            gridPhieuMuon.DataSource = listTacGia;
            dtgPhieuMuon.OptionsBehavior.Editable = false;
            dtgPhieuMuon.OptionsView.ColumnAutoWidth = true;
            dtgPhieuMuon.BestFitColumns();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var phieuMuonMoi = new PhieuMuon_CRUD();
            phieuMuonMoi.FormClosed += childFormClose;
            phieuMuonMoi.Show(this);
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            PhieuMuon_DanhSach2_Load(null, null);
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgPhieuMuon.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgPhieuMuon.FocusedRowHandle;
                string ID_PhieuMuonCapNhat = dtgPhieuMuon.GetRowCellDisplayText(selectedRowHandle, "SachId");
                var phieuMuonCapNhat = new PhieuMuon_CRUD(ID_PhieuMuonCapNhat);
                phieuMuonCapNhat.FormClosed += childFormClose;
                phieuMuonCapNhat.Show(this);
            }
            else
            {
                showDuLieuPhieuMuon();
            }
        }

        private async void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgPhieuMuon.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgPhieuMuon.FocusedRowHandle;
                string ID_Xoa = dtgPhieuMuon.GetRowCellDisplayText(selectedRowHandle, "PhieuMuonId");
                await phieuMuonService.DeletePhieuMuonById(ID_Xoa);
                MessageBox.Show("Đã Xóa");
                showDuLieuPhieuMuon();
            }
        }
    }
}
