using DAL.Common;
using DAL.Model;
using DAL.Services.DocGias.DTO;
using DAL.Services.SachYeuCaus.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.SachYeuCaus
{
    public interface ISachYeuCauService
    {
        IQueryable<SachYeuCau> QueryFilter(SachYeuCauFilterInput input = null);
        IQueryable<SachYeuCau_DTO> QueryFilterDto(SachYeuCauFilterInput input = null);
        Task<SachYeuCau> GetById(int id);
        Task<SachYeuCau_DTO> GetByIdDto(int id);
        Task<PageResultDTO<SachYeuCau_DTO>> Paging(PagingInput<SachYeuCauFilterInput> input = null);
        Task<int> CreateSachYeuCau(SachYeuCauCreateInput input);
        Task<bool> UpdateSachYeuCau(int SachYeuCauId, SachYeuCauCreateInput input);
        Task<bool> DeleteSachYeuCauById(int SachYeuCauId);
        Task<List<SachYeuCau_DTO>> GetListSachYeuCauDto();
        Task<List<SachYeuCau>> GetListSachYeuCau();
    }
}