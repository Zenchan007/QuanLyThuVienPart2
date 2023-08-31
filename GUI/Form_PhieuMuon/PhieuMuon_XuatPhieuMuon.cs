using DAL.Services.PhieuMuon_Sachs;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Form_PhieuMuon
{
    public partial class PhieuMuon_XuatPhieuMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuMuon_XuatPhieuMuon()
        {
            InitializeComponent();
        }

        BindingList<PhieuMuon_Sach_DTO> data;

        private void lbNgayLapPhieuMuon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void PhieuMuon_XuatPhieuMuon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            data = (BindingList<PhieuMuon_Sach_DTO>)this.DataSource;
        }

        private void duLieuSachMuon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            foreach (XRTableRow row in duLieuSachMuon.Rows)
            {
                PhieuMuon_Sach_DTO obj = data[row.Index]; // Sử dụng row.Index để lấy đối tượng từ danh sách

                // Gán dữ liệu từ các trường của đối tượng vào các cột của XRTable
                row.Cells[1].Text = obj.TenSachMuon; // Thay Field1 bằng tên thực tế của trường dữ liệu
                row.Cells[2].Text = obj.TacGiaSachMuon;
                row.Cells[3].Text = obj.SoLuongSachMuon.ToString();
                row.Cells[4].Text = obj.DonGiaMuon.ToString();
            }
        }
    }
}
