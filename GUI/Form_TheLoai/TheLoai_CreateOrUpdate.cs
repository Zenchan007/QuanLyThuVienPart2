using DAL.Services.TheLoais;
using DAL.Services.TheLoais.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_TheLoai
{
    public partial class TheLoai_CreateOrUpdate : Form
    {
        public TheLoai_CreateOrUpdate()
        {
            InitializeComponent();
        }
        ITheLoaiService loaiService = new TheLoaiService();

        public string ID_CapNhat;
        public TheLoai_CreateOrUpdate(string ID) : this()
        {
            this.ID_CapNhat = ID;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTheLoai.Text) && string.IsNullOrEmpty(txtTenTheLoai.Text))
                    throw new Exception("Vui Lòng Điền Đầy Đủ Thông Tin Theo Đúng Định Dạng");
                if (!string.IsNullOrEmpty(errLoi.GetError(txtMaTheLoai)) && !string.IsNullOrEmpty(errLoi.GetError(txtTenTheLoai)))
                {
                    throw new Exception("Vui Lòng Điền Đầy Đủ Thông Tin Theo Đúng Định Dạng");
                }
                else
                {

                    var theLoai = new TheLoaiCreateInput
                    {
                        TheLoaiId = txtMaTheLoai.Text,
                        TenTheLoai = txtTenTheLoai.Text,
                        MoTa = txtMoTa.Text,
                    };
                    if (string.IsNullOrEmpty(ID_CapNhat))
                    {
                        var tonTaiIdTheLoai = await loaiService.CheckTonTaiIdTheLoai(txtMaTheLoai.Text);

                        if (tonTaiIdTheLoai)
                        {
                            MessageBox.Show("Mã Thể Loại Đã Được Dùng. Vui Lòng Chọn Mã Khác");
                        }
                        else
                        {
                            await loaiService.CreateTheLoai(theLoai);
                            MessageBox.Show("Thêm Mới Thành Công Thể Loại Vào Trong CSDL");
                            this.Close();
                        }
                    }
                    else
                    {
                        txtMaTheLoai.ReadOnly = true;
                        var theLoaiCapNhat = loaiService.UpdateTheLoai(ID_CapNhat, theLoai);
                        MessageBox.Show("Cập Nhật Thể Loại Thành Công");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Trace.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        private async void TheLoai_CreateOrUpdate_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_CapNhat))
            {
                txtMaTheLoai.Enabled = false;
                var theLoaiCapNhat = await loaiService.GetById(ID_CapNhat);
                txtMaTheLoai.Text = ID_CapNhat;
                txtTenTheLoai.Text = theLoaiCapNhat.TenTheLoai;
                txtMoTa.Text = theLoaiCapNhat.MoTaThem;
            }
        }

        private async void txtMaTheLoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTheLoai.Text))
            {
                errLoi.SetError(txtMaTheLoai, "Vui lòng điền Mã Thể Loại");

            }
            else
            {
                var tonTaiIdTheLoai =await loaiService.CheckTonTaiIdTheLoai(txtMaTheLoai.Text);
                if (tonTaiIdTheLoai) errLoi.SetError(txtMaTheLoai, "Mã Thể Loại Đã Được Sử Dụng");
                else errLoi.ClearErrors();
            }
        }

        private async void txtTenTheLoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTheLoai.Text))
            {
                errLoi.SetError(txtMaTheLoai, "Vui lòng điền Tên Thể Loại");

            }
            else
            {
                var tonTaiTenTheLoai = await loaiService.CheckTonTaiTenTheLoai(txtTenTheLoai.Text);
                if (tonTaiTenTheLoai) errLoi.SetError(txtMaTheLoai, "Tên Thể Loại Đã Được Sử Dụng");
                else errLoi.ClearErrors();
            }
        }
    }
}
