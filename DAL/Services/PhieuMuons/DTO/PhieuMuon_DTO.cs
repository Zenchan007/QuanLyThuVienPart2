using DAL.Model;
using DAL.Services.PhieuMuon_Sachs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.PhieuMuons.DTO
{
    public class PhieuMuon_DTO
    {
      
        public int PhieuMuonId { get; set; }
        public string TenNhanVien { get; set; }
        public int? NhanVienId { set; get; }
        public string TenDocGia { set; get; }
        public int DocGiaId { set; get; }
        public DateTime? NgayMuon { set; get; }
        public DateTime? NgayHenTra { set; get; }
        public DateTime? NgayTra { set; get; }
        public List<Model.PhieuMuon_Sachs> ListSachMuon { get; set; }
        public int TrangThaiId { get; set; }
        public string TenTrangThai { set; get; }
        public string GhiChu { set; get; }
        public double TienCoc { set; get; }
    }
}
