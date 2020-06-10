using System;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
    public class T068_CITA
    {
        [Key]
        public int idCita { get; set; }
        public int? codCita { get; set; }
        public int? nroCita { get; set; }
        public string descripcion { get; set; }
        public DateTime? fechaCita { get; set; }
        public string ultCie10 { get; set; }
        public string servicio { get; set; }
        public string tpAtencion { get; set; }
        public int? nroHC { get; set; }
        public int? idEstadoCita { get; set; }
        public int? idEstaGralPac { get; set; }
        public string estadoReprogram { get; set; }
        public string ejecutado { get; set; }
        public string prioridad { get; set; }
        public double? precio { get; set; }
        public double? descuento { get; set; }
        public double? coa { get; set; }
        public double? igv { get; set; }
        public int? idPaciente { get; set; }
        public int? idEmpleado { get; set; }
        public int? idConsultorio { get; set; }
        public int? idProgramMedica { get; set; }
        public int? idTpAtencion { get; set; }
        public int? idEstAtencion { get; set; }
        public int? idservicioCli { get; set; }
    }
}