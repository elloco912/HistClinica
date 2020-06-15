using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class D00Tbgeneral
    {
        public int IdTab { get; set; }
        public string CodTab { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public DateTime? FechaCreate { get; set; }
        public string UsuCreate { get; set; }
    }
}
