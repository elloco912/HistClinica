using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
    public class Paciente
    {
		[Key]
		public int idPaciente			{get;set;}
		public int idtpPaciente			{get;set;}
		public string descripcion			{get;set;}
		public string idAsegurado			{get;set;}
		public int nrohc  {get;set;}
		public string nomAcompana  {get;set;}
		public int edadAcompana  {get;set;}
		public int dniAcompana  {get;set;}
		public int idgpoSangre  {get;set;}
		public int idFactorrh  {get;set;}
		public int idPersona  {get;set;}
		public int idPacConvenio  {get;set;}
		public string estado {get;set;}
	}
}
