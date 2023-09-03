using DAL.Services.NhanVien;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;
using GUI.Form_BaoCao;
using GUI.Form_DocGia;
using GUI.Form_NhanVien;
using GUI.Form_NhaPhanPhoi;
using GUI.Form_PhieuMuon;
using GUI.Form_Sach;
using GUI.Form_SachYeuCau;
using GUI.Form_TacGia;
using GUI.Form_TheLoai;
using GUI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MForm : DevExpress.XtraEditors.XtraForm
    {
        public int RoleId = Login_form.Role_Id;
        public int ID_Login = Login_form.User_Id;
        INhanVienService nhanVienService;
        UserControl currentControl;

        public void showUserControl(UserControl control)
        {
            if (currentControl == null)
            {
                currentControl = control;
                control.Dock = DockStyle.Fill;
                Container.Controls.Add(control);
                control.BringToFront();
            }
            else if (currentControl != control)
            {
                currentControl.Hide(); // Ẩn user control hiện tại
                Container.Controls.Remove(currentControl); // Loại bỏ user control hiện tại khỏi Container
                currentControl.Dispose(); // Giải phóng tài nguyên của user control hiện tại

                currentControl = control;
                control.Dock = DockStyle.Fill;
                Container.Controls.Add(control);
                control.BringToFront();
            }
        }
        public MForm()
        {
            InitializeComponent();
        }

        #region link button
        private void btnKhoSach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showUserControl(new Sach_DanhSach());
        }



        private void btnSachYeuCau_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new SachYeuCauDanhSach());
        }

        private void btnTheLoai_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new TheLoai_DanhSach());
        }

        private void btnTacGia_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new TacGia_DanhSach());
        }

        private void btnDocGia_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new DocGia_DanhSach());
        }

        private void btnPhieuMuon_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new PhieuMuon_DanhSach2());
        }

        private void btnNhaPhanPhoi_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new NhaPhanPhoi_DanhSach());
        }
        private void btnNhanVien_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new NhanVien_DanhSach());
        }
        #endregion


        private void btnBaoCao_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new BaoCaoBieuDo());
            this.WindowState = FormWindowState.Maximized;
        }
        private string[] imageFiles;
        private int currentImageIndex = 0;
        private void MForm_Load(object sender, EventArgs e)
        {
            nhanVienService = new NhanVienService();
            if (RoleId != 1)
            {
                navNhanVien.Visible = false;
            }
            var nhanVien = nhanVienService.QueryFilterDto().FirstOrDefault(x => x.NhanVienId == ID_Login);
            btnXinChao.Text = "Xin chào " + nhanVien?.TenNhanVien.ToString() ?? string.Empty;
            pcAvatar.Image = XuLyAnh.ByteArrayToImage(nhanVien?.AnhNhanVien);
            string imageDirectory = @"F:\ChuyenDe\QuanLyThuVien\GUI\Resources\AnhLoad";
            imageFiles = Directory.GetFiles(imageDirectory, "*.jpg", SearchOption.TopDirectoryOnly)
                        .Concat(Directory.GetFiles(imageDirectory, "*.png", SearchOption.TopDirectoryOnly))
                        .ToArray();
            timerDoiAnh.Interval = 3000;
            timerDoiAnh.Start();
        }

        private void timerDoiAnh_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex < imageFiles.Length)
            {
                picMain.Image = new System.Drawing.Bitmap(imageFiles[currentImageIndex]);
                picMain.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
                currentImageIndex++;
            }
            else
            {

                currentImageIndex = 0;
            }
        }



        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            var thongTinCaNhan = new NhanVien_ThongTinTaiKhoan(ID_Login);
            thongTinCaNhan.Show(this);
            thongTinCaNhan.FormClosed += childFormClose;
        }

        private void childFormClose(object sender, FormClosedEventArgs e)
        {
            MForm_Load(null, null);
        }
        private async void btnDangXuat_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitFormLogin), true, true, true);
            SplashScreenManager.Default.SetWaitFormCaption("Đang đăng xuất...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ trong giây lát");
            await Task.Run(() =>
            {
                if (Owner != null && !Owner.Disposing && !Owner.IsDisposed && !Owner.Visible)
                {
                    Owner.Invoke((Action)(() =>
                    {
                        Owner.Show();
                    }));
                }
            });
            SplashScreenManager.CloseForm();
            this.Dispose();
            this.Close();
        }


    }
}