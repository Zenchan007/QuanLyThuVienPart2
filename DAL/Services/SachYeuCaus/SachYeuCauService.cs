using DAL.Common;
using DAL.Model;
using DAL.Services.Sachs.DTO;
using DAL.Services.SachYeuCaus.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.SachYeuCaus
{
    public class SachYeuCauService : ISachYeuCauService
    {
        #region Khai báo
        public readonly QuanLyThuVienEntities _db;
        public SachYeuCauService()
        {
            _db = new QuanLyThuVienEntities();
        }
        #endregion
        #region Crud
        public async Task<int> CreateSachYeuCau(SachYeuCauCreateInput input)
        {
            var entity = await MapperCreateInputToEntity(input, new Model.SachYeuCau());
            _db.SachYeuCaus.Add(entity);
            return _db.SaveChanges();
        }

        public async Task<bool> UpdateSachYeuCau(int SachYeuCauId, SachYeuCauCreateInput input)
        {
            var entity = await GetById(SachYeuCauId);
            entity = await MapperCreateInputToEntity(input, entity);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteSachYeuCauById(int SachYeuCauId)
        {
            var entity = await GetById(SachYeuCauId);
            if (entity != null)
            {
                _db.SachYeuCaus.Remove(entity);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<Model.SachYeuCau> GetById(int id)
        {
            return await QueryFilter().FirstOrDefaultAsync(p => p.ID == id) ?? throw new Exception($"Không tìm thấy sách yêu cầu có id {id}.");
        }

        public async Task<SachYeuCau_DTO> GetByIdDto(int id)
        {
            return await QueryFilterDto().FirstOrDefaultAsync(p => p.SachYeuCauId == id) ?? throw new Exception($"Không tìm thấy sách yêu cầu có id {id}.");
        }
        public async Task<List<SachYeuCau_DTO>> GetListSachYeuCauDto()
        {
            return await QueryFilterDto().ToListAsync();
        }public async Task<List<SachYeuCau>> GetListSachYeuCau()
        {
            return await QueryFilter().ToListAsync();
        }
        #endregion

        #region Query and Paging
        public async Task<PageResultDTO<SachYeuCau_DTO>> Paging(PagingInput<SachYeuCauFilterInput> input = null)
        {
            var filtered = QueryFilterDto(input.Filter);
            var totalCount = await filtered.CountAsync();
            filtered = filtered.OrderByDescending(p => p.SachYeuCauId);
            if (input.SkipCount > 0)
            {
                filtered = filtered.Skip(input.SkipCount);
            }
            if (input.MaxResultCount > 0)
            {
                filtered = filtered.Take(input.MaxResultCount);
            }
            var listData = await filtered.ToListAsync();
            return new PageResultDTO<SachYeuCau_DTO>(totalCount, listData);
        }

        public IQueryable<Model.SachYeuCau> QueryFilter(SachYeuCauFilterInput input = null)
        {
            var query = _db.SachYeuCaus.AsQueryable();
        
            return query;
        }
        public IQueryable<SachYeuCau_DTO> QueryFilterDto(SachYeuCauFilterInput input = null)
        {
            try
            {
                var query = from q in QueryFilter(input)
                            select new SachYeuCau_DTO
                            {
                               SachYeuCauId = q.ID,
                               TenSachYC = q.TenSach,
                               TacGiaYC = q.TenTacGia
                            };
                return query;
            }
            catch
            {
                throw new Exception("Lỗi chỗ QueryFilter DTO");
            }
        }
        #endregion

        private async Task<Model.SachYeuCau> MapperCreateInputToEntity(SachYeuCauCreateInput input, Model.SachYeuCau entity)
        {
            await Task.Run(() =>
            {
                entity.TenSach = input.TenSachYC;
                entity.TenTacGia = input.TacGiaYC;
            });
            return entity;
        }


    }
}