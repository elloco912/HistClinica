using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
    public class CronoMedico
    {

	[Key]
	public int idProgramMedica { get; set; }
	public string mes {get;set;} 
	public string semana {get;set;} 
	public string dia {get;set;} 
	public string fecProgramMedica { get; set; }
	public int idMedico { get; set; }
	public string dsMedico {get;set;} 
	public int idEspecialidad { get; set; }
	public string dsEspecialidad {get;set;} 
	public int idConsultorio { get; set; }
	public string dsConsultorio { get; set; }
	public string dsHrInicio {get;set;} 
	public string dsHrFin {get;set;} 
	public int idEstado { get; set; }
	public string dsEstado {get;set;} 
    }
}
