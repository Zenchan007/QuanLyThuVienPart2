using DAL.Services.PhieuMuons;
using DAL.Services.Sachs.DTO;
using DAL.Services.TacGias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_BaoCao
{
    public partial class BaoCao : Form
    {
        ISachService sachService = new SachService();
        IPhieuMuonService phieuMuonService = new PhieuMuonService();
        ITacGiaService tacGiaService = new TacGiaService();

        public BaoCao()
        {
            InitializeComponent();
        }

        private async void BaoCao_Load(object sender, EventArgs e)
        {
            var sachConLai = await sachService.SachTrongKho();
            var sachChoMuon = await phieuMuonService.TongSachMuon();
            var tongSach = sachConLai + sachChoMuon;
            lblTongSach.Text = (sachConLai + sachChoMuon).ToString();
        }
    }
}
