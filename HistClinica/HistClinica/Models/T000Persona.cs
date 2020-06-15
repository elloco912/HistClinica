using System;
using System.Collections.Generic;

namespace HistClinica.Models
{
    public partial class T000Persona
    {
        public int IdPersona { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombres { get; set; }
        public int? IdtpDocumento { get; set; }
        public int? DniPersona { get; set; }
        public int? IdSexo { get; set; }
        public int? IdEtnico { get; set; }
        public string FecNacimiento { get; set; }
        public int? IdUbigeoResi { get; set; }
        public int? IdtipoVia { get; set; }
        public string NombreVia { get; set; }
        public int? NroVia { get; set; }
        public int? NroDpto { get; set; }
        public int? Interior { get; set; }
        public int? Manzana { get; set; }
        public int? NroLote { get; set; }
        public int? NroKm { get; set; }
        public int? NroBlock { get; set; }
        public int? NroEtapa { get; set; }
        public int? Edad { get; set; }
        public int? IdUbigeoNace { get; set; }
        public string Fotografia { get; set; }
        public int? IdGrdInstruc { get; set; }
        public int? IdReligion { get; set; }
        public string CentroEduca { get; set; }
        public int? IdEstCivil { get; set; }
        public int? IdOcupacion { get; set; }
        public int? IdgpoSangre { get; set; }
        public int? IdFactorrh { get; set; }
        public int? NroRuc { get; set; }
        public string RazonSocial { get; set; }
        public string EstadoRuc { get; set; }
        public string CondicionRuc { get; set; }
        public string DomiFiscal { get; set; }
        public int? IdParentesco { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public int? TpPersona { get; set; }
        public int? IddatoSiteds { get; set; }
        public int? IdemprConvenio { get; set; }
        public int? IdciaSeguro { get; set; }
        public int? IdtipoIafa { get; set; }
        public string Estado { get; set; }
    }
}
