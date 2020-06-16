         using HistClinica.Data;
using HistClinica.Models;
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

		public async Task<List<D024_CAJA>> getCajas()
		{
			List<D024_CAJA> caja = await (from c in _context.D024_CAJA
										  select c).ToListAsync();

			return caja;
		}

		public async Task<object> GetCronograma()
		{
			var cronograma = await(from cro in _context.D012_CRONOMEDICO
								   join med in _context.T212_MEDICO on cro.idMedico equals med.idMedico
								   select new
								   {
									   idprogramMed = cro.idProgramMedica,
									 //  fecprogram = cro.fecProgramMedica.Value.ToShortDateString()
								   }).ToListAsync();
			return cronograma;
		}

		public async Task<object> GetCronogramaByMedico(int id)
		{
			var cronograma = await (from cro in _context.D012_CRONOMEDICO
									join med in _context.T212_MEDICO on cro.idMedico equals med.idMedico
									where med.idMedico == id
									select new
									{
										idprogramMed = cro.idProgramMedica,
									//	fecprogram = cro.fecProgramMedica.Value.ToShortDateString()
									}).ToListAsync();
			return cronograma;
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

		public async Task<List<T109_ESTADOCITA>> getEstadoCita()
		{

			List<T109_ESTADOCITA> estado = await (from e in _context.T109_ESTADOCITA
											select e).ToListAsync();
			return estado;
		}

		public async Task<object> GetHoras()
		{
			var horas = await (from cro in _context.D012_CRONOMEDICO
							   select new
							   {
								   id = cro.idProgramMedica,
								   hora = cro.hrInicio
							   }).ToListAsync();
			return horas;
		}

		public async Task<object> GetHorasByCronograma(int id)
		{
			var horas = await(from cro in _context.D012_CRONOMEDICO
								   where cro.idProgramMedica == id
								   select new
								   {
									   id = cro.idProgramMedica,
									   hora = cro.hrInicio
								   }).ToListAsync();
			return horas;
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
									nombres = per.primerNombre + " " + per.segundoNombre + " " + per.apePaterno + " " + per.apeMaterno
								}).ToListAsync();
			return medico;
		}

		public async Task<object> GetMedicos()
		{
			var medico = await (from per in _context.T000_PERSONA
						 join e in _context.T120_EMPLEADO on per.idPersona
						 equals e.idPersona
						 join med in _context.T212_MEDICO on e.idPersona equals med.idPersona
						 select new
						 {
							 idMedico = med.idMedico,
							 nombres = per.primerNombre +  " " + per.apePaterno + " " + per.apeMaterno
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
