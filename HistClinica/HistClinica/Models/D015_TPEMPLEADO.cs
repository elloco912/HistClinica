using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
    public class D015_TPEMPLEADO
    {
        [Key]
        public int idtpEmpleado { get; set; }
        public string Descripcion { get; set; }
    }
}
