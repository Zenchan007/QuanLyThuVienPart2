using DAL.Model;
using DAL.Services.TheLoais.DTO;
using DAL.Services.VaiTros.VaiTroDto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services.VaiTros
{
    public class VaiTroService : IVaiTroService
    {
        public readonly QuanLyThuVienEntities _db;
        public VaiTroService()
        {
            _db = new QuanLyThuVienEntities();
        }
        public IQueryable<VaiTro> QueryFilter(VaiTroFilterInput input = null)
        {
            var query = _db.VaiTroes.AsQueryable();
            return query;
        }
        public async Task<int> GetIdVaiTroTheoTen(string tenvaitro)
        {
            var vaitro = await QueryFilter().FirstOrDefaultAsync(x => x.TenRole.Equals(tenvaitro));
            return vaitro.ID;
        }
    }
}
