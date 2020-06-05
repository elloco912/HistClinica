using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
	public interface ICronogramaRepository
	{
		Task<string> InsertCronograma(D012_CRONOMEDICO cronograma);
		Task<string> UpdateCronograma(D012_CRONOMEDICO cronograma);
		Task<D012_CRONOMEDICO> GetByIdCrono(int CronoID);
		Task<List<D012_CRONOMEDICO>> GetAllCronogramas();
		Task DeleteCronograma(int? CronoID);
		Task Save();
	}
}
