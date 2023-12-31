﻿using DAL.Common;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.Sachs.DTO
{
    public interface ISachService
    {
        IQueryable<Sach> QueryFilter(SachFilterInput input = null);
        IQueryable<Sach_DTO> QueryFilterDto(SachFilterInput input = null);
        Task<Sach> GetById(int id);
        Task<Sach_DTO> GetByIdDto(int id);
        Task<PageResultDTO<Sach_DTO>> Paging(PagingInput<SachFilterInput> input = null);
        Task<int> CreateSach(SachCreateInput input);
        Task<bool> UpdateSach(int SachId, SachCreateInput input);
        Task<bool> DeleteSachById(int SachId);
        Task<int> SachTrongKho();
        Task<Dictionary<string, int>> GetTongSachTheoTheLoai(SachFilterInput input = null);
        Task<Dictionary<string, int>> GetBookCategoryStatistics();

        int LayTongSoLuongChoMuon();
        int LaySoSachTraMuon();
        List<string> GetTop5Sach();
        Task<List<Sach_DTO>> GetListSachDtoAsync();
        Task<List<Sach>> GetListSachAsync();
        List<Sach> GetListSach();
        List<Sach_DTO> GetListSachDto();
        Task<Sach> GetSachByTenVaTacGia(string tensach, string tentacgia);
        Dictionary<string, int> GetBookCategoryStatistics(int? month, int? year);
        List<string> GetTop5SachByMonth(int? month, int? year);
    }
}