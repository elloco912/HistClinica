using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class T109_ESTADOCITA
	{
		[Key]
		public int idEstadoCita { get; set; }
		public string codEstadoCita { get; set; }
		public string estado { get; set; }
		public string origen { get; set; }
	}
}
