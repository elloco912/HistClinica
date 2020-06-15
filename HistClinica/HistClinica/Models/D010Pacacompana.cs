using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class D010Pacacompana
    {
        public int IdPacAcom { get; set; }
        public string TpDocumento { get; set; }
        public int? DniAcom { get; set; }
        public string ApePatAcom { get; set; }
        public string ApeMatAcom { get; set; }
        public string NombresAcom { get; set; }
        public string Parentesco { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdPersona { get; set; }
        public string Estado { get; set; }
    }
}
