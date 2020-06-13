using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D025_ASIGNACAJA
	{
		[Key]
		public int? idCaja { get; set; }
		[Key]
		public int? idEmpleado { get; set; }
	}
}
