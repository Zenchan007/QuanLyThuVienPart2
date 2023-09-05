using DAL.Services.TacGias;
using DAL.Services.TacGias.DTO;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
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
using System.Windows.Forms;


namespace GUI.Form_TacGia
{
    public partial class TacGiaCreateOrUpdate : Form
    {

        public int ID_CapNhat = 0;
        ITacGiaService tacGiaService = new TacGiaService();
        public TacGiaCreateOrUpdate()
        {
            InitializeComponent();
        }

        public TacGiaCreateOrUpdate(int ID) : this()
        {
            this.ID_CapNhat = ID;
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenTacGia.Text))
                {
                    throw new Exception("Vui lòng điền đủ thông tin");
                }
                if (string.IsNullOrEmpty(errLoi.GetError(txtTenTacGia)) && string.IsNullOrEmpty(errLoi.GetError(dtpNgaySinh)))
                {
                    TacGiaCreateInput tacGiaCreateInput = new TacGiaCreateInput();
                    tacGiaCreateInput.TenTacGia = txtTenTacGia.Text;
                    tacGiaCreateInput.DiaChi = txtDiaChi.Text;
                    tacGiaCreateInput.SoDienThoai = txtSoDienThoai.Text;
                    tacGiaCreateInput.NamSinh = dtpNgaySinh.Text != string.Empty ? (DateTime?)dtpNgaySinh.DateTime : null;
                    tacGiaCreateInput.NamMat = dtpNgayMat.Text != string.Empty ? (DateTime?)dtpNgayMat.DateTime : null;
                    tacGiaCreateInput.AnhTacGia = XuLyAnh.ImageToByteArray(ptbAnhTacGia.Image);
                    tacGiaCreateInput.MoTa = txtMoTa.Text;
                    if (ID_CapNhat != 0)
                    {
                        await tacGiaService.UpdateTacGia(ID_CapNhat, tacGiaCreateInput);
                        MessageBox.Show("Update Thành Công Tác Giả");
                    }
                    else
                    {
                        await tacGiaService.CreateTacGia(tacGiaCreateInput);
                        MessageBox.Show("Thêm thành công Tác Giả");
                    }
                    this.Close();
                }
                else
                {
                    throw new Exception("Vui lòng điền đủ thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void TacGiaCreateOrUpdate_Load(object sender, EventArgs e)
        {
            if (ID_CapNhat != 0)
            {
                var tacGiaCapNhat = await tacGiaService.QueryFilterDto().FirstOrDefaultAsync(x => x.TacGiaId == ID_CapNhat);
                txtTenTacGia.Text = tacGiaCapNhat.TenTacGia.ToString();
                txtDiaChi.Text = tacGiaCapNhat?.DiaChi?.ToString() ?? string.Empty;
                txtSoDienThoai.Text = tacGiaCapNhat?.SoDienThoai?.ToString() ?? string.Empty;
                txtMoTa.Text = tacGiaCapNhat.MoTa?.ToString() ?? string.Empty;
                ptbAnhTacGia.Image = XuLyAnh.ByteArrayToImage(tacGiaCapNhat.AnhTacGia);
                var tgCN = await tacGiaService.QueryFilter().FirstOrDefaultAsync(x => x.ID == ID_CapNhat);
                txtSoLuongSachTG.Text = tgCN.Saches.Count().ToString();
                dtpNgaySinh.Text = tacGiaCapNhat.NamSinh.ToString();
                dtpNgayMat.Text = tacGiaCapNhat.NamMat.ToString();
            }
            else
            {
                txtSoLuongSachTG.Hide();
            }


        }

        private void txtTenTacGia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTacGia.Text))
                errLoi.SetError(txtTenTacGia, "Tên tác giả không được để trống");
            else errLoi.ClearErrors();
        }

        private void dtpNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(dtpNgayMat.Text) && !string.IsNullOrEmpty(dtpNgaySinh.Text))
            {
                if (dtpNgayMat.DateTime <= dtpNgaySinh.DateTime)
                {
                    errLoi.SetError(dtpNgaySinh, "Ngày sinh không được nhỏ hơn hoặc bằng ngày mất");
                }
            }
        }

        private void dtpNgayMat_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(dtpNgayMat.Text) && !string.IsNullOrEmpty(dtpNgaySinh.Text))
            {
                if (dtpNgayMat.DateTime <= dtpNgaySinh.DateTime)
                {
                    errLoi.SetError(dtpNgaySinh, "Ngày sinh không được nhỏ hơn hoặc bằng ngày mất");
                }
            }
        }
    }
}