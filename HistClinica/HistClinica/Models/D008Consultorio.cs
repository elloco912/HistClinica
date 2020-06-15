using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class D008Consultorio
    {
        public int IdConsultorio { get; set; }
        public int? NroConsultorio { get; set; }
        public int? TpConsultorio { get; set; }
        public string Descripcion { get; set; }
        public string Area { get; set; }
        public string Piso { get; set; }
        public int? IdEspecialidad { get; set; }
    }
}
