
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Common;
using DAL.Services.NhaPhanPhois;
using DAL.Services.NhaPhanPhois.DTO;

namespace GUI.Form_NhaPhanPhoi
{
    public partial class NhaPhanPhoi_DanhSach : Form
    {
        public NhaPhanPhoi_DanhSach()
        {
            InitializeComponent();
        }


        int pageNumber = 0;
        int pageSize = 10;
        int totalCount = 0;
        int maxPage;
        NhaPhanPhoi_BLL NhaPhanPhoi_BLL = new NhaPhanPhoi_BLL(new NhaPhanPhoiService());
        NhaPhanPhoiFilterInput NhaPhanPhoi_Filter = new NhaPhanPhoiFilterInput();
      

        private void NhaPhanPhoi_DanhSach_Load(object sender, EventArgs e)
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
            var pageResultDTO = await NhaPhanPhoi_BLL.LayDanhSachNV(pageNumber, pageSize, NhaPhanPhoi_Filter);
            var listNhaPhanPhoi = pageResultDTO.Items.ToList();
            totalCount = pageResultDTO.TotalCount;
            maxPage = (int)Math.Ceiling(totalCount / (float)pageSize);
            dtgNhaPhanPhoi.Rows.Clear();
            foreach (var nv in listNhaPhanPhoi)
            {
                int rowIndex = dtgNhaPhanPhoi.Rows.Add();
                dtgNhaPhanPhoi.Rows[rowIndex].Cells["ID"].Value = nv.Id;
                dtgNhaPhanPhoi.Rows[rowIndex].Cells["TenNhaPhanPhoi"].Value = nv.TenNhaPhanPhoi;
                dtgNhaPhanPhoi.Rows[rowIndex].Cells["DiaChi"].Value = nv.DiaChi != null ? nv.DiaChi : "Không xác định";
                dtgNhaPhanPhoi.Rows[rowIndex].Cells["SoDienThoai"].Value = nv.SoDienThoai != null ? nv.SoDienThoai : "Không xác định";
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
    public class NhaPhanPhoi_BLL
    {
        private INhaPhanPhoiService iNhaPhanPhoiService;
        public NhaPhanPhoi_BLL(INhaPhanPhoiService sv)
        {
            iNhaPhanPhoiService = sv;
        }
        public async Task<PageResultDTO<NhaPhanPhoi_DTO>> LayDanhSachNV(int pageNumber, int pageSize, NhaPhanPhoiFilterInput input = null)
        {
            var pageInput = new PagingInput<NhaPhanPhoiFilterInput>(input)
            {
                SkipCount = pageSize * pageNumber,
                MaxResultCount = pageSize,
            };
            return await iNhaPhanPhoiService.Paging(pageInput);
        }
        public async Task<bool> xoaNVTheoId(string Id)
        {
            var xoaNVTheoId = await iNhaPhanPhoiService.DeleteNhaPhanPhoiById(Id);
            return xoaNVTheoId;
        }
    }
}
