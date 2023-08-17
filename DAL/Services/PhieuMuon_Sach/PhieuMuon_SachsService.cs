using DAL.Common;
using DAL.Model;

using DAL.Services.PhieuMuon_Sachs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Services.PhieuMuon_PhieuMuon_Sachs;
using System.Data.Entity.Migrations;

namespace DAL.Services.PhieuMuon_Sach_Sachs
{
    public class PhieuMuon_SachsService : IPhieuMuon_SachsService

    {
        #region Khai báo
        public readonly QuanLyThuVienEntities _db;

        public PhieuMuon_SachsService()
        {
            _db = new QuanLyThuVienEntities();
        }
        #endregion

        #region Query and paging 
        public IQueryable<Model.PhieuMuon_Sachs> QueryFilter(PhieuMuon_SachFilterInput input = null)
        {
            var query = _db.PhieuMuon_Sachs.AsQueryable();

            if (!string.IsNullOrEmpty(input.PhieuMuonId))
            {
                var lower = input.PhieuMuonId.Trim().ToLower();
                query = query.Where(p => p.PhieuMuon.ID.ToLower().Contains(lower));
            }

            if (input.SachId != 0)
            {
                query = query.Where(p => p.Sach.ID == input.SachId);
            }
            return query;
        }

        public IQueryable<PhieuMuon_Sach_DTO> QueryFilterDto(PhieuMuon_SachFilterInput input = null)
        {
            try
            {
                var query = from q in QueryFilter(input)
                            from ss in _db.Saches.Where(s => q.ID_Sach == s.ID).Include(d => d.TheLoais)
                            select new PhieuMuon_Sach_DTO
                            {
                                PhieuMuonId = q.ID_PhieuMuon,
                                TenPhieuMuon = q.PhieuMuon.TenPhieuMuon,
                                TenSach = ss.TenSach,
                                listTheLoai = ss.TheLoais.ToList(),
                                TacGia = ss.TacGia.TenTacGia
                            };
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi ở chỗ queryDTO\n" + ex.Message);
            }
        }
        public async Task<PageResultDTO<PhieuMuon_Sach_DTO>> Paging(PagingInput<PhieuMuon_SachFilterInput> input = null)
        {
            var filtered = QueryFilterDto(input.Filter);
            var totalCount = await filtered.CountAsync();
            if (input.SkipCount > 0)
            {
                filtered = filtered.Skip(input.SkipCount);
            }
            if (input.MaxResultCount > 0)
            {
                filtered = filtered.Take(input.MaxResultCount);
            }
            var listData = await filtered.ToListAsync();
            return new PageResultDTO<PhieuMuon_Sach_DTO>(totalCount, listData);
        }
        #endregion


        private async Task<Model.PhieuMuon_Sachs> MapperCreateInputToEntity(PhieuMuon_SachCreateInput input, Model.PhieuMuon_Sachs entity)
        {
            await Task.Run(() =>
            {
                entity.ID_Sach = input.SachId;
                entity.SoLuong = input.SoLuong;
                entity.ID_PhieuMuon = input.PhieuMuonId;
            });
            return entity;
        }
        #region crud
        public async Task<int> CreatePhieuMuon_Sach(PhieuMuon_SachCreateInput input)
        {
            var entity = await MapperCreateInputToEntity(input, new Model.PhieuMuon_Sachs());
            _db.PhieuMuon_Sachs.Add(entity);
            var sachToUpdate = await _db.Saches.FirstOrDefaultAsync(x => x.ID == entity.ID_Sach);
            if (sachToUpdate != null)
            {
                sachToUpdate.SoLuong -= entity.SoLuong;
            }
            return await _db.SaveChangesAsync();
        }


        public async Task<int> UpdatePhieuMuon_Sach(PhieuMuon_SachFilterInput filter, PhieuMuon_SachCreateInput input)
        {
            var entity = await QueryFilter().FirstOrDefaultAsync(x => x.ID_Sach == filter.SachId && x.ID_PhieuMuon == filter.PhieuMuonId);
            entity = await MapperCreateInputToEntity(input, entity);
            return await _db.SaveChangesAsync();
        }

        async Task<int> IPhieuMuon_SachsService.DeletePhieuMuon_SachById(PhieuMuon_SachFilterInput filter)
        {
            var entity = await QueryFilter().FirstOrDefaultAsync(x => x.ID_Sach == filter.SachId && x.ID_PhieuMuon == filter.PhieuMuonId);
            _db.PhieuMuon_Sachs.Remove(entity);
            return await _db.SaveChangesAsync();
        }
        #endregion


    }
}
