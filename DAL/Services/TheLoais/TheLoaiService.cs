using DAL.Common;
using DAL.Model;
using DAL.Services.TheLoais.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.TheLoais
{
    public class TheLoaiService : ITheLoaiService
    {
        #region Khai báo
        public readonly QuanLyThuVienEntities _db;
        public TheLoaiService()
        {
            _db = new QuanLyThuVienEntities();
        }
        #endregion
        #region Crud
        public async Task<int> CreateTheLoai(TheLoaiCreateInput input)
        {
            var entity = await MapperCreateInputToEntity(input, new Model.TheLoai());
            _db.TheLoais.Add(entity);
            return _db.SaveChanges();
        }

        public async Task<bool> UpdateTheLoai(string TheLoaiId, TheLoaiCreateInput input)
        {
            var entity = await GetById(TheLoaiId);
            entity = await MapperCreateInputToEntity(input, entity);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteTheLoaiById(string TheLoaiId)
        {
            var entity = await GetById(TheLoaiId);
            if (entity != null)
            {
                foreach(var sach in entity.Saches.ToList())
                {
                    entity.Saches.Remove(sach);
                }
                _db.TheLoais.Remove(entity);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<Model.TheLoai> GetById(string id)
        {
            return await QueryFilter().FirstOrDefaultAsync(p => p.ID == id) ?? throw new Exception($"Không tìm thấy nhà phân phối có mã {id}.");
        }

        public async Task<TheLoai_DTO> GetByIdDto(string id)
        {
            return await QueryFilterDto().FirstOrDefaultAsync(p => p.TheLoaiId == id) ?? throw new Exception($"Không tìm thấy nhà phân phối có mã {id}.");
        }

        #endregion
        #region query and paging
        public async Task<PageResultDTO<TheLoai_DTO>> Paging(PagingInput<TheLoaiFilterInput> input = null)
        {
            var filtered = QueryFilterDto(input.Filter);
            var totalCount = await filtered.CountAsync();
            filtered = filtered.OrderByDescending(p => p.TheLoaiId);
            if (input.SkipCount > 0)
            {
                filtered = filtered.Skip(input.SkipCount);
            }
            if (input.MaxResultCount > 0)
            {
                filtered = filtered.Take(input.MaxResultCount);
            }
            var listData = await filtered.ToListAsync();
            return new PageResultDTO<TheLoai_DTO>(totalCount, listData);
        }

        public IQueryable<Model.TheLoai> QueryFilter(TheLoaiFilterInput input = null)
        {
            var query = _db.TheLoais.AsQueryable();
            if (input != null)
            {
                if (!string.IsNullOrEmpty(input.TenTheLoai))
                {
                    var lower = input.TenTheLoai.Trim().ToLower();
                    query = query.Where(p => p.TenTheLoai.ToLower().Contains(lower));
                }
                
            }
            return query;
        }

        public IQueryable<TheLoai_DTO> QueryFilterDto(TheLoaiFilterInput input = null)
        {
            try
            {
                var query = from q in QueryFilter(input)
                            select new TheLoai_DTO
                            {
                                TenTheLoai = q.TenTheLoai,
                                TheLoaiId = q.ID
                                , MoTa = q.MoTaThem,
                                SoSach = q.Saches.Count(),
                            };
                return query;
            }
            catch
            {
                throw new Exception("Lỗi chỗ QueryFilter DTO");
            }
        }
        #endregion
        private async Task<Model.TheLoai> MapperCreateInputToEntity(TheLoaiCreateInput input, Model.TheLoai entity)
        {
            await Task.Run(() =>
            {
                entity.ID = input.TheLoaiId;
                entity.TenTheLoai = input.TenTheLoai;
                entity.MoTaThem = input.MoTa;
            });
            return entity;
        }
    }
}
