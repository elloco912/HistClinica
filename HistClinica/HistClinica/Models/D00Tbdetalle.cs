using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class D00Tbdetalle
    {
        public int IdDet { get; set; }
        public string CoddetTab { get; set; }
        public string Descripcion { get; set; }
        public string Abrev { get; set; }
        public string Fuente { get; set; }
        public string Estado { get; set; }
        public int? IdTab { get; set; }
    }
}
