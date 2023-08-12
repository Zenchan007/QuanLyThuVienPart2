using DAL.Common;
using DAL.Model;
using DAL.Services.PhieuMuon_Sachs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.PhieuMuon_PhieuMuon_Sachs
{
    public interface IPhieuMuon_SachService
    {
        IQueryable<PhieuMuon_Sach> QueryFilter(PhieuMuon_SachFilterInput input = null);
        IQueryable<PhieuMuon_Sach_DTO> QueryFilterDto(PhieuMuon_SachFilterInput input = null);
        Task<PhieuMuon_Sach> GetById(int id);
        Task<PhieuMuon_Sach_DTO> GetByIdDto(int id);
        Task<PageResultDTO<PhieuMuon_Sach_DTO>> Paging(PagingInput<PhieuMuon_SachFilterInput> input = null);
        Task<int> CreatePhieuMuon_Sach(PhieuMuon_SachCreateInput input);
        Task<bool> UpdatePhieuMuon_Sach(int chapterId, PhieuMuon_SachCreateInput input);
        Task<bool> DeletePhieuMuon_SachById(int chapterId);
    }
}
