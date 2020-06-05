using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D015_TPEMPLEADO
	{
		[Key]
		public int idtpEmpleado { get; set; }
		public string Descripcion { get; set; }
	}
}
