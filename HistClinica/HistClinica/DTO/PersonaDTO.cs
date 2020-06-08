using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.DTO
{
    public class PersonaDTO
    {
        public int? idPersona { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public int? ruc { get; set; }
        public int? edad { get; set; }
        public string telefono { get; set; }
        public int? idSexo { get; set; }
        public string fechaNacimiento { get; set; }
        public int? idGradoInstruccion { get; set; }
        public int? idEstadoCivil { get; set; }
        public string Email { get; set; }
        public string celular { get; set; }
        public int? idTipoDocumento { get; set; }
        public int? numeroDocumento { get; set; }
        public string centroEduca {get;set;}
        public string condicionRuc {get;set;}
        public string correo {get;set;}
        public string domiFiscal {get;set;}
        public string estado {get;set;}
        public string estadoRuc {get;set;}
        public string fecNacimiento {get;set;}
        public string fotografia {get;set;}
        public int? idciaSeguro {get;set;}
        public int? iddatoSiteds {get;set;}
        public int? idemprConvenio {get;set;}
        public int? idEstCivil {get;set;}
        public int? idEtnico {get;set;}
        public string idFactorrh {get;set;}
        public int? idgpoSangre {get;set;}
        public int? idGrdInstruc {get;set;}
        public int? idOcupacion {get;set;}
        public int? idParentesco {get;set;}
        public int? idReligion {get;set;}
        public int? idtipoIafa {get;set;}
        public int? idtipoVia {get;set;}
        public int? idUbigeoNace {get;set;}
        public int? idUbigeoResi {get;set;}
        public string interior {get;set;}
        public int? manzana {get;set;}
        public string nombreVia {get;set;}
        public string nroBlock {get;set;}
        public string nroDpto {get;set;}
        public int? nroEtapa {get;set;}
        public int? nroKm {get;set;}
        public string nroLote {get;set;}
        public int? nroVia {get;set;}
        public string razonSocial {get;set;}
        public int? tpPersona {get;set;}

        #region Personal
        public int? idEmpleado { get; set; }
        public int? idMedico { get; set; }
        public string codMedico  {get;set;}
        public string condicion  {get;set;}
        public string nroRne { get; set; }
        public int? idTipoEmpleado { get; set; }
        public string area { get; set; }
        public DateTime? fechaIngreso { get; set; }
        public int? numeroColegio { get; set; }
        public string cargo { get; set; }
        public int? idEspecialidad { get; set; }
        public string codEmpleado { get; set; }
        public string descArea {get;set;}
        public string estadoPersonal  {get;set;}
        public string genero  {get;set;}
        public double? precio  {get;set;}
        public int? salario { get; set; }
        #endregion
        #region Paciente
        public int? idPaciente { get; set; }
        public int? idAsegurado { get; set; }
        public int? idConvenio { get; set; }
        public int? idTipoPaciente { get; set; }
        public int? idOcupacionPaciente { get; set; }
        public int? idParentescoPaciente { get; set; }
        public int? idFactorRrh { get; set; }
        public int? idGrupoSanguineo { get; set; }
        public string codPaciente { get; set; }
        public string descripcion { get; set; }
        public int? nrohc { get; set; }
        public int idestado { get; set; }
        public int estadoPaciente { get; set; }
        #region Ubicacion
        public int? idDepartamentoUbicacion { get; set; }
        public int? idProvinciaUbicacion { get; set; }
        public int? idTipoViaUbicacion { get; set; }
        public string nombreViaUbicacion { get; set; }
        public int? numeroUbicacion { get; set; }
        public int? numeroDepartamentoUbicacion { get; set; }
        public int? interiorUbicacion { get; set; }
        public int? numeroLoteUbicacion { get; set; }
        #endregion
        #region Nacimiento
        public int? idPaisOrigenNacimiento { get; set; }
        public int? idDepartamentoNacimiento { get; set; }
        public int? idProvinciaNacimiento { get; set; }
        public int? idDistritoNacimiento { get; set; }
        #endregion
        #region Empresa
        public string razonSocialEmpresa { get; set; }
        public string estadoRucEmpresa { get; set; }
        public string domicilioFiscalEmpresa { get; set; }
        #endregion
        #region Seguro
        public string coberturaCompañia { get; set; }
        public string ordenAtencionMedicaCompañia { get; set; }
        public string nombreAseguradoraCompañia { get; set; }
        public string codAseguradoCompañia { get; set; }
        public string polizaCompañia { get; set; }
        public int? idParentescoCompañia { get; set; }
        public DateTime? inicioVigenciaCompañia { get; set; }
        public DateTime? finVigenciaCompañia { get; set; }
        public string tipoPlanSaludCompañia { get; set; }
        public int? numeroPlanSaludCompañia { get; set; } 
        public string tpPlanSalud {get;set;}       
        public string estadoSeguro {get;set;}   
        public string tpAfiliacion {get;set;}   
        public DateTime? fecAfiliacion {get;set;}  
        public int? codTitular {get;set;}     
        public string moneda {get;set;}         
        public string nomContratante {get;set;} 
        public int? dniContratante {get;set;} 
        public string planSalud {get;set;}      
        public string codCobertura {get;set;}   
        public string beneficio {get;set;}      
        public string restriccion {get;set;}    
        public int? copagoFijo {get;set;}     
        public int? copagoVariable {get;set;} 
        public int? finCarencia {get;set;}    
        public int? estadoCompañia {get;set;}    
        public string convenio {get;set;}       
        public double? descuento {get;set;}      
        #endregion
        #region Convenio
        public string coberturaConvenio { get; set; }
        public string ordenAtencionMedicaConvenio { get; set; }
        public int? idParentesoConvenio { get; set; }
        public string inicioVigenciaConvenio { get; set; }
        public string finVigenciaConvenio { get; set; }
        public int? estadoConven { get; set; }
        public int? estadoConvenio { get; set; }
        #endregion
        #region Acompañante
        public int? idTipoDocumentoAcompañante { get; set; }
        public int? numeroDocumentoAcompañante { get; set; }
        public string apellidoPaternoAcompañante { get; set; }
        public string apellidoMaternoAcompañante { get; set; }
        public string primerNombreAcompañante { get; set; }
        public string segundoNombreAcompañante { get; set; }
        public int? idParentescoAcompañante { get; set; }
        public int? edadAcompañante { get; set; }
        public int? estadoAcompañante { get; set; }
        #endregion
        #endregion Paciente
    }
}
