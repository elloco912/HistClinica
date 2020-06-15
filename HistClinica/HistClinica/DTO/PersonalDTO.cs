using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.DTO
{
    public class PersonalDTO
    {
        #region Personal
        public int? idEmpleado { get; set; }
        public int? idMedico { get; set; }
        public string codMedico { get; set; }
        public string condicion { get; set; }
        public string nroRne { get; set; }
        public int? idTipoEmpleado { get; set; }
        public string area { get; set; }
        public DateTime? fechaIngreso { get; set; }
        public int? numeroColegio { get; set; }
        public string cargo { get; set; }
        public int? idEspecialidad { get; set; }
        public string codEmpleado { get; set; }
        public string descArea { get; set; }
        public string estadoPersonal { get; set; }
        public string genero { get; set; }
        public double? precio { get; set; }
        public int? salario { get; set; }
        #endregion
    }
}
