using DAL.Services.DocGias;
using DAL.Services.DocGias.DTO;
using DAL.Services.TheLoais.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_DocGia
{
    public partial class DocGia_DanhSach2 : UserControl
    {
        IDocGiaService docGiaService = new DocGiaService();
        public DocGia_DanhSach2()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void DocGia_DanhSach2_Load(object sender, EventArgs e)
        {
            showDuLieuDocGia().ContinueWith(x =>
           {
               if (x.IsFaulted)
               {
                   MessageBox.Show("Lỗi show Dữ liệu");
               }
           });
        }

        private async Task showDuLieuDocGia()
        {
            var danhSach = await docGiaService.QueryFilterDto().ToListAsync();
            BindingList<DocGia_DTO> listDocGia = new BindingList<DocGia_DTO>(danhSach);
            gridDocGia.DataSource = listDocGia;
            dtgDocGia.OptionsBehavior.Editable = false;
            dtgDocGia.OptionsView.ColumnAutoWidth = true;
            dtgDocGia.BestFitColumns();
        }
    }
}
