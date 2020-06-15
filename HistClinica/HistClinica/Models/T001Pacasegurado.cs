using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T001Pacasegurado
    {
        public int IdAsegurado { get; set; }
        public string Cobertura { get; set; }
        public string OrdenAtenMed { get; set; }
        public string NomAseguradora { get; set; }
        public string CodAsegurado { get; set; }
        public string Poliza { get; set; }
        public int? IdParentesco { get; set; }
        public DateTime? IniVigencia { get; set; }
        public DateTime? FinVigencia { get; set; }
        public string TpPlanSalud { get; set; }
        public int? NroplanSalud { get; set; }
        public string EstadoSeguro { get; set; }
        public string TpAfiliacion { get; set; }
        public DateTime? FecAfiliacion { get; set; }
        public int? CodTitular { get; set; }
        public string Moneda { get; set; }
        public string NomContratante { get; set; }
        public int? IdtpDocumento { get; set; }
        public int? DniContratante { get; set; }
        public string PlanSalud { get; set; }
        public string CodCobertura { get; set; }
        public string Beneficio { get; set; }
        public string Restriccion { get; set; }
        public int? CopagoFijo { get; set; }
        public int? CopagoVariable { get; set; }
        public int? FinCarencia { get; set; }
        public string Convenio { get; set; }
        public double? Descuento { get; set; }
        public int? IdPaciente { get; set; }
        public string Estado { get; set; }
    }
}
