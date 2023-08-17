﻿using DAL.Common;
using DAL.Services.DocGias;
using DAL.Services.DocGias.DTO;
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

namespace GUI.Form_DocGia
{
    public partial class DocGia_DanhSach : Form
    {
        int pageNumber = 0;
        int pageSize = 10;
        int totalCount = 0;
        int maxPage;
        IDocGiaService _iDocGiaService = new DocGiaService();
        DocGia_BLL DocGia_BLL = new DocGia_BLL(new DocGiaService());
        DocGiaFilterInput DocGia_Filter = new DocGiaFilterInput();
        public DocGia_DanhSach()
        {
            InitializeComponent();
        }

        private  void DocGia_DanhSach_Load(object sender, EventArgs e)
        {
             setTextSuggest();
            showDuLieuDocGia().ContinueWith(x =>
            {
                if (x.IsFaulted)
                {
                    MessageBox.Show("Lỗi show dữ liệu nhân viên ban đầu");
                }
            });
        }

        private void setTextSuggest()
        {
            #region thêm tên
            txtTenDocGia.Items.Clear();
            var listTenDocGia = _iDocGiaService.QueryFilter().Select(x => x.TenDocGia).ToList();
            foreach (var item in listTenDocGia)
                txtTenDocGia.Items.Add(item); txtTenDocGia.Items.Clear();
            #endregion
            #region thêm địa chỉ
            txtDiaChi.Items.Clear();
            var listDiaChiDocGia = _iDocGiaService.QueryFilter().Select(x => x.DiaChi).ToList();
            foreach (var item in listDiaChiDocGia)
                txtDiaChi.Items.Add(item ?? "Không xác định"); 
            #endregion
            #region thêm số điện thoại
            txtSoDienThoai.Items.Clear();
            var listSoDienThoaiDocGia = _iDocGiaService.QueryFilter().Select(x => x.SoDienThoai).ToList();
            foreach (var item in listSoDienThoaiDocGia)
                txtSoDienThoai.Items.Add(item ?? "Không xác định");
            #endregion
            #region thêm cccd
            txtCCCD.Items.Clear();
            var listCCCD = _iDocGiaService.QueryFilter().Select(x => x.CCCD).ToList();
            foreach (var item in listCCCD)
                txtCCCD.Items.Add(item ?? "Không xác định"); 
            #endregion
        }

        private async Task showDuLieuDocGia()
        {
            var pageResultDTO = await DocGia_BLL.LayDuLieuDocGia(pageNumber, pageSize, DocGia_Filter);
            var listDocGia = pageResultDTO.Items.ToList();
            totalCount = pageResultDTO.TotalCount;
            maxPage = (int)Math.Ceiling(totalCount / (float)pageSize);
            dtgDocGia.Rows.Clear();
            foreach (var nv in listDocGia)
            {
                int rowIndex = dtgDocGia.Rows.Add();
                dtgDocGia.Rows[rowIndex].Cells["ID"].Value = nv.Id;
                dtgDocGia.Rows[rowIndex].Cells["TenDocGia"].Value = nv.TenDocGia;
                dtgDocGia.Rows[rowIndex].Cells["DiaChi"].Value = nv.DiaChi != null ? nv.DiaChi : "Không xác định";
                dtgDocGia.Rows[rowIndex].Cells["SoDienThoai"].Value = nv.SoDienThoai != null ? nv.SoDienThoai : "Không xác định";
                dtgDocGia.Rows[rowIndex].Cells["CCCD"].Value = nv.CCCD != null ? nv.CCCD : "Không xác định";
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

        private async void btnTim_Click(object sender, EventArgs e)
        {
           DocGia_Filter.TenDocGia = txtTenDocGia.Text;
           DocGia_Filter.DiaChi = txtDiaChi.Text;
           DocGia_Filter.SoDienThoai = txtSoDienThoai.Text;
           DocGia_Filter.CCCD = txtCCCD.Text;
           await showDuLieuDocGia();
        }

        private void btnTrangDau_Click(object sender, EventArgs e)
        {

        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSau_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangCuoi_Click(object sender, EventArgs e)
        {

        }
    }
    public class DocGia_BLL
    {
        private IDocGiaService iDocGiaService;
        public DocGia_BLL(IDocGiaService sv)
        {
            iDocGiaService = sv;
        }
        public async Task<PageResultDTO<DocGia_DTO>> LayDuLieuDocGia(int pageNumber, int pageSize, DocGiaFilterInput input = null)
        {
            var pageInput = new PagingInput<DocGiaFilterInput>(input)
            {
                SkipCount = pageSize * pageNumber,
                MaxResultCount = pageSize,
            };
            return await iDocGiaService.Paging(pageInput);
        }
        public async Task<bool> xoaDocGiaById(int Id)
        {
            var xoaNVTheoId = await iDocGiaService.DeleteDocGiaById(Id);
            return xoaNVTheoId;
        }
    }
}
