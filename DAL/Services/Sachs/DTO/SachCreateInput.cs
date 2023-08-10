using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.Sachs.DTO
{
    public class SachCreateInput
    {
        public string TenSach { get; set; }
        public DateTime NgayXb { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public List<int> listIdTheLoai { get; set; }
        public HashSet<TheLoai> TheLoais { set; get; }
        public int TacGiaId { get; set; }
        public string NhaPhanPhoiId { get; set; }
        public byte[] AnhSach { get; set; }
    }
}
