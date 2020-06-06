using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D001_USUARIO
	{
		[Key]
		public int idUsuario { get; set; }
		public string loginUser { get; set; }
		public string claveUser { get; set; }
		public int idEmpleado { get; set; }
		public char estado { get; set; }
		public string usuRegistra { get; set; }
		public string fechaRegistra { get; set; }
		public string usuMod { get; set; }
		public string fechaMod { get; set; }
	}
}
