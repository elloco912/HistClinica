using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class EstadoCita
	{
		[Key]
		public int idEstadoCita { get; set; }
		public string codEstadoCita { get; set; }
		public string estado { get; set; }
		public string origen { get; set; }
	}
}
