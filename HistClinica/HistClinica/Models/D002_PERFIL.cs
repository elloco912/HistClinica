using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D002_PERFIL
	{
		[Key]
		public int idPerfil { get; set; }
		public string codPerfil { get; set; }
		public string nombrePerfil { get; set; }
		public int idUsuario { get; set; }
		public string estado { get; set; }
	}
}
