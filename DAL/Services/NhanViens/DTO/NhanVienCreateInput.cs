﻿using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.NhanVien.DTO
{
    public class NhanVienCreateInput
    {
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai {set;get;}
        public int VaiTro { get; set; }
        public string TaiKhoan { set; get; }
        public string MatKhau { set; get; }
        public string CCCD { get; set; }
    }
}
