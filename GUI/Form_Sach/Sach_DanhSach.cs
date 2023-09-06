using DAL.Services.Sachs.DTO;
using DevExpress.DashboardCommon.Viewer;
using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using GUI.Form_PhieuMuon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI.Form_Sach
{
    public partial class Sach_DanhSach : DevExpress.XtraEditors.XtraUserControl
    {
        ISachService _isachService = new SachService();
        public Sach_DanhSach()
        {
            InitializeComponent();
        }

        private void Sach_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuSach();
        }

        private async void showDuLieuSach()
        {
            var danhSach =await _isachService.GetListSachDto();
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
            if (dtgSach.FocusedRowHandle >= 0)
            {
                int selectedRowHandle = dtgSach.FocusedRowHandle;
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
                if (XtraMessageBox.Show("Bạn có muốn xóa cuốn sách?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    await _isachService.DeleteSachById(ID);
                    MessageBox.Show("Đã Xóa");
                    showDuLieuSach();
                }
            }
        }

        private void btnGhiMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var phieuMuonMoi = new PhieuMuonCreateOrUpdate();
            phieuMuonMoi.Show(this);
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuatFileExcel("");
        }

        private bool XuatFileExcel(string filename)
        {
            try
            {
                if(dtgSach.FocusedRowHandle < 0)
                {

                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file Excel";
                    dialog.Filter = @"Microsoft Excel | *.xlsx";
                    dialog.FileName = filename;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                       
                        dtgSach.ColumnPanelRowHeight = 40;
                        dtgSach.OptionsPrint.AutoWidth = AutoSize;
                        dtgSach.OptionsPrint.ShowPrintExportProgress = true;
                        dtgSach.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"Sách ở trong kho";
                        ExportSettings.DefaultExportType = ExportType.Default;
                        dtgSach.ExportToXlsx(dialog.FileName, options);
                        XtraMessageBox.Show("Export Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);
                        if (File.Exists(dialog.FileName))
                        {
                            if(XtraMessageBox.Show("File đã có trên máy tính của bạn. Bạn có muốn mở ra không?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Process.Start(dialog.FileName);
                            }
                        }
                    } 
                }             
            }catch (Exception ex)
            {
                XtraMessageBox.Show("Export Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Trace.TraceError(ex.Message);
            }
            return false;
        }
    }
}