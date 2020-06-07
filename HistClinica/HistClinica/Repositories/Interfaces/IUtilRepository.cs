using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
	public interface IUtilRepository
	{
		Task<object> GetTipo(string nombretipo);
	}
}
