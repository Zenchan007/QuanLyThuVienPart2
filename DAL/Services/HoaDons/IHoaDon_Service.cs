using DAL.Model;
using DAL.Services.HoaDons.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.HoaDons
{
    public interface IHoaDon_Service
    {
          Task<int> CreateHoaDon(HoaDonCreateInput input);

         Task<bool> UpdateHoaDon(int HoaDonId, HoaDonCreateInput input);

         Task<bool> DeleteHoaDonById(int HoaDonId);

         Task<HoaDon> GetById(int id);
       
         Task<HoaDon_DTO> GetByIdDto(int id);
         IQueryable<Model.HoaDon> QueryFilter(HoaDonFilterInput input = null);
         IQueryable<HoaDon_DTO> QueryFilterDto(HoaDonFilterInput input = null);
    }
}
