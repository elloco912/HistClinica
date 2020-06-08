using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class T120_ESPECIALIDAD
	{
		[Key]
		public int idEspecialidad { get; set; }
		public string codEspecial { get; set; }
		public string codSigesa { get; set; }
		public string descripcion { get; set; }
		public string codSubEspecial { get; set; }
		public string descSubEspecial { get; set; }
	}
}
