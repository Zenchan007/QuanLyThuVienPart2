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
        #region Bien
        public string TenDocGia { set; get; }
        public string DiaChi { set; get; }
        public string NgayMuon { set; get; }
        public string NgayHenTra { set; get; }
        public string TenNhanVien { set; get; }
        public string TienCoc { set; get; }
        #endregion
        public PhieuMuon_XuatPhieuMuon()
        {
            InitializeComponent();
        }

        BindingList<PhieuMuon_Sach_DTO> data;

     
        private void PhieuMuon_XuatPhieuMuon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbNgayTaoPhieu.Text = "Ngày Tạo:" + DateTime.Now.ToString("dd/MM/yyyy");
            lblNhanVienGhi.Text = TenNhanVien;
            lbTenDocGia.Text = TenDocGia;
            lbDiaChi.Text = DiaChi;
            lbNgayMuon.Text = NgayMuon;
            lbNgayHenTra.Text = NgayHenTra;
            cTienCoc.Text = TienCoc;
            data = (BindingList<PhieuMuon_Sach_DTO>)this.DataSource;
        }

        private void duLieuSachMuon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            foreach (XRTableRow row in duLieuSachMuon.Rows)
            {
                PhieuMuon_Sach_DTO obj = data[row.Index]; 
                row.Cells[1].Text = obj.TenSachMuon; 
                row.Cells[2].Text = obj.TacGiaSachMuon;
                row.Cells[3].Text = obj.SoLuongSachMuon.ToString();
                row.Cells[4].Text = obj.DonGiaMuon.ToString();
            }
        }
    }
}
