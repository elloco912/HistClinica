using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D00_TBGENERAL
	{
        internal string tipoDescripcion;

        [Key]
        public int idTab { get; set; }
        public string codTab { get; set; }
        public string descripcion { get; set; }
		public string tipo { get; set; }
		public DateTime? fechaCreate { get; set; }
        public string usuCreate { get; set; }

    }
}
