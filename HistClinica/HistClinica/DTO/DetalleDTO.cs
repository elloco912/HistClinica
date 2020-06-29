using His.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistClinica.DTO
{
	public class DetalleDTO
	{
		public int idtab { get; set; }
		public string codigo { get; set; }

		public List<D00_TBDETALLE> ldetalle { get; set; }
	}
}