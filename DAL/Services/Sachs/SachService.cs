﻿using DAL.Common;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.Sachs.DTO
{
    public class SachService : ISachService
    {
        public readonly QuanLyThuVienEntities _db;

        public SachService()
        {
            _db = new QuanLyThuVienEntities();
        }


        public IQueryable<Sach> QueryFilter(SachFilterInput input = null)
        {
            var query = _db.Saches.AsQueryable();
            if (input != null)
            {
                if (!string.IsNullOrEmpty(input.TenSach))
                {
                    var lower = input.TenSach.Trim().ToLower();
                    query = query.Where(p => p.TenSach.ToLower().Contains(lower));
                }
                if (!string.IsNullOrEmpty(input.TenSach))
                {
                    var lower = input.TenSach.Trim().ToLower();
                    query = query.Where(p => p.TenSach.ToLower().Contains(lower));
                }
                if (input.listIdTheLoai?.Any() == true)
                {
                    query = query.Where(p => input.listIdTheLoai.All(rl => p.TheLoais.Any(tl => tl.ID == rl)));
                }
                if (input.namBatDau > 0)
                {
                    var startDate = new DateTime(input.namBatDau, 1, 1);
                    query = query.Where(p => p.NgayXB >= startDate);
                }
                if (input.namKetThuc > 0)
                {
                    var endDate = new DateTime(input.namKetThuc, 12, 31);
                    query = query.Where(p => p.NgayXB <= endDate);
                }
                if (input.TacGiaId.HasValue)
                {
                    query = query.Where(p => p.ID_TacGia == input.TacGiaId.Value);
                }
                if (!string.IsNullOrEmpty(input.NhaPhanPhoiId))
                {
                    query = query.Where(p => p.ID_NhaPhanPhoi == input.NhaPhanPhoiId);
                }
            }
            return query;
        }

        public IQueryable<Sach_DTO> QueryFilterDto(SachFilterInput input = null)
        {
            try
            {
                var query = from q in QueryFilter(input).Include(p => p.TheLoais)
                            from tgs in _db.TacGias.Where(tg => tg.ID == q.ID_TacGia).DefaultIfEmpty()
                            from npps in _db.NhaPhanPhois.Where(npp => npp.ID == q.ID_NhaPhanPhoi).DefaultIfEmpty()
                            select new Sach_DTO
                            {
                                SachId = q.ID,
                                TenSach = q.TenSach,
                                NhaPhanPhoiId = q.ID_NhaPhanPhoi,
                                SoLuong = q.SoLuong,
                                DonGia = (float)q.DonGia,
                                NgayXb = q.NgayXB,
                                AnhSach = q.AnhSach,
                                MoTa = q.MoTa,
                                TenTacGia = tgs != null ? tgs.TenTacGia : "Không xác định",
                                TenNhaPhanPhoi = npps != null ? npps.TenNhaPhanPhoi : "Không xác định",
                                TheLoais = q.TheLoais.ToList(),
                            };
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi ở chỗ queryDTO\n" + ex.Message);
            }
        }

        
        public async Task<PageResultDTO<Sach_DTO>> Paging(PagingInput<SachFilterInput> input = null)
        {
            var filtered = QueryFilterDto(input.Filter);
            var totalCount = await filtered.CountAsync();
            filtered = filtered.OrderByDescending(p => p.SachId);
            if (input.SkipCount > 0)
            {
                filtered = filtered.Skip(input.SkipCount);
            }
            if (input.MaxResultCount > 0)
            {
                filtered = filtered.Take(input.MaxResultCount);
            }
            var listData = await filtered.ToListAsync();
            return new PageResultDTO<Sach_DTO>(totalCount, listData);
        }

        #region crud
        public async Task<Sach> GetById(int id)
        {
            return await QueryFilter().FirstOrDefaultAsync(p => p.ID == id) ?? throw new Exception($"Không tìm thấy sách id {id}.");
        }

        public async Task<Sach_DTO> GetByIdDto(int id)
        {
            return await QueryFilterDto().FirstOrDefaultAsync(p => p.SachId == id) ?? throw new Exception($"Không tìm thấy sách id {id}.");
        }
        public async Task<int> CreateSach(SachCreateInput input)
        {
            var entity = await MapperCreateInputToEntity(input, new Sach());
            _db.Saches.Add(entity);
            await _db.SaveChangesAsync();
            return entity.ID;
        }

        public async Task<bool> DeleteSachById(int Id)
        {
            var entity = await GetById(Id);
            if(entity != null)
            {
                foreach(var theLoai in entity.TheLoais.ToList())
                {
                    entity.TheLoais.Remove(theLoai);

                    _db.Saches.Remove(entity);
                    await _db.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> UpdateSach(int Id, SachCreateInput input)
        {
            var entity = await GetById(Id);
            entity = await MapperCreateInputToEntity(input, entity);
            await _db.SaveChangesAsync();
            return true;
        }

        #endregion
        private async Task<Sach> MapperCreateInputToEntity(SachCreateInput input, Sach entity)
        {
            await Task.Run(() =>
            {
                entity.TenSach = input.TenSach;
                entity.MoTa = input.MoTa;
                entity.TheLoais = input.TheLoais;
                entity.DonGia = input.DonGia;
                entity.SoLuong = input.SoLuong;
                entity.ID_TacGia = input.TacGiaId;
                entity.ID_NhaPhanPhoi = input.NhaPhanPhoiId;
                entity.AnhSach = input.AnhSach;
                entity.NgayXB = input.NgayXb;
            });
            return entity;
        }
    }
}