﻿using DAL.Common;
using DAL.Model;
using DAL.Services.NhaPhanPhois.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.NhaPhanPhois
{
    public interface INhaPhanPhoiService
    {
        IQueryable<Model.NhaPhanPhoi> QueryFilter(NhaPhanPhoiFilterInput input = null);
        IQueryable<NhaPhanPhoi_DTO> QueryFilterDto(NhaPhanPhoiFilterInput input = null);
        Task<Model.NhaPhanPhoi> GetById(string id);
        Task<NhaPhanPhoi_DTO> GetByIdDto(string id);
        Task<PageResultDTO<NhaPhanPhoi_DTO>> Paging(PagingInput<NhaPhanPhoiFilterInput> input = null);
        Task<string> CreateNhaPhanPhoi(NhaPhanPhoiCreateInput input);
        Task<bool> UpdateNhaPhanPhoi(string NhaPhanPhoiid, NhaPhanPhoiCreateInput input);
        Task<bool> DeleteNhaPhanPhoiById(string NhaPhanPhoiId);
         Task<List<NhaPhanPhoi>> GetListNhaPhanPhoi();
         Task<List<NhaPhanPhoi_DTO>> GetListNhaPhanPhoiDto();
    }
}
