using DAL.Model;
using DAL.QLTVExceptions;
using DAL.Services.DocGias;
using DAL.Services.NhanVien;
using DAL.Services.PhieuMuon_PhieuMuon_Sachs;
using DAL.Services.PhieuMuon_Sach_Sachs;
using DAL.Services.PhieuMuon_Sachs;
using DAL.Services.PhieuMuons;
using DAL.Services.PhieuMuons.DTO;
using DAL.Services.Sachs.DTO;
using DevExpress.Data.TreeList;
using DevExpress.LookAndFeel;
using DevExpress.Office.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using GUI.Form_Sach;
using GUI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI.Form_PhieuMuon
{
    public partial class PhieuMuonCreateOrUpdate : DevExpress.XtraEditors.XtraForm
    {

        #region Biến
        BindingSource bsPhieuMuon_Dto;
        BindingList<PhieuMuon_Sach_DTO> phieuMuon_Sach_DTOs;
        public int ID_CapNhat;
        public int ID_NhanVien = 1007;// Login_form.User_Id;
        private ISachService sachService = new SachService();
        private IPhieuMuon_SachsService phieuMuon_SachsService = new PhieuMuon_SachsService();
        private IPhieuMuonService phieuMuonService = new PhieuMuonService();
        private IDocGiaService docGiaService = new DocGiaService();
        private INhanVienService nhanVienService = new NhanVienService();
        PhieuMuon_DTO phieuMuon;
        #endregion
        public PhieuMuonCreateOrUpdate()
        {
            InitializeComponent();
        }

        public PhieuMuonCreateOrUpdate(int ID) : this()
        {
            ID_CapNhat = ID;
        }




        private async void PhieuMuonCreateOrUpdate2_Load(object sender, EventArgs e)
        {
            var listMaDocGia = docGiaService.QueryFilter().Select(x => x.ID).ToList();
            txtMaDocGia.Properties.Items.AddRange(listMaDocGia);
            bsPhieuMuon_Dto = new BindingSource();
            phieuMuon_Sach_DTOs = new BindingList<PhieuMuon_Sach_DTO>();
            txtMaNhanVien.ReadOnly = true;
            dtpNgayHenTra.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            if (ID_CapNhat == 0)
            {
                btnTraSach.Enabled = false;
                txtTenNhanVien.Text = nhanVienService.QueryFilter().FirstOrDefault(x => x.ID == ID_NhanVien).TenNhanVien;
                txtTenDocGia.ReadOnly = true;
                // Trong Trường Hợp Thêm Mới Phiếu Mượn 
                txtMaNhanVien.Text = ID_NhanVien.ToString(); // Nhân Viên Ghi Sẽ là Nhân viên hiện tại
                layoutTrangThai.HideToCustomization();// Ẩn một số chức năng và một số lay out
                btnTaoHoaDon.Enabled = false;// Một số chức năng sẽ không hoạt động
                btnInPhieuMuon.Enabled = false;
                dtpNgayMuon.DateTime = DateTime.Now.Date;
                dtpNgayTra.Text = string.Empty; // Ngày Trả Không có
                layoutNgayTra.HideToCustomization(); // Ẩn ngày Trả
                txtThoiGianMuon.Text = string.Empty; // Thời Gian Muộn
                layoutThoiGianMuon.HideToCustomization();
            }
            else
            {
                dtpNgayMuon.ReadOnly = true;
                layoutDocGiaMoi.HideToCustomization();
                phieuMuon = phieuMuonService.QueryFilterDto().FirstOrDefault(x => x.PhieuMuonId == ID_CapNhat);
                txtMaDocGia.Text = phieuMuon.DocGiaId.ToString() ?? string.Empty;
                txtMaNhanVien.Text = phieuMuon.NhanVienId.ToString() ?? string.Empty;
                dtpNgayMuon.Text = phieuMuon.NgayMuon.ToString() ?? string.Empty;
                dtpNgayHenTra.Text = phieuMuon.NgayHenTra.ToString() ?? string.Empty;
                txtGhiChu.Text = phieuMuon.GhiChu.ToString() ?? string.Empty;
                txtTienCoc.Text = phieuMuon.TienCoc.ToString() ?? string.Empty;
                dtpNgayTra.Text = phieuMuon.NgayTra.ToString() ?? string.Empty;
                txtTrangThai.Text = phieuMuon.TenTrangThai;
                txtMaDocGia.ReadOnly = true;
                txtTenDocGia.ReadOnly = true;
                var IdTrangThai = phieuMuon.TrangThaiId;
                var maNhanVienGhi = Int32.Parse(txtMaNhanVien.Text);
                txtTenNhanVien.Text = nhanVienService.QueryFilter().FirstOrDefault(x => x.ID == maNhanVienGhi).TenNhanVien;
                dtpThoiHan.Text = (dtpNgayHenTra.DateTime - dtpNgayMuon.DateTime).Days.ToString();
                if (IdTrangThai == 1)
                {
                    layoutThoiGianMuon.HideToCustomization();
                }
                if (IdTrangThai == 2)
                {
                    txtTrangThai.ForeColor = Color.Red;
                    TimeSpan difference = DateTime.Today - dtpNgayHenTra.DateTime;
                    int soNgayMuon = difference.Days;
                    txtThoiGianMuon.Text = soNgayMuon.ToString();
                    layoutDocGiaMoi.HideToCustomization();
                }
                else if (IdTrangThai == 3)
                {
                    txtTienCoc.ReadOnly = true;
                    btnTraSach.Enabled = false;
                    layoutDocGiaMoi.HideToCustomization();
                    txtMaDocGia.ReadOnly = true;
                    txtTenDocGia.ReadOnly = true;
                    dtpThoiHan.ReadOnly = true;
                    dtpNgayMuon.ReadOnly = true;
                    dtpNgayHenTra.ReadOnly = true;
                    dtpNgayTra.ReadOnly = true;
                    txtTrangThai.ForeColor = Color.Green;
                    layoutThemSach.HideToCustomization();
                    layoutSach.HideToCustomization();
                    emp1.HideToCustomization();
                    layoutThoiGianMuon.HideToCustomization();
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
                    sachMuonDto.TacGiaSachMuon = sachMuon?.TacGia?.TenTacGia ?? string.Empty;
                    sachMuonDto.TenSachMuon = sachMuon?.TenSach ?? string.Empty;
                    phieuMuon_Sach_DTOs.Add(sachMuonDto);
                }
            }
            bsPhieuMuon_Dto.DataSource = phieuMuon_Sach_DTOs;
            gridPhieuMuon_Sach.DataSource = bsPhieuMuon_Dto;
            await showDuLieuSach();
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


        private async Task<List<PhieuMuon_SachCreateInput>> AddDuLieuListSachMuon()
        {
            List<PhieuMuon_SachCreateInput> list = new List<PhieuMuon_SachCreateInput>();
            await Task.Run(() =>
            {
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
            });
            return list;
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


        #region Event Button 
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnInPhieuMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            PhieuMuon_XuatPhieuMuon xuat = new PhieuMuon_XuatPhieuMuon(ID_CapNhat);
            ReportPrintTool tool = new ReportPrintTool(xuat, true);
         //   tool.PreviewForm.MdiParent = this;
            tool.ShowPreview(UserLookAndFeel.Default);

           
        }

        private async void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTienCoc.ReadOnly = true;
            dtpNgayMuon.ReadOnly = false;
            dtpNgayHenTra.ReadOnly = false;
            txtThoiGianMuon.ReadOnly = false;
            if (string.IsNullOrEmpty(dtpNgayTra.Text))
            {
                dtpNgayTra.DateTime = DateTime.Now;
            }
            await phieuMuonService.UpdateTraSach(ID_CapNhat, dtpNgayTra.DateTime);
            phieuMuon = await phieuMuonService.QueryFilterDto().FirstOrDefaultAsync(x => x.PhieuMuonId == ID_CapNhat);
            txtTrangThai.Text = phieuMuon.TenTrangThai;
            txtTrangThai.ForeColor = Color.Green;
            var test = phieuMuon;
            MessageBox.Show("Trả sách thành công");
            btnTraSach.Enabled = false;
            layoutThemSach.HideToCustomization();
            layoutThoiGianMuon.HideToCustomization();
            await showDuLieuSach();
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
                    for (var rowHandle = 0; rowHandle < dtgPhieuMuon_Sach.RowCount;rowHandle++)
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
        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                var listSachMuon = await AddDuLieuListSachMuon();
                if (listSachMuon.Count > 0)
                {
                    var phieuMuonCreate = new PhieuMuonCreateInput
                    {

                        NhanVienId = Int32.Parse(txtMaNhanVien.Text),
                        GhiChu = txtGhiChu.Text,
                        NgayMuon = dtpNgayMuon.DateTime,
                        NgayHenTra = dtpNgayHenTra.DateTime,
                        ListSachMuon = listSachMuon,
                        TienCoc = Int32.Parse(txtTienCoc.Text),
                        TrangThaiId = dtpNgayHenTra.DateTime.Date >= DateTime.Today ? 1 : 2,
                    };
                    if (!checkDocGiaMoi.Checked)
                    {
                        if (string.IsNullOrEmpty(txtMaDocGia.Text))
                            throw new PhieuMuon_SachException("Vui lòng chọn mã độc giả");
                        phieuMuonCreate.DocGiaId = Int32.Parse(txtMaDocGia.Text);

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtTenDocGia.Text))
                            throw new PhieuMuon_SachException("Vui lòng điền tên độc giả");
                        phieuMuonCreate.DocGiaId = await docGiaService.CreateDocGia(new DAL.Services.DocGias.DTO.DocGiaCreateInput { TenDocGia = txtTenDocGia.Text });
                    }
                    if (ID_CapNhat == 0)
                    {
                        await phieuMuonService.CreatePhieuMuon(phieuMuonCreate);
                        MessageBox.Show("Tạo thành công phiếu mượn");
                        await showDuLieuSach();
                        this.Close();
                    }
                    else
                    {

                        if (phieuMuon.TrangThaiId != 3)
                        {
                            await phieuMuonService.UpdatePhieuMuon(ID_CapNhat, phieuMuonCreate);
                            MessageBox.Show("Update thành công phiếu mượn");
                            await showDuLieuSach();
                        }
                        this.Close();
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

            }
        }
        #endregion

        #region Validate
        private void txtMaDocGia_Validating(object sender, CancelEventArgs e)
        {
            if (!checkDocGiaMoi.Checked)
            {
                if (string.IsNullOrEmpty(txtMaDocGia.Text))
                {
                    errLoi.SetError(txtMaDocGia, "Vui lòng điền mã độc giả");
                }
                else errLoi.ClearErrors();
            }
        }
        private void checkDocGiaMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDocGiaMoi.Checked)
            {
                txtMaDocGia.ReadOnly = true;
                txtMaDocGia.Text = string.Empty;
                txtTenDocGia.ReadOnly = false;
                if (!string.IsNullOrEmpty(errLoi.GetError(txtMaDocGia))) errLoi.ClearErrors();
            }
            else
            {
                txtTenDocGia.Text = string.Empty;
                txtMaDocGia.ReadOnly = false;
                txtTenDocGia.ReadOnly = true;
                if (!string.IsNullOrEmpty(errLoi.GetError(txtTenDocGia))) errLoi.ClearErrors();
            }
        }

        private void dtpThoiHan_EditValueChanged(object sender, EventArgs e)
        {
            if (txtThoiGianMuon.Value >= 0)
            {
                dtpNgayHenTra.DateTime = dtpNgayMuon.DateTime.AddDays((int)dtpThoiHan.Value);
            }
            if (dtpThoiHan.Value <= 0)
            {
                dtpThoiHan.Value = 0;
            }
        }
        private void dtpNgayMuon_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpNgayMuon.Text) || dtpNgayMuon.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("Sai định dạng ngày. Vui lòng chọn lại");
                dtpNgayMuon.DateTime = DateTime.Now.Date;
            }
        }

        private async void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDocGia.Text))
            {
                var maDocGia = Int32.Parse(txtMaDocGia.Text);
                var tdg = await docGiaService.QueryFilter().FirstOrDefaultAsync(x => x.ID == maDocGia);
                txtTenDocGia.Text = tdg.TenDocGia;
            }
        }


        #endregion

        private void txtTenDocGia_Validating(object sender, CancelEventArgs e)
        {
            if (checkDocGiaMoi.Checked)
            {
                if (string.IsNullOrEmpty(txtTenDocGia.Text))
                {
                    errLoi.SetError(txtTenDocGia, "Vui lòng điền tên độc giả mới");
                }
                else errLoi.ClearErrors();
            }
        }

        private void dtpNgayMuon_EditValueChanged(object sender, EventArgs e)
        {
            dtpNgayHenTra.DateTime = dtpNgayMuon.DateTime.AddDays((int)dtpThoiHan.Value);
        }
    }
}