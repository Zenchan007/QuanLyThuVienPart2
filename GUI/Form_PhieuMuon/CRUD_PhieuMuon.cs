using DAL.Services.Sachs.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_PhieuMuon
{
    public partial class CRUD_PhieuMuon : Form
    {
        Sach_BLL sach_BLL = new Sach_BLL(new SachService());
        SachFilterInput sach_Filter;
        ISachService _iSachService;
       
        RowData row = new RowData();
        string TheLoai;
        public CRUD_PhieuMuon()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            txtSoLuong.ForeColor = Color.Black;
            _iSachService = new SachService();
            sach_Filter = new SachFilterInput()
            {
                TenSach = cbbTenSach.Text,
                TenTacGia = cbbTacGia.Text
            };
            var KiemTraSach = _iSachService.QueryFilterDto(sach_Filter);
            int soLuong = KiemTraSach.Select(s => s.SoLuong).FirstOrDefault();
            if (soLuong > 0)
            {
                txtSoLuong.Text ="Kho còn: " + soLuong.ToString() + " quyển";
            }
            else
            {
                txtSoLuong.Text = "Thông tin không đúng";
                txtSoLuong.ForeColor = Color.Red;
            }
            TheLoai = string.Join(", ", KiemTraSach.SelectMany(s => s.TheLoais.Select(tl => tl.TenTheLoai)));
        }

        private void CRUD_PhieuMuon_Load(object sender, EventArgs e)
        {

        }

        private void btnThemPhieuMuon_Sach_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dtgPhieuMuon_Sach.Rows[0].Clone();
            row.Cells[0].Value = cbbTenSach.Text;
            row.Cells[1].Value = cbbTacGia.Text;
            row.Cells[2].Value = TheLoai;
            row.Cells[3].Value = txtSoLuong.Text;
            dtgPhieuMuon_Sach.Rows.Add(row);

        }

        private void dtgPhieuMuon_Sach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Set tooltip cho thể loại
        }
    }

    public class RowData
    {
        public string TenSach { set; get; }
        public string TenTheLoai { set; get; }
        public int SoLuongMuon { set; get; }
        public string TenTacGia { set; get; }
    }
}
