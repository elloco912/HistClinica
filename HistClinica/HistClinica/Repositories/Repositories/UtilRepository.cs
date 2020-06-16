﻿using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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

		public class Fecha
        {
			public int idprogramMed { get; set; }
			public  string fecprogram { get; set; }
		}

		public List<Fecha> ObtenerFecha(List<D012_CRONOMEDICO> cronograma)
        {
			int intervalo;
			List<Fecha> fechas = new List<Fecha>();
			foreach (var item in cronograma)
			{
				intervalo = item.fechaFin.Value.DayOfYear - item.fechaIni.Value.DayOfYear;
				for (int i = 0; i <= intervalo; i++)
				{
					Fecha fecha = new Fecha()
					{
						idprogramMed = item.idProgramMedica,
						fecprogram = item.fechaFin.Value.AddDays(i).ToShortDateString()
					};
					fechas.Add(fecha);
				}
			}
			return fechas;
		}

		public async Task<object> GetCronograma()
		{
			List<D012_CRONOMEDICO> cronograma = await(from cro in _context.D012_CRONOMEDICO
								   join med in _context.T212_MEDICO on cro.idMedico equals med.idMedico
								   select cro
									).ToListAsync();
			
			return ObtenerFecha(cronograma);
		}

		public async Task<object> GetCronogramaByMedico(int id)
		{
			List<D012_CRONOMEDICO> cronograma = await (from cro in _context.D012_CRONOMEDICO
									join med in _context.T212_MEDICO on cro.idMedico equals med.idMedico
									where med.idMedico == id
									select cro).ToListAsync();
			return ObtenerFecha(cronograma);
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
			var horas = new Collection();
			return horas;
		}

		public async Task<object> GetHorasByCronograma(int id)
		{
			var horas = await(from cro in _context.D012_CRONOMEDICO
								   where cro.idProgramMedica == id
								   select new
								   {
									   id = cro.idProgramMedica,
									   hora = cro.hrInicio + " - " + cro.hrFin
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
