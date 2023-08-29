using DAL.Services.Sachs.DTO;
using DAL.Services.TheLoais;
using DAL.Services.TheLoais.DTO;
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

namespace GUI.Form_TheLoai
{
    public partial class TheLoai_DanhSach2 : DevExpress.XtraEditors.XtraUserControl
    {
        ITheLoaiService _iTheLoaiService = new TheLoaiService();
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
            var danhSach = _iTheLoaiService.QueryFilterDto().ToList();
            BindingList<TheLoai_DTO> listSach = new BindingList<TheLoai_DTO>(danhSach);
            gridTheLoai.DataSource = listSach;
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
                string ID_Xoa = dtgTheLoai.GetRowCellDisplayText(selectedRowHandle, "TheLoaiId");
            
                await _iTheLoaiService.DeleteTheLoaiById(ID_Xoa);
                MessageBox.Show("Đã Xóa");
                showDuLieuTheLoai();
            }
        }
    }
}
