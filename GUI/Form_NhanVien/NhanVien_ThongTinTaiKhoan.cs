﻿using DAL.Services.NhanVien;
using DAL.Services.NhanVien.DTO;
using DAL.Services.VaiTros;
using DevExpress.XtraEditors;
using GUI.Form_Sach;
using GUI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_NhanVien
{
    public partial class NhanVien_ThongTinTaiKhoan : Form
    {
        #region Khai báo
        public int Role_Id = Login_form.Role_Id;
        int ID_CapNhat = 0;
        INhanVienService nhanVienSerVice = new NhanVienService();
        IVaiTroService vaiTroService = new VaiTroService();
        #endregion
        public NhanVien_ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        public NhanVien_ThongTinTaiKhoan(int Id):this()
        {
            ID_CapNhat = Id;
        }
        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text))
                    throw new Exception("Vui lòng điền đầy đủ thông tin");
                if (string.IsNullOrEmpty(errLoi.GetError(txtTenDangNhap)) && string.IsNullOrEmpty(errLoi.GetError(txtTenNhanVien)))
                {
                    NhanVienCreateInput nhanVien = new NhanVienCreateInput()
                    {
                        TenNhanVien = txtTenNhanVien.Text,
                        CCCD = txtCCCD.Text,
                        DiaChi = txtDiaChi.Text,
                        AnhNhanVien = XuLyAnh.ImageToByteArray(ptbAnhNhanVien.Image),
                        GioiTinh = cbbGioiTinh.Text,
                        SoDienThoai = txtSoDienThoai.Text,
                        VaiTroId = await vaiTroService.GetIdVaiTroTheoTen(txtVaiTro.Text),
                    };
                    if (!string.IsNullOrEmpty(dtpNgaySinh.Text))
                    {
                        nhanVien.NgaySinh = dtpNgaySinh.DateTime;
                    }
                    if (!string.IsNullOrEmpty(dtpNgayVaoLam.Text))
                    {
                        nhanVien.NgayVaoLam = dtpNgayVaoLam.DateTime;
                    }
                    var checkTonTaiTenDangNhap = await nhanVienSerVice.CheckTonTaiTenDangNhap(txtTenDangNhap.Text);
                    if (checkTonTaiTenDangNhap && ID_CapNhat == 0)
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại, vui lòng chọn một tên đăng nhập mới");
                    }
                    else
                    {
                        nhanVien.TaiKhoan = txtTenDangNhap.Text;
                        if (ID_CapNhat == 0) //Thêm Mới Nhân Viên
                        {
                            
                            nhanVien.MatKhau = txtMatKhauHienTai.Text;
                            await nhanVienSerVice.CreateNhanVien(nhanVien);
                            MessageBox.Show("Thêm Thành Công Nhân Viên Vào Trong CSDL");
                            this.Close();
                        }
                        else//Cập Nhật NhânViên
                        {
                            
                            var nhanVienX = await nhanVienSerVice.GetById(ID_CapNhat);
                            if (string.IsNullOrEmpty(txtMatKhauHienTai.Text) && string.IsNullOrEmpty(txtMatKhauMoi.Text) && string.IsNullOrEmpty(txtXacNhanMatKhauMoi.Text))
                            {
                                //Nhân Viên Cập Nhật Thông Tin không Cập Nhật Mật Khẩu
                                nhanVien.MatKhau = nhanVienX.MatKhau;
                                await nhanVienSerVice.UpdateNhanVien(ID_CapNhat, nhanVien);
                                MessageBox.Show("Cập nhật thành công thông tin nhân viên");
                                this.Close();
                            }
                            else
                            {
                                //Nhân Viên Cập Nhật Thông Tin Và Mật Khẩu
                                if (txtMatKhauHienTai.Text == nhanVienX.MatKhau)
                                {
                                    
                                    if (txtMatKhauMoi.Text == txtXacNhanMatKhauMoi.Text)
                                    {
                                        nhanVien.MatKhau = txtMatKhauMoi.Text;
                                        await nhanVienSerVice.UpdateNhanVien(ID_CapNhat, nhanVien);
                                        MessageBox.Show("Cập nhật thành công thông tin nhân viên");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Mật khẩu xác nhận không đúng! Vui lòng kiểm tra lại");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu không đúng! Vui lòng kiểm tra lại");
                                }
                            }
                        }
                       
                    }
                }
                else
                {
                    throw new Exception("Vui Lòng Điền Đúng Và Đầy Đủ Thông TIn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void NhanVien_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            
            Role_Id = Login_form.Role_Id;
            if(Role_Id != 1)
            {
                 controlVaiTro.HideToCustomization();
            }
            if(ID_CapNhat == 0)
            {
                controlMatKhauHienTai.Text = "Mật Khẩu";
                conTrolMatKhauMoi.HideToCustomization();
                controlXacNhanMatKhauMoi.HideToCustomization();
            }
            else
            {
                var nhanVien = await nhanVienSerVice.GetById(ID_CapNhat);
                txtTenNhanVien.Text = nhanVien.TenNhanVien;
                dtpNgaySinh.Text = nhanVien?.NgaySinh.ToString() ?? string.Empty;
                dtpNgayVaoLam.Text = nhanVien?.NgayVaoLam.ToString() ?? string.Empty;
                txtSoDienThoai.Text = nhanVien?.SoDienThoai.ToString() ?? string.Empty;
                txtCCCD.Text = nhanVien.CCCD ?? string.Empty;
                txtDiaChi.Text = nhanVien.DiaChi ?? string.Empty;
                ptbAnhNhanVien.Image = XuLyAnh.ByteArrayToImage(nhanVien.AnhDaiDien);
                cbbGioiTinh.Text = nhanVien.GioiTinh ?? string.Empty;
                txtTenDangNhap.Text = nhanVien.TaiKhoan ??string.Empty;
                txtVaiTro.Text = nhanVien.VaiTro.TenRole;
            }
        }

        private void txtTenNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                errLoi.SetError(txtTenNhanVien, "Vui lòng điền Tên Nhân Viên");
            }
            else errLoi.ClearErrors();
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                errLoi.SetError(txtTenDangNhap, "Vui lòng điền Tên Đăng Nhập");
            }
            else errLoi.ClearErrors();
        }
    }
}
