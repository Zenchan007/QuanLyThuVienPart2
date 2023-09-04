using DAL.Services.NhaPhanPhois;
using DAL.Services.NhaPhanPhois.DTO;
using DAL.Services.Sachs.DTO;
using DAL.Services.TacGias;
using DAL.Services.TacGias.DTO;
using DAL.Services.TheLoais;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_Sach
{
    public partial class SachCreateOrUpdate : Form
    {
        ISachService sachService = new SachService();
        ITheLoaiService _iTheLoaiService = new TheLoaiService();
        ITacGiaService tacGiaService = new TacGiaService();
        INhaPhanPhoiService nhaPhanPhoiService = new NhaPhanPhoiService();
        int ID_CapNhat = 0;
        public string TenSachYC { set; get; }
        public string TacGiaYC { set;get; }
        public SachCreateOrUpdate()
        {
            InitializeComponent();
        }


        public SachCreateOrUpdate(int ID) : this()
        {
            this.ID_CapNhat = ID;
        }
        public SachCreateOrUpdate(string tenSachYC) : this()
        {
            txtTenSach.Text = tenSachYC;
        }

        public SachCreateOrUpdate(string tenSachYC, string tacGiaYc) : this(tenSachYC)
        {
            //txtTenTacGia.Text = tacGiaYc;
        }

        private async void SachCreateOrUpdate_Load(object sender, EventArgs e)
        {
            loadDuLieuComboBox();

            if (ID_CapNhat != 0)
            {
                var sachCapNhat = await sachService.GetById(ID_CapNhat);
                txtTenSach.Text = sachCapNhat.TenSach;
                txtMaTacGia.Text = sachCapNhat.ID_TacGia != null ? sachCapNhat.TacGia.ID.ToString() : string.Empty;
                txtMaNhaPhanPhoi.Text = sachCapNhat.ID_NhaPhanPhoi != null ? sachCapNhat.NhaPhanPhoi.ID.ToString() : string.Empty;
                txtSoLuong.Text = sachCapNhat.SoLuong.ToString();
                txtDonGia.Text = sachCapNhat.DonGia.ToString();
                ptbAnhSach.Image = XuLyAnh.ByteArrayToImage(sachCapNhat.AnhSach);
                txtMoTa.Text = sachCapNhat.MoTa.ToString();
                var listTheLoai = sachCapNhat.TheLoais.Select(x => x.TenTheLoai).ToList();
                foreach (CheckedListBoxItem item in cbbTheLoai.Properties.GetItems().Cast<CheckedListBoxItem>())
                {
                    string giaTri = item.Value.ToString();
                    item.CheckState = listTheLoai.Contains(giaTri) ? CheckState.Checked : CheckState.Unchecked;
                }
            }
        }

        private void loadDuLieuComboBox()
        {
            var listTheLoai = _iTheLoaiService.QueryFilterDto().Select(x => x.TenTheLoai).ToList();
            cbbTheLoai.Properties.DataSource = listTheLoai;
            var listNhaPhanPhoi = nhaPhanPhoiService.QueryFilterDto().Select(x => x.NhaPhanPhoiId).ToList();
            txtMaNhaPhanPhoi.Properties.Items.AddRange(listNhaPhanPhoi);
            var listTacGia = tacGiaService.QueryFilterDto().Select(x => x.TacGiaId).ToList();
            txtMaTacGia.Properties.Items.AddRange(listTacGia);

        }



        private void txtMaNhaPhanPhoi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNhaPhanPhoi.Text))
            {
                var TenNhaPhanPhoi = nhaPhanPhoiService.QueryFilter().FirstOrDefault(x => x.ID == txtMaNhaPhanPhoi.Text);
                if (TenNhaPhanPhoi != null)
                {
                    txtTenNhaPhanPhoi.Text = TenNhaPhanPhoi.TenNhaPhanPhoi;
                }
                else
                {
                    txtTenNhaPhanPhoi.Text = "Không tồn tại trong CSDL";
                }
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtTenSach.Text) 
                     && string.IsNullOrEmpty(dtpNgayXB.Text) && string.IsNullOrEmpty(txtDonGia.Text) &&
                    string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng điền đúng định dạng");
                }
                if (string.IsNullOrEmpty(errLoi.GetError(txtTenSach))  
                 && string.IsNullOrEmpty(errLoi.GetError(dtpNgayXB)) && string.IsNullOrEmpty(errLoi.GetError(txtDonGia)) &&
                string.IsNullOrEmpty(errLoi.GetError(txtSoLuong)))

                {
                    

                    
                    var sachCRUD = new SachCreateInput
                    {
                        TenSach = txtTenSach.Text,
                        
                        NgayXb = dtpNgayXB.DateTime,
                        SoLuong = Int32.Parse(txtSoLuong.Text),
                        DonGia = float.Parse(txtDonGia.Text),
                        ListTenTheLoai = cbbTheLoai.Properties.Items
                                                            .Where(item => item.CheckState == CheckState.Checked)
                                                            .Select(item => item.Value.ToString())
                                                            .ToList(),
                        AnhSach = XuLyAnh.ImageToByteArray(ptbAnhSach.Image),
                        MoTa = txtMoTa.Text
                    };
                    if (!string.IsNullOrEmpty(txtMaTacGia.Text))
                    {
                        sachCRUD.TacGiaId =await tacGiaService.CreateTacGia(new TacGiaCreateInput
                        {
                            TenTacGia = txtTenTacGia?.Text
                        });
                    }
                    if (!string.IsNullOrEmpty(txtMaNhaPhanPhoi.Text))
                    {
                        sachCRUD.NhaPhanPhoiId = await nhaPhanPhoiService.CreateNhaPhanPhoi(new NhaPhanPhoiCreateInput
                        {
                            TenNhaPhanPhoi = txtTenNhaPhanPhoi?.Text
                        }); ;
                    }
                    if (ID_CapNhat != 0)
                    {
                        var sachCapNhat = sachService.UpdateSach(ID_CapNhat, sachCRUD);
                        MessageBox.Show("Cập Nhật Thành Công Vào Trong CSDL");
                    }
                    else
                    {
                        var sachCapNhat = sachService.CreateSach(sachCRUD);
                        MessageBox.Show("Thêm Thành Công Vào Trong CSDL");
                    }
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng điền đúng định dạng");
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaTacGia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaTacGia.Text))
            {
                int maTacGia = Int32.Parse(txtMaTacGia.Text);
                var TenTacGia = tacGiaService.QueryFilter().FirstOrDefault(x => x.ID == maTacGia);
                if (TenTacGia != null)
                {
                    txtTenTacGia.Text = TenTacGia.TenTacGia;
                }
                else
                {
                    txtTenTacGia.Text = "Không tồn tại trong CSDL";
                }
            }
        }
        #region Validate
        private void txtTenSach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text))
                errLoi.SetError(txtTenSach, "Tên sách không được để trống");
            else errLoi.ClearErrors();
        }

      

        private void txtTenTacGia_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dtpNgayXB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpNgayXB.Text))
                errLoi.SetError(dtpNgayXB, "Ngày Xuất Bản không được để trống");
            else
                errLoi.ClearErrors();
        }

        private void txtSoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoLuong.Value < 0)
                errLoi.SetError(txtSoLuong, "Số lượng không được nhỏ hơn 0");
            else errLoi.ClearErrors();
        }

        private void txtDonGia_Validating(object sender, CancelEventArgs e)
        {
            if (txtDonGia.Value < 0)
                errLoi.SetError(txtDonGia, "Đơn giá không được nhỏ hơn 0");
            else
                errLoi.ClearErrors();
        }
        #endregion

        private void txtTenTacGia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenTacGia.Text))
            {
                var maTacGia = tacGiaService.QueryFilter().FirstOrDefault(x => x.TenTacGia.ToLower().Equals(txtTenTacGia.Text.ToLower()));
                txtMaTacGia.Text = maTacGia?.ID.ToString() ?? string.Empty;
            }

        }

        private void txtTenNhaPhanPhoi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenTacGia.Text))
            {
                var maNhaPhanPhoi = nhaPhanPhoiService.QueryFilter().FirstOrDefault(x => x.TenNhaPhanPhoi.ToLower().Equals(txtTenNhaPhanPhoi.Text.ToLower()));
                txtMaNhaPhanPhoi.Text = maNhaPhanPhoi?.ID ?? string.Empty;
            }
        }
    }
    public class XuLyAnh
    {
        public XuLyAnh() { }
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Chọn định dạng ảnh tùy theo yêu cầu
                return ms.ToArray();
            }
        }
        public static Image ByteArrayToImage(byte[] img)
        {
            if (img == null)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(img))
            {
                ImageConverter imageConverter = new ImageConverter();
                Image image = (Image)imageConverter.ConvertFrom(img);
                return image;
            }
        }
    }
}