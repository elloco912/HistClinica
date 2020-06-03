using HistClinica.Data;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
	public class CronogramaRepository : ICronogramaRepository
	{
		private readonly ClinicaServiceContext _context;

		public CronogramaRepository(ClinicaServiceContext clinicaService)
		{
			_context = clinicaService;
		}

		private bool disposed = false;
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			this.disposed = true;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public async Task DeleteCronograma(int CronoID)
		{
			CronoMedico cronoMedico = await _context.CronoMedico.FindAsync(CronoID);
			_context.CronoMedico.Remove(cronoMedico);
		}

		public async Task<List<CronoMedico>> GetAllCronogramas()
		{
			List<CronoMedico> cronoMedicos = await (from c in _context.CronoMedico
													select new CronoMedico
													{
														idProgramMedica = c.idProgramMedica,
														fecProgramMedica = c.fecProgramMedica,
														dsHrInicio = c.dsHrInicio,
														dsHrFin = c.dsHrFin,
														dsEstado = c.dsEstado
													}).ToListAsync();
			return cronoMedicos;
		}

		public async Task<CronoMedico> GetByIdCrono(int CronoID)
		{
			CronoMedico cronoMedicos = await (from c in _context.CronoMedico 
											  where c.idProgramMedica == CronoID
											select c).FirstOrDefaultAsync();
			return cronoMedicos;
		}

		public async Task<string> InsertCronograma(CronoMedico cronograma)
		{
			try
			{
				await _context.CronoMedico.AddAsync(cronograma);
				await Save();
				return "Ingreso exitoso";
			}
			catch (Exception ex)
			{
				return "Error en el guardado " + ex.StackTrace;
			}
		}

		public async Task Save()
		{
			await _context.SaveChangesAsync();
		}

		public async Task<string> UpdateCronograma(CronoMedico cronograma)
		{
			try
			{
			    _context.Entry(cronograma).State = EntityState.Modified;
				await Save();
				return "Actualizacion exitosa";
			}
			catch (Exception ex)
			{
				return "Error en el guardado " + ex.StackTrace;
			}
		}
	}
}
