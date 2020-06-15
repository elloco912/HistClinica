using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HistClinica.DTO
{
    public class DetalleDTO
    {
        [Key]
        [Display(Name = "Id Detalle")]
        public int idDet { get; set; }
        [Display(Name = "Codigo Detalle")]
        [Required(ErrorMessage = "Ingrese la Descripcion")]
        public string coddetTab { get; set; }
        [Display(Name = "Descripcion ")]
        [Required(ErrorMessage = "Ingrese nombre del tipo")]
        public string descripcion { get; set; }
        //public string UsuCreate { get; set; }
    }
}
