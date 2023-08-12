using DAL.Common;
using DAL.Services.TacGias.DTO;
using DAL.Services.TacGias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_TacGia
{
    public partial class TacGia_DanhSach : Form
    {
        int pageNumber = 0;
        int pageSize = 10;
        int totalCount = 0;
        int maxPage;
        TacGia_BLL TacGia_BLL = new TacGia_BLL(new TacGiaService());
        TacGiaFilterInput TacGia_Filter = new TacGiaFilterInput();
        public TacGia_DanhSach()
        {
            InitializeComponent();
        }

        private void TacGia_DanhSach_Load(object sender, EventArgs e)
        {
            showDuLieuNV().ContinueWith(x =>
            {
                if (x.IsFaulted)
                {
                    MessageBox.Show("Lỗi show dữ liệu nhân viên ban đầu");
                }
            });
        }

        private async Task showDuLieuNV()
        {
            var pageResultDTO = await TacGia_BLL.LayDanhSachNV(pageNumber, pageSize, TacGia_Filter);
            var listTacGia = pageResultDTO.Items.ToList();
            totalCount = pageResultDTO.TotalCount;
            maxPage = (int)Math.Ceiling(totalCount / (float)pageSize);
            dtgTacGia.Rows.Clear();
            foreach (var nv in listTacGia)
            {
                int rowIndex = dtgTacGia.Rows.Add();
                dtgTacGia.Rows[rowIndex].Cells["ID"].Value = nv.Id;
                dtgTacGia.Rows[rowIndex].Cells["TenTacGia"].Value = nv.TenTacGia;
                dtgTacGia.Rows[rowIndex].Cells["DiaChi"].Value = nv.DiaChi != null ? nv.DiaChi : "Không xác định";
                dtgTacGia.Rows[rowIndex].Cells["SoDienThoai"].Value = nv.SoDienThoai != null ? nv.SoDienThoai : "Không xác định";
                dtgTacGia.Rows[rowIndex].Cells["NamSinh"].Value = nv.NamSinh != DateTime.MinValue ? nv.NamSinh.ToString("dd/MM/yyyy") : "Không xác định";
                dtgTacGia.Rows[rowIndex].Cells["NamMat"].Value = nv.NamMat != DateTime.MinValue ? nv.NamMat.ToString("dd/MM/yyyy") : "Không xác định";
            }
            if (pageNumber <= 0)
            {
                pageNumber = 0;
                btnTruoc.Enabled = false;
                btnTrangDau.Enabled = false;
            }
            else
            {
                btnTruoc.Enabled = true;
                btnTrangDau.Enabled = true;
            }

            if (pageNumber + 1 >= maxPage)
            {
                pageNumber = maxPage - 1;
                btnSau.Enabled = false;
                btnTrangCuoi.Enabled = false;
            }
            else
            {
                btnTrangCuoi.Enabled = true;
                btnSau.Enabled = true;
            }
            txtTrang.Text = (pageNumber + 1).ToString() + "/" + maxPage.ToString();
        }
    }
    public class TacGia_BLL
    {
        private ITacGiaService iTacGiaService;
        public TacGia_BLL(ITacGiaService sv)
        {
            iTacGiaService = sv;
        }
        public async Task<PageResultDTO<TacGia_DTO>> LayDanhSachNV(int pageNumber, int pageSize, TacGiaFilterInput input = null)
        {
            var pageInput = new PagingInput<TacGiaFilterInput>(input)
            {
                SkipCount = pageSize * pageNumber,
                MaxResultCount = pageSize,
            };
            return await iTacGiaService.Paging(pageInput);
        }
        public async Task<bool> xoaTacGiaById(int Id)
        {
            var xoaNVTheoId = await iTacGiaService.DeleteTacGiaById(Id);
            return xoaNVTheoId;
        }
    }
}
