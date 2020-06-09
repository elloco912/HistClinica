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

		public async Task<object> GetEspecialidad(int id)
		{
			var combo = await(from td in _context.D00_TBDETALLE
							  join med in _context.T212_MEDICO
on td.idDet equals med.idEspecialidad
							  where med.idMedico == id
							  select new
							  {
								  idtab = td.idDet,
								  descripcion = td.descripcion
							  }).ToListAsync();
			return combo;
		}

		public async Task<object> GetMedicoByEspecialidad(int id)
		{
			var medico = await (from td in _context.D00_TBDETALLE
								join med in _context.T212_MEDICO
                                on td.idDet equals med.idEspecialidad
								join per in _context.T000_PERSONA
                                on med.idPersona equals per.idPersona
								where td.idDet == id
								select new
								{
									idMedico = med.idMedico,
									nombres = per.nombres + ' ' + per.apePaterno + ' ' + per.apeMaterno
								}).ToListAsync();
			return medico;
		}

		public async Task<object> GetTipo(string nombretipo)
		{
			var combo = await (from tg in _context.D00_TBGENERAL
								 join td in _context.D00_TBDETALLE on tg.idTab
                                  equals td.idTab
								 where tg.descripcion == nombretipo
								 select new
								 {
									 idtab = td.idDet,
									 descripcion = td.descripcion
								 }).ToListAsync();
			return combo;
		}
	}
}
