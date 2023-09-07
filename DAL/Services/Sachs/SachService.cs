using DAL.Common;
using DAL.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;

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
            if (_db.Saches.ToList().Any())
            {
                return await _db.Saches.SumAsync(x => x.SoLuong);
            }
            return 0;
        }
        public Dictionary<string, int> GetTongSachTheoTheLoai(SachFilterInput input = null)
        {
            var query = QueryFilter(input);

            var result = query
                .Include(s => s.TheLoais)
                .SelectMany(s => s.TheLoais, (s, tl) => new { Sach = s, TheLoai = tl })
                .GroupBy(x => x.TheLoai.TenTheLoai)
                .ToDictionary(g => g.Key, g => g.Sum(x => 1));

            return result;
        }
        public Dictionary<string, int> GetBookCategoryStatistics()
        {
            var query = from s in _db.Saches
                        from tl in s.TheLoais
                        join pms in _db.PhieuMuon_Sachs on s.ID equals pms.ID_Sach
                        group pms by tl.TenTheLoai into g
                        select new { TenTheLoai = g.Key, TotalSoLuong = g.Sum(p => p.SoLuong) };

            var resultDict = query.ToDictionary(item => item.TenTheLoai, item => item.TotalSoLuong);
            return resultDict;
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
                                NhaPhanPhoiId = q.ID_NhaPhanPhoi ?? string.Empty,
                                SoLuong = q.SoLuong,
                                DonGia = (float)q.DonGia,
                                NgayXb = q.NgayXB,
                                AnhSach = q.AnhSach,
                                MoTa = q.MoTa,
                                TacGiaId = q.ID_TacGia ?? 0,
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
            try
            {
                _db.Saches.Add(entity);
                await _db.SaveChangesAsync();
            }
            catch (DbEntityValidationException ex)
            {
                // Xử lý lỗi kiểm tra hợp lệ ở đây
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceError($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            return entity.ID;
        }

        public async Task<bool> DeleteSachById(int Id)
        {
            var entity = await GetById(Id);
            if (entity != null)
            {
                foreach (var theLoai in entity.TheLoais.ToList())
                {
                    entity.TheLoais.Remove(theLoai);
                }
                foreach (var phieuMuonSach in entity.PhieuMuon_Sachs.ToList())
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
        public int LayTongSoLuongChoMuon()
        {
            var query = from p in _db.PhieuMuons
                        join pm in _db.PhieuMuon_Sachs on p.ID equals pm.ID_PhieuMuon
                        join tt in _db.TrangThai_PhieuMuon on p.ID_TrangThai equals tt.ID // Nối với TrangThai_PhieuMuon
                        where p.NgayMuon.HasValue && tt.ID != 3 // Đảm bảo có ngày cho mượn và ID Trang Thai khác 3
                        select pm.SoLuong;

            if (query.Any())
            {
                return query.Sum();
            }

            return 0;
        }
        public int LaySoSachTraMuon()
        {
            var query = from p in _db.PhieuMuons
                        join pm in _db.PhieuMuon_Sachs on p.ID equals pm.ID_PhieuMuon
                        join tt in _db.TrangThai_PhieuMuon on p.ID_TrangThai equals tt.ID // Nối với TrangThai_PhieuMuon
                        where p.NgayMuon.HasValue && tt.ID ==2 // Đảm bảo có ngày cho mượn và ID Trang Thai khác 3
                        select pm.SoLuong;
            if(query.Any())
                return query.Sum();
            return 0;
        }

        public  List<string> GetTop5Sach()
        {
            var topBorrowedBooks = (from pms in _db.PhieuMuon_Sachs
                                    group pms by pms.ID_Sach into g
                                    orderby g.Sum(pms => pms.SoLuong) descending
                                    select new
                                    {
                                        ID_Sach = g.Key,
                                        SoLuongMuon = g.Sum(pms => pms.SoLuong)
                                    })
                                   .Take(5)
                                   .ToList();

            var bookNames = (from topBook in topBorrowedBooks
                             join sach in _db.Saches on topBook.ID_Sach equals sach.ID
                             select sach.TenSach).ToList();
            return bookNames;
        }
        public async Task<Sach> MapperCreateInputToEntity(SachCreateInput input, Sach entity)
        {

            await Task.Run(() =>
            {
                entity.TenSach = input.TenSach;
                entity.MoTa = input.MoTa;
                entity.DonGia = input.DonGia;
                entity.SoLuong = input.SoLuong;
                if(input.TacGiaId != 0)
                entity.ID_TacGia = input.TacGiaId;
                if(!string.IsNullOrEmpty(input.NhaPhanPhoiId))
                entity.ID_NhaPhanPhoi = input.NhaPhanPhoiId;
                entity.AnhSach = input.AnhSach;
                entity.NgayXB = input.NgayXb;
                var theLoais = _db.TheLoais.Where(t => input.ListTenTheLoai.Contains(t.TenTheLoai)).ToList();
                entity.TheLoais = theLoais;
            });
            return entity;
        }
        public async Task<List<Sach_DTO>> GetListSachDtoAsync()
        {
            return await QueryFilterDto().ToListAsync();
        }
        public async Task<List<Sach>> GetListSachAsync()
        {
            return await QueryFilter().ToListAsync();
        }
        public List<Sach> GetListSach()
        {
            return  QueryFilter().ToList();
        } public List<Sach_DTO> GetListSachDto()
        {
            return  QueryFilterDto().ToList();
        }
        public async Task<Sach> GetSachByTenVaTacGia(string tensach, string tentacgia)
        {
            return await QueryFilter().FirstOrDefaultAsync(x => x.TenSach.Equals(tensach) && x.TacGia.TenTacGia.Equals(tentacgia));
        }
    }
}