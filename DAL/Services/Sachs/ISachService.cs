using DAL.Common;
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
        Task<bool> UpdateSach(int chapterId, SachCreateInput input);
        Task<bool> DeleteSachById(int chapterId);
    }
}
