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
        }
    }
}
