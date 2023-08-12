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

namespace DAL.Services.PhieuMuon_Sach_Sachs
{
    public class PhieuMuon_SachService : IPhieuMuon_SachService
    {
        public readonly QuanLyThuVienEntities _db;

        public PhieuMuon_SachService()
        {
            _db = new QuanLyThuVienEntities();
        }


        public IQueryable<PhieuMuon_Sach> QueryFilter(PhieuMuon_SachFilterInput input = null)
        {
            var query = _db.PhieuMuon_Sach.AsQueryable();
            if (!string.IsNullOrEmpty(input.TenPhieuMuon))
            {
                var lower = input.TenPhieuMuon.Trim().ToLower();
                query = query.Where(p => p.PhieuMuon.TenPhieuMuon.ToLower().Contains(lower));
            }
            if (input.PhieuMuonId != 0 && input.PhieuMuonId != null)
            {
                query = query.Where(p => p.PhieuMuon.ID == input.PhieuMuonId);
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
            //   filtered = filtered.OrderByDescending(p => p.PhieuMuon_SachId);
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

        #region crud
        public async Task<PhieuMuon_Sach> GetById(int id)
        {
          //  return await QueryFilter().FirstOrDefaultAsync(p => p.ID == id) ?? throw new Exception($"Không tìm thấy Phiếu Mượn có id {id}.");
        }

        public async Task<PhieuMuon_Sach_DTO> GetByIdDto(int id)
        {
           // return await QueryFilterDto().FirstOrDefaultAsync(p => p.PhieuMuon_SachId == id) ?? throw new Exception($"Không tìm thấy sách id {id}.");
        }
        public async Task<int> CreatePhieuMuon_Sach(PhieuMuon_SachCreateInput input)
        {
            //var entity = await MapperCreateInputToEntity(input, new PhieuMuon_Sach());
            //_db.PhieuMuon_Sachs.Add(entity);
            //await _db.SaveChangesAsync();
            //return entity.ID;
        }

        public async Task<bool> DeletePhieuMuon_SachById(int Id)
        {
            throw new Exception();
            return false;
        }

        public async Task<bool> UpdatePhieuMuon_Sach(int Id, PhieuMuon_SachCreateInput input)
        {
            var entity = await GetById(Id);
            entity = await MapperCreateInputToEntity(input, entity);
            await _db.SaveChangesAsync();
            return true;
        }

        #endregion
        private async Task<PhieuMuon_Sach> MapperCreateInputToEntity(PhieuMuon_SachCreateInput input, PhieuMuon_Sach entity)
        {
            await Task.Run(() =>
            {
                throw new Exception();

            });
            return entity;
        }
    }
}
