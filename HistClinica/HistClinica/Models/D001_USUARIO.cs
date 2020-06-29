﻿using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class D001_USUARIO
	{
		[Key]
		public int idUsuario { get; set; }
		public string loginUser { get; set; }
		public string claveUser { get; set; }
		public int? idEmpleado { get; set; }
		public int estado { get; set; }
		public string usuCrea { get; set; }
		public string fechaCrea { get; set; }
		public string usuMod { get; set; }
		public string fechaMod { get; set; }
	}
}
