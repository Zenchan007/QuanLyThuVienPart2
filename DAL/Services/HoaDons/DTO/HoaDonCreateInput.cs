using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.HoaDons.DTO
{
    public class HoaDonCreateInput
    {
        public int PhieuMuonId { set; get; }
        public DateTime NgayThu { set; get; }
        public double TienThu { set; get; }
        public string GhiChu { set; get; }
    }
}
