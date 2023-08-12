using DAL.Model;
using DAL.Services.PhieuMuon_Sachs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.PhieuMuons.DTO
{
    public class PhieuMuonCreateOrUpdateInput
    {      
        public int NhanVienId { get; internal set; }
        public int DocGiaId { get; internal set; }
        public DateTime NgayMuon { set; get; }
        public DateTime NgayTra { set; get; }
        public string GhiChu { get; set; }
        public List<PhieuMuon_SachCreateInput> ListSachMuon { set; get; }
    }
    
}
