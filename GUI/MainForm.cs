using DevExpress.XtraBars;
using GUI.Form_DocGia;
using GUI.Form_NhanVien;
using GUI.Form_NhaPhanPhoi;
using GUI.Form_PhieuMuon;
using GUI.Form_Sach;
using GUI.Form_TacGia;
using GUI.Form_TheLoai;
using GUI.Login;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public int RoleId = 1;
        public int ID_Login = Login_form.User_Id;
        
        public MainForm()
        {
            
            InitializeComponent();
        }

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
        private void btnSach_Click(object sender, EventArgs e)
        {
        
        }

        
        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

      

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(RoleId != 1)
            {
                btnNhanVien.Visible = false;
            }
            
        }
        private void btnKhoSach_Click(object sender, EventArgs e)
        {
            
            showUserControl(new Sach_DanhSach2());
        }

       

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            showUserControl(new TacGia_DanhSach2());
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            showUserControl(new TheLoai_DanhSach2());
        }

        private void btnNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            showUserControl(new NhaPhanPhoi_DanhSach2());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            showUserControl(new DocGia_DanhSach2());
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            showUserControl(new PhieuMuon_DanhSach2());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showUserControl(new NhanVien_DanhSach2());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //showChildForm(new NhanVien_ThongTinTaiKhoan(1));
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (Owner != null && !Owner.Disposing && !Owner.IsDisposed && !Owner.Visible)
                Owner.Show();
            this.Close();
        }
    }
}
