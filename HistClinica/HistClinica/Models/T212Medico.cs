using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T212Medico
    {
        public int IdMedico { get; set; }
        public string CodMedico { get; set; }
        public int? NroColegio { get; set; }
        public string NroRne { get; set; }
        public int? NroRuc { get; set; }
        public int? IdtpDocumento { get; set; }
        public string Condicion { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdEspecialidad { get; set; }
        public int? IdPersona { get; set; }
        public string Estado { get; set; }
    }
}
