using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class T120_EMPLEADO
	{
		[Key]
		public int idEmpleado { get; set; }
		public string genero { get; set; }
		public int? salario { get; set; }
		public decimal? precio { get; set; }
		public DateTime? fecIngreso { get; set; }
		public int? idtpEmpleado { get; set; }
		public string codEmpleado { get; set; }
		public string descArea { get; set; }
		public string cargo { get; set; }
		public int? idPersona { get; set; }
		public string estado { get; set; }
	}
}
