using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T068Cita
    {
        public int IdCita { get; set; }
        public int? CodCita { get; set; }
        public int? NroCita { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCita { get; set; }
        public string UltCie10 { get; set; }
        public string Servicio { get; set; }
        public string TpAtencion { get; set; }
        public int? NroHc { get; set; }
        public int? IdEstadoCita { get; set; }
        public int? IdEstaGralPac { get; set; }
        public string EstadoReprogram { get; set; }
        public string Ejecutado { get; set; }
        public string Prioridad { get; set; }
        public double? Precio { get; set; }
        public double? Descuento { get; set; }
        public double? Coa { get; set; }
        public double? Igv { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdConsultorio { get; set; }
        public int? IdProgramMedica { get; set; }
        public int? IdTpAtencion { get; set; }
        public int? IdEstAtencion { get; set; }
    }
}
