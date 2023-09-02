using DAL.Services.DocGias;
using DAL.Services.DocGias.DTO;
using GUI.Form_Sach;
using System;
using System.Windows.Forms;

namespace GUI.Form_DocGia
{
    public partial class DocGiaCreateOrUpdate : Form
    {
        IDocGiaService _iDocGiaService = new DocGiaService();
        public int ID_CapNhat;
        public DocGiaCreateOrUpdate()
        {
            InitializeComponent();
        }

        public DocGiaCreateOrUpdate(int ID) : this()
        {
            this.ID_CapNhat = ID;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenDocGia.Text) && string.IsNullOrEmpty(txtDiaChi.Text)){
                    throw new Exception("Vui lòng điền đúng đủ thông tin");
                }
                if (string.IsNullOrEmpty(errLoi.GetError(txtTenDocGia)) && string.IsNullOrEmpty(errLoi.GetError(txtDiaChi)))
                {
                    var docGiaMoi = new DocGiaCreateInput
                    {
                        TenDocGia = txtTenDocGia.Text,
                        DiaChi = txtDiaChi.Text,
                        SoDienThoai = txtSoDienThoai.Text,
                        CCCD = txtCCCD.Text,
                        AnhDocGia = XuLyAnh.ImageToByteArray(ptbAnhDocGia.Image),
                    };
                    if (ID_CapNhat != 0)
                    {
                        _iDocGiaService.UpdateDocGia(ID_CapNhat, docGiaMoi);
                        MessageBox.Show("Cập Nhật thành công độc giả");
                        
                    }
                    else
                    {
                        _iDocGiaService.CreateDocGia(docGiaMoi);
                        MessageBox.Show("Đã Thêm Thành Công Độc Giả Mới Vào Trong CSDL");
                    }
                    this.Close();
                }
                else
                {
                    throw new Exception("Vui Lòng Điền Đúng,Đủ Thông Tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void DocGiaCreateOrUpdate_Load(object sender, EventArgs e)
        {
            if (ID_CapNhat != 0)
            {
                var docGiaCapNhat = await _iDocGiaService.GetById(ID_CapNhat);
                txtTenDocGia.Text = docGiaCapNhat.TenDocGia;
                txtDiaChi.Text = docGiaCapNhat.DiaChi;
                txtSoDienThoai.Text = docGiaCapNhat.SoDienThoai;
                txtCCCD.Text = docGiaCapNhat.CCCD;
                ptbAnhDocGia.Image = XuLyAnh.ByteArrayToImage(docGiaCapNhat.AnhSinhVien);
            }
            else
            {

            }
        }

        private void txtTenDocGia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDocGia.Text)) errLoi.SetError(txtTenDocGia, "Vui Lòng Nhập Tên Độc Giả");
            else errLoi.ClearErrors();
        }

        private void txtDiaChi_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text)) errLoi.SetError(txtDiaChi, "Vui Lòng Nhập Địa Chỉ");
            else errLoi.ClearErrors();
        }
    }
}
