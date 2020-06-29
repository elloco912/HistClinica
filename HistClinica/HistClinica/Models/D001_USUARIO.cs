﻿using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class D001_USUARIO
	{
		public int? idEmpleado { get; set; }
		public string loginUser { get; set; }
		public string claveUser { get; set; }
		public int estado { get; set; }
		public string usuRegistra { get; set; }
		public string fechaRegistra { get; set; }
		public string usuMod { get; set; }
		public string fechaMod { get; set; }
	}
}
