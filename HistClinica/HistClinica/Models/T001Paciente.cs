using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T001Paciente
    {
        public int IdPaciente { get; set; }
        public string CodPaciente { get; set; }
        public int? IdtpPaciente { get; set; }
        public string Descripcion { get; set; }
        public int? Nrohc { get; set; }
        public string NombreAcom { get; set; }
        public int? EdadAcom { get; set; }
        public int? DniAcom { get; set; }
        public int? IdgpoSangre { get; set; }
        public int? IdFactorrh { get; set; }
        public int? IdPersona { get; set; }
        public int? IdAsegurado { get; set; }
        public int? IdPacConvenio { get; set; }
        public string Estado { get; set; }
    }
}
