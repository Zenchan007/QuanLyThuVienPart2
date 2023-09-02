﻿using DAL.Services.NhanVien;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using GUI.Form_DocGia;
using GUI.Form_NhanVien;
using GUI.Form_NhaPhanPhoi;
using GUI.Form_PhieuMuon;
using GUI.Form_Sach;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MForm : DevExpress.XtraEditors.XtraForm
    {
        public int RoleId = 1;
        public int ID_Login = Login_form.User_Id;
        INhanVienService nhanVienService;
        UserControl currentControl;
        private string[] imageFiles;
        private int currentImageIndex = 0;
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
            showUserControl(new Sach_DanhSach2());
        }

       

        private void btnSachYeuCau_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void btnTheLoai_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new TheLoai_DanhSach2());
        }

        private void btnTacGia_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new TacGia_DanhSach2());
        }

        private void btnDocGia_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new DocGia_DanhSach2());
        }

        private void btnPhieuMuon_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new PhieuMuon_DanhSach2());
        }

        private void btnNhaPhanPhoi_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new NhaPhanPhoi_DanhSach2());
        }
        private void btnNhanVien_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            showUserControl(new NhanVien_DanhSach2());
        }
        #endregion


        private void btnBaoCao_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //showUserControl(new ());
        }

        private void MForm_Load(object sender, EventArgs e)
        {
            nhanVienService= new NhanVienService();
            if (RoleId != 1)
            {
                navNhanVien.Visible = false;
            }
            var nhanVien = nhanVienService.QueryFilterDto().FirstOrDefault(x => x.NhanVienId == ID_Login);
            btnXinChao.Text = "Xin chào " + nhanVien?.TenNhanVien.ToString() ?? string.Empty;
            pcAvatar.Image = XuLyAnh.ByteArrayToImage(nhanVien?.AnhNhanVien);
            string imageDirectory = @"F:\ChuyenDe\QuanLyThuVien\GUI\Resources\AnhLoad";
            imageFiles = Directory.GetFiles(imageDirectory, "*.jpg"); 
            timerDoiAnh.Interval = 5000;
            timerDoiAnh.Start();
        }

      
       


        private void simpleButton4_Click(object sender, EventArgs e)
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
        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            if (Owner != null && !Owner.Disposing && !Owner.IsDisposed && !Owner.Visible)
                Owner.Show();
            this.Close();
        }

        private void timerDoiAnh_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex < imageFiles.Length)
            {
                picMain.Image = new System.Drawing.Bitmap(imageFiles[currentImageIndex]);
                currentImageIndex++;
            }
            else
            {
                // Nếu đã hiển thị tất cả ảnh, quay lại ảnh đầu tiên
                currentImageIndex = 0;
            }
        }
    }
}