using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T120Empleado
    {
        public int IdEmpleado { get; set; }
        public string Genero { get; set; }
        public int? Salario { get; set; }
        public double? Precio { get; set; }
        public DateTime? FecIngreso { get; set; }
        public int? IdtpEmpleado { get; set; }
        public string CodEmpleado { get; set; }
        public string DescArea { get; set; }
        public string Cargo { get; set; }
        public int? IdPersona { get; set; }
        public string Estado { get; set; }
    }
}
