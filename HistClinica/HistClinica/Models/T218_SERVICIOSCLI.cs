﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class T218_SERVICIOSCLI
	{
		[Key]
		public int idservicioCli { get; set; }
		public string descripcion { get; set; }
		public string estado { get; set; }
	}
}
