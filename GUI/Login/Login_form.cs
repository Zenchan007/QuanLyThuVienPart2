using DAL.Services.NhanVien;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
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
        INhanVienService _service;
        public static int Role_Id { get; set; }
        public static int User_Id { get; set; }
        public Login_form()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            _service = new NhanVienService();
            SplashScreenManager.ShowForm(this, typeof(WaitFormLogin), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang đăng nhập...");
            SplashScreenManager.Default.SetWaitFormDescription("Vui lòng chờ!");
            if (!errMatKhau.HasErrors && !errMatKhau.HasErrors)
            {
                var TaiKhoan =  _service.GetByTenDangNhap(txtTenDangNhap.Text).ContinueWith(taikhoan =>
                {
                    if (taikhoan.IsFaulted || taikhoan.IsCanceled) {
                        MessageBox.Show("Không lấy được tên đăng nhập");
                    }else if (taikhoan.IsCompleted)
                    {
                        if (taikhoan.Result != null)
                        {
                            if (taikhoan.Result.MatKhau == txtMatKhau.Text)
                            {
                                Properties.Settings.Default.TenDangNhap = txtTenDangNhap.Text;
                                Properties.Settings.Default.MatKhau = txtMatKhau.Text;
                                Properties.Settings.Default.Remember = checkRemember.Checked;
                                Properties.Settings.Default.Save();
                                Role_Id = taikhoan.Result.ID_Role ?? 0;
                                User_Id = taikhoan.Result.ID;
                                MForm MainForm = null;

                                // Sử dụng Invoke để đảm bảo MainForm được hiển thị trên luồng UI chính
                                this.Invoke((Action)(() =>
                                {
                                    MainForm = new MForm();
                                    MainForm.Show(this);
                                    this.Hide();
                                }));
                               
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

                });
               
            }
            if(SplashScreenManager.Default != null)
            {
                if (SplashScreenManager.Default.IsSplashFormVisible)
                {
                    SplashScreenManager.CloseForm();
                }
            }
            
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