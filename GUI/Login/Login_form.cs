﻿using DAL.Services.NhanVien;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Login
{
    public partial class Login_form : DevExpress.XtraEditors.XtraForm
    {
        INhanVienService _service = new NhanVienService();
        public static int Role_Id { get; set; }
        public static int User_Id { get; set; }
        public Login_form()
        {
            InitializeComponent();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitFormLogin), true, true, true);
            SplashScreenManager.Default.SetWaitFormCaption("Đang đăng nhập...");
            SplashScreenManager.Default.SetWaitFormDescription("Vui Lòng Chờ!");
            if (!errMatKhau.HasErrors && !errMatKhau.HasErrors)
            {
                var TaiKhoan = await _service.GetByTenDangNhap(txtTenDangNhap.Text);
                if (TaiKhoan != null)
                {
                    if (TaiKhoan.MatKhau == txtMatKhau.Text)
                    {
                        Properties.Settings.Default.TenDangNhap = txtTenDangNhap.Text;
                        Properties.Settings.Default.MatKhau = txtMatKhau.Text;
                        Properties.Settings.Default.Remember = checkRemember.Checked;
                        Properties.Settings.Default.Save();
                        Role_Id = TaiKhoan.ID_Role ?? 0;
                        User_Id = TaiKhoan.ID;
                        var MainForm = new MForm();
                        MainForm.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        errMatKhau.SetError(txtMatKhau, "Sai mật khẩu");
                    }
                }
                else
                {
                    errTenDangNhap.SetError(txtTenDangNhap, "Tên Đăng Nhập Không Đúng. Vui lòng kiểm tra lại");
                }
            }
            SplashScreenManager.CloseForm();
        }
        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                errTenDangNhap.SetError(txtTenDangNhap, "Vui lòng điền");
            }
            else
            {
                errTenDangNhap.ClearErrors();
            }
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                errMatKhau.SetError(txtMatKhau, "Vui lòng điền");
            }
            else
            {
                errMatKhau.ClearErrors();
            }
        }
        private void Login_form_Load(object sender, EventArgs e)
        {
            errMatKhau.SetIconAlignment(txtMatKhau, ErrorIconAlignment.MiddleRight);
            errTenDangNhap.SetIconAlignment(txtTenDangNhap, ErrorIconAlignment.MiddleRight);
            if (Properties.Settings.Default.Remember)
            {
                checkRemember.Checked = true;
                txtTenDangNhap.Text = Properties.Settings.Default.TenDangNhap ?? string.Empty;
                txtMatKhau.Text = Properties.Settings.Default.MatKhau ?? string.Empty;
            }
        }
    }

}