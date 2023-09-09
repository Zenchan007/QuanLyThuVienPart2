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
            lblTongSachKho2.Text = "Tổng Sách: " + lbTongSachKho.Text;
            lblSachChoMuon.Text = sachService.LayTongSoLuongChoMuon().ToString();
            lbSachConLai.Text = (await sachService.SachTrongKho()).ToString();
            
            var x1 =  await tacGiaService.GetListTacGia();
            lblSoLuongTacGia.Text = x1.Count().ToString();
            var x2 = await theLoaiService.GetListTheLoai();
            lblSoLuongTheLoai.Text = x2.Count().ToString();
            lblSoSachTraMuon.Text  = sachService.LaySoSachTraMuon().ToString();
            lbTheLoaiYeuThich.Text = theLoaiService.TheLoaiMuonNhieuNhat() ?? string.Empty;
            lbTacGiaYeuThich.Text = tacGiaService.LayTacGiaYeuThich() ?? string.Empty;
            var danhSachTop5 = sachService.GetTop5Sach();
            for (int i = 0; i < 5; i++)
            {
                if (i < danhSachTop5.Count)
                {
                    switch (i)
                    {
                        case 0:
                            lblTenSachTop1.Text = danhSachTop5[i] ?? string.Empty;
                            break;
                        case 1:
                            lbTenSachTop2.Text = danhSachTop5[i] ?? string.Empty;
                            break;
                        case 2:
                            lbTenSachTop3.Text = danhSachTop5[i] ?? string.Empty;
                            break;
                        case 3:
                            lbTenSachTop4.Text = danhSachTop5[i] ?? string.Empty;
                            break;
                        case 4:
                            lbTenSachTop5.Text = danhSachTop5[i] ?? string.Empty;
                            break;
                    }
                }
            }
            await FillChartLine();
            await FillChart();
            await FillChartPie();
        }


        public async Task FillChartLine()
        {
            var tongSachTheoTheLoai = await sachService.GetBookCategoryStatistics();
            int seriesIndex = 0; // Chỉ số của Series bạn muốn thao tác

            // Kiểm tra xem có ít nhất một Series trong danh sách
            if (chartDocGiaTheoThang.Series.Count > seriesIndex)
            {
                var series = chartDocGiaTheoThang.Series[seriesIndex];

                // Kiểm tra xem Series đó đã được khởi tạo chưa
                if (series.Points != null)
                {
                    // Xóa dữ liệu cũ
                    series.Points.Clear();

                    // Thêm dữ liệu mới vào Series
                    foreach (var item in tongSachTheoTheLoai)
                    {
                        var point = new SeriesPoint(item.Key, item.Value);
                        series.Points.Add(point);
                    }
                }
            }
        }
        public async Task FillChart()
        {
            chartDanhSoTheoTheLoai.Titles.Clear(); // Xóa các tiêu đề hiện có (nếu có)
            var chartTitle = new ChartTitle();
            chartTitle.Text = "Biểu Đồ Số Sách Mượn Qua Các Tháng"; // Đặt nội dung tiêu đề
            chartDanhSoTheoTheLoai.Titles.Add(chartTitle); // Thêm tiêu đề vào biểu đồ
            var tongSachTheoTheLoai = await phieuMuon_SachsService.GetNgayMuonVaSoLuong();
            if (chartDanhSoTheoTheLoai.Series.Count > 0)
            {
                var series = chartDanhSoTheoTheLoai.Series[0];
                if (series.Points != null)
                {
                    series.Points.Clear();
                    foreach (var item in tongSachTheoTheLoai)
                    {
                        var point = new SeriesPoint(item.Key, item.Value);
                        series.Points.Add(point);
                    }
                }
            }
            if (chartDanhSoTheoTheLoai.Diagram != null && chartDanhSoTheoTheLoai.Diagram is XYDiagram)
            {
                var diagram = (XYDiagram)chartDanhSoTheoTheLoai.Diagram;
                diagram.AxisX.NumericScaleOptions.AutoGrid = false;
                diagram.AxisX.NumericScaleOptions.GridSpacing = 1;
            }
        }
        public async Task FillChartPie()
        {
            var tongSachTheoTheLoai = await sachService.GetTongSachTheoTheLoai();

            // Kiểm tra xem có ít nhất một Series trong danh sách
            if (chartTyLeTheLoai.Series.Count > 0)
            {
                chartTyLeTheLoai.Series[0].Points.Clear();

                foreach (var item in tongSachTheoTheLoai)
                {
                    var point = new SeriesPoint(item.Key, item.Value);
                    chartTyLeTheLoai.Series[0].Points.Add(point);
                    chartTyLeTheLoai.Series[0].Name = item.Key;
                }

                chartTyLeTheLoai.Series[0].ArgumentDataMember = "Argument";
                chartTyLeTheLoai.Series[0].ValueDataMembers.AddRange("Value");
                chartTyLeTheLoai.Series[0].ShowInLegend = true;
                chartTyLeTheLoai.Series[0].LegendTextPattern = "{A}";
            }


        }


    }
}
