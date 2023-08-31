using DAL.Common;
using DAL.Model;
using DAL.QLTVExceptions;
using DAL.Services.PhieuMuon_Sachs;
using DAL.Services.PhieuMuons.DTO;
using DAL.Services.Sachs.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.PhieuMuons
{
    public class PhieuMuonService : IPhieuMuonService
    {
        #region Khai báo
        public readonly QuanLyThuVienEntities _db;

        public PhieuMuonService()
        {
            _db = new QuanLyThuVienEntities();
        }
        #endregion

        #region QueryFilter and Paging
        public IQueryable<PhieuMuon> QueryFilter(PhieuMuonFilterInput input = null)
        {
            var query = _db.PhieuMuons.AsQueryable();
            if (input != null)
            {
               
              
                if (input.TrangThaiId != 0 && input.TrangThaiId != null)
                {
                    query = query.Where(p => p.ID_TrangThai == input.TrangThaiId);
                }
                if (!string.IsNullOrEmpty(input.TenTrangThai))
                {
                    var lower = input.TenTrangThai.Trim().ToLower();
                    query = query.Where(p => p.TrangThai_PhieuMuon.TenTrangThai.ToLower().Contains(lower));
                }
                if (input.NgayMuon1.HasValue || input.NgayMuon2.HasValue)
                {
                    if (input.NgayMuon1.HasValue && input.NgayMuon2.HasValue)
                    {
                        query = query.Where(p => p.NgayMuon >= input.NgayMuon1.Value && p.NgayMuon <= input.NgayMuon2.Value);
                    }
                    else if (input.NgayMuon1.HasValue)
                    {
                        query = query.Where(p => p.NgayMuon >= input.NgayMuon1.Value);
                    }
                    else if (input.NgayMuon2.HasValue)
                    {
                        query = query.Where(p => p.NgayMuon <= input.NgayMuon2.Value);
                    }
                }
            }
            return query;
        }

        public IQueryable<PhieuMuon_DTO> QueryFilterDto(PhieuMuonFilterInput input = null)
        {
            try
            {
                var query = from q in QueryFilter(input).Include(p => p.PhieuMuon_Sachs)
                            select new PhieuMuon_DTO
                            {
                                PhieuMuonId = q.ID,
                                DocGiaId = q.ID_DocGia,
                                NhanVienId = q.ID_NhanVien,
                                TenNhanVien = q.NhanVien.TenNhanVien,
                                TenDocGia = q.DocGia.TenDocGia,
                                TenTrangThai = q.TrangThai_PhieuMuon.TenTrangThai,
                                TrangThaiId = q.TrangThai_PhieuMuon.ID,
                                ListSachMuon = q.PhieuMuon_Sachs.ToList(),
                                NgayMuon = q.NgayMuon ?? DateTime.MinValue,
                                NgayHenTra = q.NgayHenTra ?? DateTime.MinValue,
                                TienCoc = q.TienCoc ?? 0,
                                GhiChu = q.GhiChu
                            };
          
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi ở chỗ queryDTO\n" + ex.Message);
            }
        }
        public async Task<PageResultDTO<PhieuMuon_DTO>> Paging(PagingInput<PhieuMuonFilterInput> input = null)
        {
            var filtered = QueryFilterDto(input.Filter);
            var totalCount = await filtered.CountAsync();
            filtered = filtered.OrderByDescending(p => p.PhieuMuonId);
            if (input.SkipCount > 0)
            {
                filtered = filtered.Skip(input.SkipCount);
            }
            if (input.MaxResultCount > 0)
            {
                filtered = filtered.Take(input.MaxResultCount);
            }
            var listData = await filtered.ToListAsync();
            return new PageResultDTO<PhieuMuon_DTO>(totalCount, listData);
        }

        #endregion

        #region crud
        public async Task<PhieuMuon> GetById(int id)
        {
            return await QueryFilter().FirstOrDefaultAsync(p => p.ID == id) ?? throw new Exception($"Không tìm thấy Phiếu Mượn có id {id}.");
        }

        public async Task<PhieuMuon_DTO> GetByIdDto(int id)
        {
            return await QueryFilterDto().FirstOrDefaultAsync(p => p.PhieuMuonId == id) ?? throw new Exception($"Không tìm thấy sách id {id}.");
        }
        public async Task<int> CreatePhieuMuon(PhieuMuonCreateInput input)
        { 
            var entity = await MapperCreateInputToEntity(input, new PhieuMuon());
            
            foreach (var item in entity.PhieuMuon_Sachs)
            {
                item.ID_PhieuMuon = entity.ID;
                var sachThayDoi = await _db.Saches.FirstOrDefaultAsync(x => item.ID_Sach == x.ID);
                if (item.SoLuong <= sachThayDoi.SoLuong)
                {
                    sachThayDoi.SoLuong -= item.SoLuong;
                }
                else throw new PhieuMuon_SachException($"Cuốn '{sachThayDoi.TenSach}' không đủ số lượng yêu cầu! Không thể tạo phiếu mượn!");
            }
            _db.PhieuMuons.Add(entity);
            await _db.SaveChangesAsync();
            return entity.ID;
        }

        public async Task<bool> DeletePhieuMuonById(int Id)
        {
            var entity = await GetById(Id);
            _db.PhieuMuons.Remove(entity);
            _db.SaveChanges();
            return false;
        }

        public async Task<bool> UpdatePhieuMuon(int Id, PhieuMuonCreateInput input)
        {
            var entity = await QueryFilter().FirstOrDefaultAsync(x => x.ID == Id);
            entity = await MapperCreateInputToEntity(input, entity);
            await _db.SaveChangesAsync();
            return true;
        }
        


        

        public async Task<PhieuMuon> MapperCreateInputToEntity(PhieuMuonCreateInput input, PhieuMuon entity)
        {
            await Task.Run(() =>
            {
                entity.ID_NhanVien = input.NhanVienId;
                entity.ID_DocGia = input.DocGiaId;
                entity.NgayMuon = input.NgayMuon;
                entity.NgayHenTra = input.NgayHenTra;
                entity.GhiChu = input.GhiChu;
                entity.ID_TrangThai = input.TrangThaiId;
                entity.PhieuMuon_Sachs = new List<Model.PhieuMuon_Sachs>();
                foreach (var item in input.ListSachMuon)
                {
                    entity.PhieuMuon_Sachs.Add(new Model.PhieuMuon_Sachs
                    {
                        ID_Sach = item.SachId,
                        SoLuong = item.SoLuong
                    });
                }
                entity.TienCoc = input.TienCoc;
            });
            return entity;
        }

        #endregion
        
       
    }
}
