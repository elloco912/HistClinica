using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class D012Cronomedico
    {
        public int IdProgramMedica { get; set; }
        public string Mes { get; set; }
        public string Semana { get; set; }
        public string Dia { get; set; }
        public DateTime? FecProgramMedica { get; set; }
        public int? IdMedico { get; set; }
        public int? IdEspecialidad { get; set; }
        public int? IdConsultorio { get; set; }
        public string HrInicio { get; set; }
        public string HrFin { get; set; }
        public string IdEstado { get; set; }
    }
}
