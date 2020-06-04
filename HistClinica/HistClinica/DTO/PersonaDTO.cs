using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.DTO
{
    public class PersonaDTO
    {
        public int? idPersona { get; set; }
        public int? idEmpleado { get; set; }
        public int? idMedico { get; set; }
        public int? idTipoEmpleado { get; set; }
        public string area { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int? dni { get; set; }
        public string fechaIngreso { get; set; }
        public int? numeroColegio { get; set; }
        public string cargo { get; set; }
        public int? ruc { get; set; }
        public int? telefono { get; set; }
        public int? idEspecialidad { get; set; }
    }
}
