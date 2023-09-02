using DAL.Services.NhanVien;
using DAL.Services.PhieuMuon_PhieuMuon_Sachs;
using DAL.Services.PhieuMuon_Sach_Sachs;
using DAL.Services.Sachs.DTO;
using DAL.Services.TacGias;
using DAL.Services.TheLoais;
using DevExpress.XtraCharts;
using GUI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_BaoCao
{
    public partial class BaoCaoBieuDo : UserControl
    {
        public int NhanVienId = Login_form.User_Id;
        INhanVienService nhanVienService = new NhanVienService();
        ISachService sachService = new SachService();
        ITacGiaService tacGiaService = new TacGiaService();
        ITheLoaiService theLoaiService = new TheLoaiService();
        IPhieuMuon_SachsService phieuMuon_SachsService = new PhieuMuon_SachsService();
        public BaoCaoBieuDo()
        {
            InitializeComponent();
        }

        private async void BaoCaoBieuDo_Load(object sender, EventArgs e)
        {
            var nhanVien = await nhanVienService.GetById(NhanVienId);
            lblAdmin.Text = nhanVien.TenNhanVien + ", ";
            lbTongSachKho.Text = ((await sachService.SachTrongKho()) + sachService.LayTongSoLuongChoMuon()).ToString();
            lblTongSachKho2.Text = lbTongSachKho.Text;
            lblSachChoMuon.Text = sachService.LayTongSoLuongChoMuon().ToString();
            lbSachConLai.Text = (await sachService.SachTrongKho()).ToString();
            lblSoLuongTacGia.Text = tacGiaService.QueryFilterDto().ToList().Count().ToString();
            lblSoLuongTheLoai.Text = theLoaiService.QueryFilterDto().ToList().Count().ToString();
            lblSoSachTraMuon.Text  = sachService.LaySoSachTraMuon().ToString();
            lbTheLoaiYeuThich.Text = theLoaiService.TheLoaiMuonNhieuNhat();
            lbTacGiaYeuThich.Text = tacGiaService.LayTacGiaYeuThich().ToString();
            var danhSachTop5 = sachService.GetTop5Sach();
            lblTenSachTop1.Text = danhSachTop5[0] ?? string.Empty;
            //lblTenSachTop1.ForeColor = Color.Orange;
            lbTenSachTop2.Text = danhSachTop5[1] ?? string.Empty;
            //lbTenSachTop2.ForeColor = Color.Pink;
            lbTenSachTop3.Text = danhSachTop5[2] ?? string.Empty;
            //lbTenSachTop3.ForeColor = Color.LightBlue;
            lbTenSachTop4.Text = danhSachTop5[3] ?? string.Empty;
            //lbTenSachTop4.ForeColor = Color.Green;
            lbTenSachTop5.Text = danhSachTop5[4] ?? string.Empty;
            //lbTenSachTop5.ForeColor = Color.Gray;
            FillChartLine();
            FillChart();
            FillChartPie();
        }


        public void FillChartLine()
        {
            chartDocGiaTheoThang.Titles.Clear(); // Xóa các tiêu đề hiện có (nếu có)
            var chartTitle = new ChartTitle();
            chartTitle.Text = "Biểu Đồ Số Lương Thể Loại Cho Mượn"; // Đặt nội dung tiêu đề
            chartDocGiaTheoThang.Titles.Add(chartTitle); // Thêm tiêu đề vào biểu đồ

            var tongSachTheoTheLoai = sachService.GetBookCategoryStatistics();
            chartDocGiaTheoThang.Series[0].Points.Clear();

            foreach (var item in tongSachTheoTheLoai)
            {
                var point = new SeriesPoint(item.Key, item.Value);
                chartDocGiaTheoThang.Series[0].Points.Add(point);

            }
        }
        public void FillChart()
        {
            chartDanhSoTheoTheLoai.Titles.Clear(); // Xóa các tiêu đề hiện có (nếu có)

            var chartTitle = new ChartTitle();
            chartTitle.Text = "Biểu Đồ Số Sách Mượn Qua Các Tháng"; // Đặt nội dung tiêu đề
            chartDanhSoTheoTheLoai.Titles.Add(chartTitle); // Thêm tiêu đề vào biểu đồ

            var tongSachTheoTheLoai = phieuMuon_SachsService.GetNgayMuonVaSoLuong();
            chartDanhSoTheoTheLoai.Series[0].Points.Clear();

            foreach (var item in tongSachTheoTheLoai)
            {
                var point = new SeriesPoint(item.Key, item.Value);
                chartDanhSoTheoTheLoai.Series[0].Points.Add(point);
                chartDanhSoTheoTheLoai.Series[0].Name = "Số Lượng Sách Mượn Trong Một Tháng";
            }
            ((XYDiagram)chartDanhSoTheoTheLoai.Diagram).AxisX.NumericScaleOptions.AutoGrid = false;
            ((XYDiagram)chartDanhSoTheoTheLoai.Diagram).AxisX.NumericScaleOptions.GridSpacing = 1;

        }
        public void FillChartPie()
        {
            chartTyLeTheLoai.Titles.Clear(); // Xóa các tiêu đề hiện có (nếu có)
            var chartTitle = new ChartTitle();
            chartTitle.Text = "Biểu Đồ Tỷ Lệ Thể Loại Các Loại Sách"; // Đặt nội dung tiêu đề
            chartTyLeTheLoai.Titles.Add(chartTitle); // Thêm tiêu đề vào biểu đồ

            var tongSachTheoTheLoai = sachService.GetTongSachTheoTheLoai();
            chartTyLeTheLoai.Series[0].Points.Clear();

            foreach (var item in tongSachTheoTheLoai)
            {
                var point = new SeriesPoint(item.Key, item.Value);
                chartTyLeTheLoai.Series[0].Points.Add(point);
                chartTyLeTheLoai.Series[0].Name = item.Key;
            }

            // Đặt tên của trục x và y
            chartTyLeTheLoai.Series[0].ArgumentDataMember = "Argument"; // Trục x (Thể loại)
            chartTyLeTheLoai.Series[0].ValueDataMembers.AddRange("Value"); // Trục y (Số lượng)

            // Đặt tên cho series (Legend)

            // Hiển thị chú thích (Legend)
            chartTyLeTheLoai.Series[0].ShowInLegend = true;
            chartTyLeTheLoai.Series[0].LegendTextPattern = "{A}"; // Hiển thị item.key trong chú thích

            // Cập nhật dữ liệu biểu đồ




        }
    }
}
