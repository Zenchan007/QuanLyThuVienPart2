using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.Form_PhieuMuon
{
    public partial class PhieuMuon_XuatPhieuMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuMuon_XuatPhieuMuon()
        {
            InitializeComponent();
        }       
        public PhieuMuon_XuatPhieuMuon(int ID) : this()
        {
            ID_PhieuMuon.Value = ID;
        }
        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbNgayTaoPhieu.Text = "Ngày Tạo Phiếu " + DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
