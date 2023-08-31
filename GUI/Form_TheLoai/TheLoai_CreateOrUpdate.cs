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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(errLoi.GetError(txtMaTheLoai)))
                {
                    throw new Exception("Vui Lòng Điền Đầy Đủ Thông Tin Theo Đúng Định Dạng");
                }
                else
                {

                    var theLoai = new TheLoaiCreateInput
                    {
                        Id = txtMaTheLoai.Text,
                        TenTheLoai = txtTenTheLoai.Text,
                        MoTa = txtMoTa.Text,
                    };
                    if (string.IsNullOrEmpty(ID_CapNhat))
                    {
                        var theLoaiMoi = loaiService.CreateTheLoai(theLoai);
                        MessageBox.Show("Thêm Mới Thể Loại Thành Công");
                    }
                    else
                    {
                        var theLoaiCapNhat = loaiService.UpdateTheLoai(ID_CapNhat, theLoai);
                        MessageBox.Show("Cập Nhật Thể Loại Thành Công");
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
                this.Close();
            }
        }

        private void TheLoai_CreateOrUpdate_Load(object sender, EventArgs e)
        {
            txtMaTheLoai_Validating(null, null);
            txtTenTheLoai_Validating(null, null);
            if (!string.IsNullOrEmpty(ID_CapNhat))
            {
                txtMaTheLoai.Enabled = false;
                var theLoaiCapNhat = loaiService.QueryFilter().FirstOrDefault(x => x.ID == ID_CapNhat);
                txtMaTheLoai.Text = ID_CapNhat;
                txtTenTheLoai.Text = theLoaiCapNhat.TenTheLoai;
                txtMoTa.Text = theLoaiCapNhat.MoTaThem;
            }
        }

        private void txtMaTheLoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTheLoai.Text))
            {
                errLoi.SetError(txtMaTheLoai, "Vui lòng điền Mã Thể Loại");
                var checkDB = loaiService.QueryFilter().Any(x => x.ID == txtMaTheLoai.Text);
                if (checkDB) errLoi.SetError(txtMaTheLoai, "Mã Thể Loại Đã Được Sử Dụng");
                else errLoi.ClearErrors();
            }
            else errLoi.ClearErrors();
        }

        private void txtTenTheLoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTheLoai.Text))
            {
                errLoi.SetError(txtMaTheLoai, "Vui lòng điền Tên Thể Loại");
                var checkDB = loaiService.QueryFilter().Any(x => x.TenTheLoai == txtTenTheLoai.Text);
                if (checkDB) errLoi.SetError(txtMaTheLoai, "Tên Thể Loại Đã Được Sử Dụng");
                else errLoi.ClearErrors();
            }
            else errLoi.ClearErrors();
        }
    }
}
