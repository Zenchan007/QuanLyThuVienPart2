using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.PhieuMuon_Sachs
{
    public class PhieuMuon_Sach_DTO
    {
        public int PhieuMuonId { set; get; }
        public int SachMuonId { set; get; }
        public string TenSachMuon { set; get; }
        public string TacGiaSachMuon { set; get; }
        public int SoLuongSachMuon { set; get; }
        public double DonGiaMuon { set; get; }
    }
}
