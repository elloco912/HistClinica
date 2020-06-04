using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class Especialidad
	{
		[Key]
		public int idEspecialidad { get; set; }
		public string codEspecialidad { get; set; }
		public string codSigesa { get; set; }
		public string descripcion { get; set; }
		public string codSubEspecial { get; set; }
		public string descSubEspecial { get; set; }
		public string estado { get; set; }
	}
}
