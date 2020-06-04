using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
	public interface ICronogramaRepository
	{
		Task<string> InsertCronograma(CronoMedico cronograma);
		Task<string> UpdateCronograma(CronoMedico cronograma);
		Task<CronoMedico> GetByIdCrono(int CronoID);
		Task<List<CronoMedico>> GetAllCronogramas();
		Task DeleteCronograma(int? CronoID);
		Task Save();
	}
}
