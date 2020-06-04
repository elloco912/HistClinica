using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
    public class Medico
    {
		[Key]
		public int idMedico { get; set; }
		public string codMedico { get; set; }
		public string especialidad { get; set; }
		public string cargo { get; set; }
		public string nombres { get; set; }
		public string apellidos { get; set; }
		public int? nroColegio { get; set; }
		public string nroRne { get; set; }
		public int? nroRuc { get; set; }
		public int? tpDocumento { get; set; }
		public int? nroDni { get; set; }
		public string area { get; set; }
		public string condicion { get; set; }
		public string telefono { get; set; }
		public string fecIngreso { get; set; }
		//public int? idEmpleado { get; set; }
		public int? idEspecialidad { get; set; }
		public string estado { get; set; }
	}
}
