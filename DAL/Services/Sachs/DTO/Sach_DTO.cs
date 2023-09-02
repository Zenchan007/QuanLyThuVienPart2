using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.Sachs.DTO
{
    public class Sach_DTO
    {
        public int SachId { set; get; }
        public string TenSach { get; set; }

        public string TenTacGia { set; get; }
        public string NhaPhanPhoiId { set; get; }
        public string TenNhaPhanPhoi { set; get; }
        public DateTime NgayXb { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public byte[] AnhSach { get; set; }
        public List<string> TheLoais { get; set; }

    }
}