using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.DTO
{
    public class CitaDTO
    {
        public int? idCita { get; set; }
        public int? nroCita { get; set; }
        public string tipo { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string consultorio { get; set; }
        public string descripcion { get; set; }
        public string medico { get; set; }
        public int? idMedico { get; set; }
        public int? idPaciente { get; set; }
        public int? idEspecialidad { get; set; }
        public string especialidad { get; set; }
        public double? precio { get; set; }
        public double? igv { get; set; }
        public double? total { get; set; }
        public string estado { get; set; }
        public string estadoPago { get; set; }

    }
}
