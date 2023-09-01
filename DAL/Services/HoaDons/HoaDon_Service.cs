using DAL.Services.NhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.HoaDons
{
    public class HoaDon_Service
    {
        public IQueryable<Model.NhanVien> QueryFilter(NhanVienFilterInput input = null)
        {
            var query = _db.NhanViens.AsQueryable();
            if (input != null)
            {
                if (!string.IsNullOrEmpty(input.TenNhanVien))
                {
                    var lower = input.TenNhanVien.Trim().ToLower();
                    query = query.Where(p => p.TenNhanVien.ToLower().Contains(lower));

                }
                if (!string.IsNullOrEmpty(input.DiaChi))
                {
                    var lower = input.DiaChi.Trim().ToLower();
                    query = query.Where(p => p.DiaChi.ToLower().Contains(lower));

                }
                if (!string.IsNullOrEmpty(input.SoDienThoai))
                {
                    var lower = input.SoDienThoai.Trim().ToLower();
                    query = query.Where(p => p.SoDienThoai.ToLower().Contains(lower));
                }
                if (!string.IsNullOrEmpty(input.CCCD))
                {
                    var lower = input.CCCD.Trim().ToLower();
                    query = query.Where(p => p.CCCD.ToLower().Contains(lower));
                }
                if (input.TenVaiTro != null && input != null)
                {
                    query = query.Where(p => p.VaiTro.TenRole == input.TenVaiTro);
                }
            }
            return query;
        }
        public IQueryable<NhanVien_DTO> QueryFilterDto(NhanVienFilterInput input = null)
        {
            try
            {
                var query = from q in QueryFilter(input)
                            select new NhanVien_DTO
                            {
                                TenNhanVien = q.TenNhanVien,
                                DiaChi = q.DiaChi,
                                SoDienThoai = q.SoDienThoai,
                                CCCD = q.CCCD,
                                TaiKhoan = q.TaiKhoan,
                                MatKhau = q.MatKhau,
                                VaiTro = q.VaiTro.ID,
                                NhanVienId = q.ID,
                                NgaySinh = q.NgaySinh,
                                GioiTinh = q.GioiTinh,
                                NgayVaoLam = q.NgayVaoLam,
                                AnhNhanVien = q.AnhDaiDien,
                                TenVaiTro = q.VaiTro.TenRole
                            };
                return query;
            }
            catch
            {
                throw new Exception("Lỗi chỗ QueryFilter DTO");
            }
        }
    }
}
