using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
    public class D008_CONSULTORIO
    {
        [Key]
        public int idConsultorio { get; set; }
        public int? nroConsultorio { get; set; }
        public int? tpConsultorio { get; set; }
        public string descripcion { get; set; }
        public string area { get; set; }
        public string piso { get; set; }
        public int? idEspecialidad { get; set; }
    }
}
