using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T001Pacconvenio
    {
        public int IdPacConvenio { get; set; }
        public string OrdAtenMedica { get; set; }
        public int? IdParentesco { get; set; }
        public string Cobertura { get; set; }
        public DateTime? IniVigencia { get; set; }
        public DateTime? FinVigencia { get; set; }
        public string EstadoConvenio { get; set; }
        public string TpAfiliacion { get; set; }
        public DateTime? FecAfiliacion { get; set; }
        public int? CodTitular { get; set; }
        public string Moneda { get; set; }
        public string NomContratante { get; set; }
        public int? IdtpDocumento { get; set; }
        public int? DniContratante { get; set; }
        public string Beneficio { get; set; }
        public string Restriccion { get; set; }
        public int? CopagoFijo { get; set; }
        public int? CopagoVariable { get; set; }
        public int? IdPaciente { get; set; }
        public string Estado { get; set; }
    }
}
