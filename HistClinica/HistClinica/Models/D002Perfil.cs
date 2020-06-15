using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class D002Perfil
    {
        public int IdPerfil { get; set; }
        public string CodPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public int IdUsuario { get; set; }
        public string Estado { get; set; }
    }
}
