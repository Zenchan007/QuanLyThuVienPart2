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
        ITacGiaService _iTacGiaService = new TacGiaService();
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
            try {
                if (string.IsNullOrEmpty(errLoi.GetError(txtTenTacGia)) && string.IsNullOrEmpty(errLoi.GetError(dtpNgaySinh)))
                {
                    TacGiaCreateInput tacGiaCreateInput = new TacGiaCreateInput();
                    tacGiaCreateInput.TenTacGia = txtTenTacGia.Text;
                    tacGiaCreateInput.DiaChi = txtDiaChi.Text;
                    tacGiaCreateInput.SoDienThoai = txtSoDienThoai.Text;
                    if (checkNgaySinh.Checked)
                    {
                        tacGiaCreateInput.NamSinh = null;
                    }
                    else
                    {
                        tacGiaCreateInput.NamSinh = dtpNgaySinh.Text != string.Empty ? (DateTime?)dtpNgaySinh.DateTime : null;
                    }
                    if (checkNgayMat.Checked)
                    {
                        tacGiaCreateInput.NamMat = null;
                    }
                    else
                    {
                        tacGiaCreateInput.NamMat = dtpNgayMat.Text != string.Empty ? (DateTime?)dtpNgayMat.DateTime : null;
                    }
                    tacGiaCreateInput.AnhTacGia = XuLyAnh.ImageToByteArray(ptbAnhTacGia.Image);
                    tacGiaCreateInput.MoTa = txtMoTa.Text;
                    if (ID_CapNhat != 0)
                    {
                        await _iTacGiaService.UpdateTacGia(ID_CapNhat, tacGiaCreateInput);
                        MessageBox.Show("Update Thành Công Tác Giả");
                    }
                    else
                    {
                        await _iTacGiaService.CreateTacGia(tacGiaCreateInput);
                        MessageBox.Show("Thêm thành công Tác Giả");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền thông tin hợp lệ");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin hợp lệ");
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

                    var tacGiaCapNhat = await _iTacGiaService.QueryFilterDto().FirstOrDefaultAsync(x => x.TacGiaId == ID_CapNhat);
                    txtTenTacGia.Text = tacGiaCapNhat.TenTacGia.ToString();
                    txtDiaChi.Text = tacGiaCapNhat.DiaChi.ToString() ?? string.Empty;
                    txtSoDienThoai.Text = tacGiaCapNhat.SoDienThoai.ToString() ?? string.Empty;
                    txtMoTa.Text = tacGiaCapNhat.MoTa?.ToString() ?? string.Empty;
                    ptbAnhTacGia.Image = XuLyAnh.ByteArrayToImage(tacGiaCapNhat.AnhTacGia);
                    var tgCN = await _iTacGiaService.QueryFilter().FirstOrDefaultAsync(x => x.ID == ID_CapNhat);
                    txtSoLuongSachTG.Text = tgCN.Saches.Count().ToString();
                    if (tacGiaCapNhat.NamSinh != null)
                    {
                        checkNgaySinh.Checked = false;
                        dtpNgaySinh.DateTime = (DateTime)tacGiaCapNhat.NamSinh;
                    }
                    else
                    {
                        checkNgaySinh.Checked = true;
                        dtpNgaySinh.Text = string.Empty;
                    }
                    if (tacGiaCapNhat.NamMat != null)
                    {
                        checkNgayMat.Checked = false;
                        dtpNgayMat.DateTime = (DateTime)tacGiaCapNhat.NamMat;
                    }
                    else
                    {
                        checkNgayMat.Checked = true;
                        dtpNgayMat.Text = string.Empty;
                    }
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
            if(!string.IsNullOrEmpty(dtpNgayMat.Text) && !string.IsNullOrEmpty(dtpNgaySinh.Text))
            {
                if(dtpNgayMat.DateTime <= dtpNgaySinh.DateTime)
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
