using DAL.Model;
using DAL.Services.HoaDons.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.HoaDons
{
    public class HoaDon_Service : IHoaDon_Service
    {
        #region Khai báo
        QuanLyThuVienEntities _db;
        HoaDon_Service()
        {
            _db = new QuanLyThuVienEntities();
        }
        #endregion
        #region crud
        public async Task<int> CreateHoaDon(HoaDonCreateInput input)
        {
            var entity = await MapperCreateInputToEntity(input, new HoaDon());
            _db.HoaDons.Add(entity);
            return _db.SaveChanges();
        }

        public async Task<bool> UpdateHoaDon(int HoaDonId, HoaDonCreateInput input)
        {
            var entity = await GetById(HoaDonId);
            entity = await MapperCreateInputToEntity(input, entity);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteHoaDonById(int HoaDonId)
        {
            var entity = await GetById(HoaDonId);
            if (entity != null)
            {
                _db.HoaDons.Remove(entity);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<Model.HoaDon> GetById(int id)
        {
            return await QueryFilter().FirstOrDefaultAsync(p => p.ID == id) ?? throw new Exception($"Không tìm thấy nhân viên có id {id}.");
        }
        public async Task<HoaDon_DTO> GetByIdDto(int id)
        {
            return await QueryFilterDto().FirstOrDefaultAsync(p => p.HoaDonId == id) ?? throw new Exception($"Không tìm thấy nhân viên có id {id}.");
        }
        #endregion
        #region query
        public IQueryable<Model.HoaDon> QueryFilter(HoaDonFilterInput input = null)
        {
            var query = _db.HoaDons.AsQueryable();
           
            return query;
        }
        public IQueryable<HoaDon_DTO> QueryFilterDto(HoaDonFilterInput input = null)
        {
            try
            {
                var query = from q in QueryFilter(input)
                            select new HoaDon_DTO
                            {
                                HoaDonId = q.ID,
                                PhieuMuonId = q.ID_PhieuMuon,
                                TienThu = q.TienThu ?? 0,
                                GhiChu = q.GhiChu,
                                NgayThu = q.NgayThu
                            };
                return query;
            }
            catch
            {
                throw new Exception("Lỗi chỗ QueryFilter DTO");
            }
        }
        #endregion
        public async Task<HoaDon> MapperCreateInputToEntity(HoaDonCreateInput input, HoaDon entity)
        {
            await Task.Run(() =>
            {
                entity.ID_PhieuMuon = input.PhieuMuonId;
                entity.GhiChu = input.GhiChu;
                entity.TienThu = input.TienThu;
                entity.NgayThu = input.NgayThu;  
            });
            return entity;
        }
    }
}
