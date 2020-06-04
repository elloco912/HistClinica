using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class Persona
	{
		[Key]
		public int idPersona { get; set; }
		public string apePaterno { get; set; }
		public string apeMaterno { get; set; }
		public string nombres { get; set; }
		public int? idtpDocumento { get; set; }
		public int? dniPersona { get; set; }
		public int? idSexo { get; set; }
		public int? idEtnico { get; set; }
		public string fecNacimiento { get; set; }
		public int? idUbigeoResi { get; set; }
		public int? idtipoVia { get; set; }
		public string nombreVia { get; set; }
		public int? nroVia { get; set; }
		public int? nroDpto { get; set; }
		public int? interior { get; set; }
		public int? manzana { get; set; }
		public int? nroLote { get; set; }
		public int? nroKm { get; set; }
		public int? nroBlock { get; set; }
		public int? nroEtapa { get; set; }
		public int? edad { get; set; }
		public int? idUbigeoNace { get; set; }
		public string fotografia { get; set; }
		public int? idGrdInstruc { get; set; }
		public int? idReligion { get; set; }
		public string centroEduca { get; set; }
		public int? idEstCivil { get; set; }
		public int? idOcupacion { get; set; }
		public int? idgpoSangre { get; set; }
		public int? idFactorrh { get; set; }
		public int? nroRuc { get; set; }
		public string razonSocial { get; set; }
		public string estadoRuc { get; set; }
		public string condicionRuc { get; set; }
		public string domiFiscal { get; set; }
		public int? idParentesco { get; set; }
		public int? telefono { get; set; }
		public int? celular { get; set; }
		public string correo { get; set; }
		public int? idPaciente { get; set; }
		public int? idEmpleado { get; set; }
		public int? idMedico { get; set; }
		public int? idUsuario { get; set; }
		public int? iddatoReniec { get; set; }
		public int? iddatoSunat { get; set; }
		public int? iddatoSiteds { get; set; }
		public int? idemprConvenio { get; set; }
		public int? idciaSeguro { get; set; }
		public int? idtipoIafa { get; set; }
		public string estado { get; set; }
	}
}
