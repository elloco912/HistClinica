using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class TipoEmpleado
	{
		[Key]
		public int idTipoEmpleado { get; set; }
		public string Descripcion { get; set; }
	}
}
