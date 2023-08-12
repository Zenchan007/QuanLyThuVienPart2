using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.NhanVien.DTO
{
    public class NhanVienFilterInput
    {
        public int? Id { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi {get; set;}
        public int? VaiTroId { get; set;}
        public string TenVaiTro { get; internal set; }
    }
}
