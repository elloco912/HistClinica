using HistClinica.Data;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class UtilRepository : IUtilRepository
    {
        private readonly ClinicaServiceContext _context;
        public UtilRepository(ClinicaServiceContext contexto)
        {
            _context = contexto;
        }
        public async Task<object> GetTipo(string nombretipo)
        {
            var combo = await (from tg in _context.D00_TBGENERAL
                               join td in _context.D00_TBDETALLE on tg.idTab
                                equals td.idTab
                               where tg.descripcion == nombretipo
                               select new
                               {
                                   idtab = tg.idTab,
                                   descripcion = td.descripcion
                               }).ToListAsync();
            return combo;
        }
    }
}
