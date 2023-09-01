using DAL.Model;
using DAL.QLTVExceptions;
using DAL.Services.PhieuMuon_PhieuMuon_Sachs;
using DAL.Services.PhieuMuon_Sach_Sachs;
using DAL.Services.PhieuMuon_Sachs;
using DAL.Services.PhieuMuons;
using DAL.Services.PhieuMuons.DTO;
using DAL.Services.Sachs.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using GUI.Form_Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI.Form_PhieuMuon
{
    public partial class PhieuMuonCreateOrUpdate2 : DevExpress.XtraEditors.XtraForm
    {

        #region Biến
        BindingSource bsPhieuMuon_Dto;
        BindingList<PhieuMuon_Sach_DTO> phieuMuon_Sach_DTOs;
        public int ID_CapNhat;
        private ISachService sachService = new SachService();
        private IPhieuMuon_SachsService phieuMuon_SachsService = new PhieuMuon_SachsService();
        private IPhieuMuonService phieuMuonService = new PhieuMuonService();

        PhieuMuon_DTO phieuMuon;
        #endregion
        public PhieuMuonCreateOrUpdate2()
        {
            InitializeComponent();
        }

        public PhieuMuonCreateOrUpdate2(int ID) : this()
        {
            ID_CapNhat = ID;
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuMuonCreateOrUpdate2_Load(object sender, EventArgs e)
        {
            bsPhieuMuon_Dto = new BindingSource();
            phieuMuon_Sach_DTOs = new BindingList<PhieuMuon_Sach_DTO>();
            if (ID_CapNhat == 0)
            {
                layoutTrangThai.HideToCustomization();
                btnInHoaDon.Enabled = false;
                btnInPhieuMuon.Enabled = false;
                dtpNgayTra.Text = string.Empty;
                layoutNgayTra.HideToCustomization();
                txtThoiGianMuon.Text = string.Empty;
                layoutThoiGianMuon.HideToCustomization();

            }
            else
            {
                phieuMuon = phieuMuonService.QueryFilterDto().FirstOrDefault(x => x.PhieuMuonId == ID_CapNhat);
                txtMaDocGia.Text = phieuMuon.DocGiaId.ToString() ?? string.Empty;
                txtMaNhanVien.Text = phieuMuon.NhanVienId.ToString() ?? string.Empty;
                dtpNgayMuon.Text = phieuMuon.NgayMuon.ToString() ?? string.Empty;
                dtpNgayHenTra.Text = phieuMuon.NgayHenTra.ToString() ?? string.Empty;
                txtGhiChu.Text = phieuMuon.GhiChu.ToString() ?? string.Empty;
                txtTienCoc.Text = phieuMuon.TienCoc.ToString() ?? string.Empty;
                dtpNgayTra.Text = phieuMuon.NgayTra.ToString() ?? string.Empty;
                txtTrangThai.Text = phieuMuon.TenTrangThai;
                var IdTrangThai = phieuMuon.TrangThaiId;
                if (IdTrangThai == 2)
                {
                    txtTrangThai.ForeColor = Color.Red;
                }
                else if (IdTrangThai == 3)
                {
                    txtTrangThai.ForeColor = Color.Green;
                    layoutThemSach.HideToCustomization();
                    layoutSach.HideToCustomization();
                    emp1.HideToCustomization();
                }
                foreach (var item in phieuMuon.ListSachMuon)
                {
                    var sachMuonDto = new PhieuMuon_Sach_DTO
                    {
                        PhieuMuonId = ID_CapNhat,
                        SachMuonId = item.ID_Sach,
                        SoLuongSachMuon = item.SoLuong
                    };
                    var sachMuon = sachService.QueryFilter().FirstOrDefault(x => x.ID == sachMuonDto.SachMuonId);
                    sachMuonDto.DonGiaMuon = sachMuonDto.SoLuongSachMuon * sachMuon.DonGia;
                    sachMuonDto.TacGiaSachMuon = sachMuon.TacGia.TenTacGia;
                    sachMuonDto.TenSachMuon = sachMuon.TenSach;
                    phieuMuon_Sach_DTOs.Add(sachMuonDto);
                }
                layoutThoiGianMuon.HideToCustomization();
            }
            bsPhieuMuon_Dto.DataSource = phieuMuon_Sach_DTOs;
            gridPhieuMuon_Sach.DataSource = bsPhieuMuon_Dto;
            showDuLieuSach().ContinueWith(x =>
            {
                if (x.IsFaulted || x.IsCanceled)
                {
                    MessageBox.Show("Lỗi show dữ liệu sách");
                }
            });
        }

        private async Task showDuLieuSach()
        {
            var danhSach = await sachService.QueryFilterDto().ToListAsync();
            BindingList<Sach_DTO> listSach = new BindingList<Sach_DTO>(danhSach);
            gridSach.DataSource = listSach;
            dtgSach.OptionsBehavior.Editable = false;
            dtgSach.OptionsView.ColumnAutoWidth = true;
            dtgSach.BestFitColumns();
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {

                var listSachMuon = await AddDuLieuListSachMuon();
                if (listSachMuon.Count > 0)
                {
                    var phieuMuonCreate = new PhieuMuonCreateInput
                    {
                        DocGiaId = Int32.Parse(txtMaDocGia.Text),
                        NhanVienId = Int32.Parse(txtMaNhanVien.Text),
                        GhiChu = txtGhiChu.Text,
                        NgayMuon = dtpNgayMuon.DateTime,
                        NgayHenTra = dtpNgayHenTra.DateTime,
                        ListSachMuon = listSachMuon,
                        TienCoc = Int32.Parse(txtTienCoc.Text),
                        TrangThaiId = dtpNgayHenTra.DateTime.Date <= DateTime.Today ? 1 : 2,
                    };
                    
                    if (ID_CapNhat == 0)
                    {
                        await phieuMuonService.CreatePhieuMuon(phieuMuonCreate);
                        MessageBox.Show("Tạo thành công phiếu mượn");
                        await showDuLieuSach();
                    }
                    else
                    {
                        if (phieuMuon.TrangThaiId != 3)
                        {
                            await phieuMuonService.UpdatePhieuMuon(ID_CapNhat, phieuMuonCreate);
                            MessageBox.Show("Update thành công phiếu mượn");
                            await showDuLieuSach();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có cuốn sách nào trong phiếu mượn! Lưu không thành công");
                }

            }
            catch (PhieuMuon_SachException ex)
            {
                MessageBox.Show(ex.Message);
                await showDuLieuSach();
            }
            finally
            {
                this.Close();
            }
        }
        private async Task<List<PhieuMuon_SachCreateInput>> AddDuLieuListSachMuon()
        {
            List<PhieuMuon_SachCreateInput> list = new List<PhieuMuon_SachCreateInput>();
            foreach (var item in phieuMuon_Sach_DTOs)
            {
                var thongTinSachMuon = new PhieuMuon_SachCreateInput
                {
                    SachId = item.SachMuonId,
                    SoLuong = item.SoLuongSachMuon,
                    DonGiaMuon = item.DonGiaMuon,
                };
                list.Add(thongTinSachMuon);
            }
            return list;
        }

        private void btnThemSachPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                int sachChon = dtgSach.FocusedRowHandle;
                int sachId = dtgSach.GetRowCellValue(sachChon, "SachId") == null ? throw new Exception("Không có sách trong kho") : (int)dtgSach.GetRowCellValue(sachChon, "SachId");
                int soLuongSachGoc = (int)dtgSach.GetRowCellValue(sachChon, "SoLuong");
                if (soLuongSachGoc <= 0)
                {
                    MessageBox.Show("Sách Tạm Hết");
                }
                else
                {
                    bool daCoSach = false;
                    foreach (var rowHandle in dtgPhieuMuon_Sach.GetSelectedRows())
                    {
                        var existingSachId = (int)dtgPhieuMuon_Sach.GetRowCellValue(rowHandle, "SachMuonId");
                        if (existingSachId == sachId)
                        {
                            int soLuong = (int)dtgPhieuMuon_Sach.GetRowCellValue(rowHandle, "SoLuongSachMuon");
                            int ID = (int)dtgPhieuMuon_Sach.GetRowCellValue(rowHandle, "SachMuonId");
                            var DonGia = sachService.QueryFilter().FirstOrDefault(x => x.ID == ID).DonGia;
                            int soLuongTrongSach = (int)dtgSach.GetRowCellValue(sachChon, "SoLuong");
                            if (soLuong + 1 > soLuongTrongSach)
                            {
                                MessageBox.Show("Không thể thêm sách, số lượng sách đã hết!");
                                return;
                            }
                            dtgPhieuMuon_Sach.SetRowCellValue(rowHandle, "SoLuongSachMuon", soLuong += 1);
                            dtgPhieuMuon_Sach.SetRowCellValue(rowHandle, "DonGiaMuon", soLuong * DonGia);
                            daCoSach = true;
                            break;
                        }
                    }
                    if (!daCoSach)
                    {
                        var input = new PhieuMuon_SachCreateInput
                        {
                            SachId = sachId,
                        };

                        var TenSachMuon = dtgSach.GetRowCellValue(sachChon, "TenSach");
                        var TacGiaSachMuon = dtgSach.GetRowCellValue(sachChon, "TenTacGia");
                        var DonGia = dtgSach.GetRowCellValue(sachChon, "DonGia");
                        dtgPhieuMuon_Sach.AddNewRow();
                        dtgPhieuMuon_Sach.SetRowCellValue(GridControl.NewItemRowHandle, "SachMuonId", input.SachId);
                        dtgPhieuMuon_Sach.SetRowCellValue(GridControl.NewItemRowHandle, "TenSachMuon", TenSachMuon);
                        dtgPhieuMuon_Sach.SetRowCellValue(GridControl.NewItemRowHandle, "TacGiaSachMuon", TacGiaSachMuon);
                        dtgPhieuMuon_Sach.SetRowCellValue(GridControl.NewItemRowHandle, "SoLuongSachMuon", 1);
                        dtgPhieuMuon_Sach.SetRowCellValue(GridControl.NewItemRowHandle, "DonGiaMuon", DonGia);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = dtgPhieuMuon_Sach.FocusedRowHandle;
            dtgPhieuMuon_Sach.DeleteRow(focusedRowHandle);
        }

        private void dtgPhieuMuon_Sach_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double TienCoc = 0;
            foreach (var item in phieuMuon_Sach_DTOs)
            {
                TienCoc += item.DonGiaMuon;
            }
            txtTienCoc.Text = TienCoc.ToString();
        }

        private async void btnInPhieuMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuMuon_XuatPhieuMuon xuat = new PhieuMuon_XuatPhieuMuon();
            var phieuMuon = phieuMuonService.QueryFilterDto().FirstOrDefault(x => x.PhieuMuonId == ID_CapNhat);
            var list = phieuMuon.ListSachMuon;

            BindingList<PhieuMuon_Sach_DTO> listSM = new BindingList<PhieuMuon_Sach_DTO>();
            foreach (var item in list)
            {
                var x = await phieuMuon_SachsService.MapperModelToDTO(item, new PhieuMuon_Sach_DTO());
                listSM.Add(x);
            };
            xuat.DataSource = listSM;
            xuat.TenNhanVien = phieuMuon.TenNhanVien;
            xuat.TenDocGia = phieuMuon.TenDocGia;
            xuat.NgayMuon = phieuMuon.NgayMuon?.ToString("dd/MM/yyyy");
            xuat.NgayHenTra = phieuMuon.NgayHenTra?.ToString("dd/MM/yyyy");
            xuat.TienCoc = phieuMuon.TienCoc.ToString();
            ReportPrintTool tool = new ReportPrintTool(xuat);
            tool.ShowPreviewDialog();
        }

        private async void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtpNgayMuon.Enabled = false;
            dtpNgayHenTra.Enabled = false;
            txtThoiGianMuon.Enabled = false;
            if (string.IsNullOrEmpty(dtpNgayTra.Text))
            {
                dtpNgayTra.DateTime = DateTime.Now;
            }
            if (dtpNgayHenTra.DateTime < dtpNgayTra.DateTime)
            {
                TimeSpan difference = dtpNgayTra.DateTime - dtpNgayHenTra.DateTime;
                int soNgayMuon = difference.Days;
                txtThoiGianMuon.Text = soNgayMuon.ToString();
                layoutThoiGianMuon.ShowInCustomizationForm = true;
            }
            await phieuMuonService.UpdateTraSach(ID_CapNhat, dtpNgayTra.DateTime);
            txtTrangThai.Text = phieuMuon.TenTrangThai;
            MessageBox.Show("Trả sách thành công");
            layoutThemSach.HideToCustomization();
            await showDuLieuSach();
        }
    }
}