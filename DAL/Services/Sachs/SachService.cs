﻿using DAL.Common;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.Sachs.DTO
{
    public class SachService : ISachService
    {
        #region Khai báo
        public readonly QuanLyThuVienEntities _db;

        public SachService()
        {
            _db = new QuanLyThuVienEntities();
        }

        public async Task<int> SachTrongKho()
        {
            return await _db.Saches.SumAsync(x => x.SoLuong);
        }
        #endregion
        #region Query and paging
        public IQueryable<Sach> QueryFilter(SachFilterInput input = null)
        {
            var query = _db.Saches.AsQueryable();
            
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
                                TenTacGia = tgs != null ? tgs.TenTacGia : string.Empty,
                                TenNhaPhanPhoi = npps != null ? npps.TenNhaPhanPhoi : string.Empty,
                                TheLoais = q.TheLoais.Select(x => x.ID).ToList(),
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
        #endregion
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
                }
                foreach(var phieuMuonSach in entity.PhieuMuon_Sachs.ToList())
                {
                    entity.PhieuMuon_Sachs.Remove(phieuMuonSach);
                }
                _db.Saches.Remove(entity);
                await _db.SaveChangesAsync();
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
       
        public async Task<Sach> MapperCreateInputToEntity(SachCreateInput input, Sach entity)
        {
            
            await Task.Run(() =>
            {
                entity.TenSach = input.TenSach;
                entity.MoTa = input.MoTa;
                entity.DonGia = input.DonGia;
                entity.SoLuong = input.SoLuong;
                entity.ID_TacGia = input.TacGiaId;
                entity.ID_NhaPhanPhoi = input.NhaPhanPhoiId;
                entity.AnhSach = input.AnhSach;
                entity.NgayXB = input.NgayXb;
                var theLoais = _db.TheLoais.Where(t => input.ListTenTheLoai.Contains(t.TenTheLoai)).ToList();
                entity.TheLoais = theLoais;
            });
            return entity;
        }
    }
}
