using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T120Especialidad
    {
        public int IdEspecialidad { get; set; }
        public string CodEspecial { get; set; }
        public string CodSigesa { get; set; }
        public string Descripcion { get; set; }
        public string CodSubEspecial { get; set; }
        public string DescSubEspecial { get; set; }
    }
}
