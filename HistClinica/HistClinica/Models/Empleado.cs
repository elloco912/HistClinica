using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
    public class Empleado
    {
		[Key]
		public int idEmpleado { get; set; }
		public string name { get; set; }
		public string gender { get; set; }
		public int? salary { get; set; }
		public double? precio { get; set; }
		public DateTime? fecIngreso { get; set; }
		public int? idTipoEmpleado { get; set; }
		public int idHorario { get; set; }
		public string codEmpleado { get; set; }
		public string descArea { get; set; }
		public string cargo { get; set; }
		public int? nroDni { get; set; }
		public string estado { get; set; }
	}
}
