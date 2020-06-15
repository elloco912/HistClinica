using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D00_TBDETALLE
	{
		[Key]
		public int idDet { get; set; }
		public string coddetTab { get; set; }
		public string descripcion { get; set; }
		public string abrev { get; set; }
		public string fuente { get; set; }
		public string estado { get; set; }
        public int? idTab { get; set; }



    }
}
