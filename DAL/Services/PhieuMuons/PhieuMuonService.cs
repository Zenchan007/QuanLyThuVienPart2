using DAL.Common;
using DAL.Model;
using DAL.QLTVExceptions;
using DAL.Services.PhieuMuon_Sachs;
using DAL.Services.PhieuMuons.DTO;
using DAL.Services.Sachs.DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
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

        public async Task<int> TongSachMuon()
        {
            var listSachMuon = _db.PhieuMuons.Include(x => x.PhieuMuon_Sachs)
                       .Where(x => x.ID_TrangThai == 1)
                       .SelectMany(x => x.PhieuMuon_Sachs).
                       Select(pm => pm.SoLuong);
            var z = await listSachMuon.ToListAsync();
            return 0;
        }

        #region QueryFilter and Paging
        public IQueryable<PhieuMuon> QueryFilter(PhieuMuonFilterInput input = null)
        {
            {
                // Cập nhật trạng thái phiếu muộn
                var today = DateTime.Today;
                var listMuon = _db.PhieuMuons.Where(p => p.NgayHenTra < today && p.ID_TrangThai != 3).ToList();

                if (listMuon?.Any() == true)
                {
                    foreach (var item in listMuon)
                    {
                        item.ID_TrangThai = 2;
                    }
                    _db.SaveChanges();
                }
            }
            var query = _db.PhieuMuons.AsQueryable();

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
                                TrangThaiId = q.TrangThai_PhieuMuon.ID,
                                TenTrangThai = q.TrangThai_PhieuMuon.TenTrangThai,
                                ListSachMuon = q.PhieuMuon_Sachs.ToList(),
                                NgayMuon = q.NgayMuon,
                                NgayHenTra = q.NgayHenTra,
                                NgayTra = q.NgayTra,
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
        public async Task<bool> UpdateTraSach(int Id, DateTime NgayTra)
        {
            var entity = await QueryFilter().FirstOrDefaultAsync(x => x.ID == Id);
            entity.NgayTra = NgayTra;
            entity.ID_TrangThai = 3;
            foreach (var item in entity.PhieuMuon_Sachs)
            {
                var sachThayDoi = await _db.Saches.FirstOrDefaultAsync(x => item.ID_Sach == x.ID);
                sachThayDoi.SoLuong += item.SoLuong;
            }
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateTraSach(int Id)
        {
            var entity = await QueryFilter().FirstOrDefaultAsync(x => x.ID == Id);
            entity.ID_TrangThai = 3;
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePhieuMuon(int Id, PhieuMuonCreateInput input)
        {
            var entity = await QueryFilter().FirstOrDefaultAsync(x => x.ID == Id);
            foreach (var item in entity.PhieuMuon_Sachs.ToList())
            {
                var sachThayDoi = await _db.Saches.FirstOrDefaultAsync(x => item.ID_Sach == x.ID);
                sachThayDoi.SoLuong += item.SoLuong;
                _db.PhieuMuon_Sachs.Remove(item);
            }
            entity = await MapperCreateInputToEntity(input, entity);
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
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePhieuMuon()
        {
            await _db.SaveChangesAsync();
            return true;
        }

        #endregion
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
    }
}
