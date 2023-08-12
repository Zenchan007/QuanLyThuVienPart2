﻿using DAL.Common;
using DAL.Model;
using DAL.Services.PhieuMuons.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.PhieuMuons
{
    public interface IPhieuMuonService
    {
        IQueryable<PhieuMuon> QueryFilter(PhieuMuonFilterInput input = null);
        IQueryable<PhieuMuon_DTO> QueryFilterDto(PhieuMuonFilterInput input = null);
        Task<PhieuMuon> GetById(int id);
        Task<PhieuMuon_DTO> GetByIdDto(int id);
        Task<PageResultDTO<PhieuMuon_DTO>> Paging(PagingInput<PhieuMuonFilterInput> input = null);
        Task<int> CreatePhieuMuon(PhieuMuonCreateOrUpdateInput input);
        Task<bool> UpdatePhieuMuon(int chapterId, PhieuMuonCreateOrUpdateInput input);
        Task<bool> DeletePhieuMuonById(int chapterId);
    }
}