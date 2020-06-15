﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D012_CRONOMEDICO
	{
		[Key]
		public int idProgramMedica { get; set; }
		public string mes { get; set; }
		public string semana { get; set; }
		public string dia { get; set; }
		public DateTime? fecProgramMedica { get; set; }
		public int? idMedico { get; set; }
		public int? idEspecialidad { get; set; }
		public int? idConsultorio { get; set; }
		public string hrInicio { get; set; }
		public string hrFin { get; set; }
		public int? idEstado { get; set; }
	}
}
