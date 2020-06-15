using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class D001Usuario
    {
        public int IdUsuario { get; set; }
        public string LoginUser { get; set; }
        public string ClaveUser { get; set; }
        public int IdEmpleado { get; set; }
        public string Estado { get; set; }
        public string UsuRegistra { get; set; }
        public string FechaRegistra { get; set; }
        public string UsuMod { get; set; }
        public string FechaMod { get; set; }
    }
}
