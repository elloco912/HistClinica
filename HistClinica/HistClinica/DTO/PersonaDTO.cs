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
        public int edad { get; set; }
        public string telefono { get; set; }
        public int idSexo { get; set; }
        public string fechaNacimiento { get; set; }
        public int idGradoInstruccion { get; set; }
        public int idEstadoCivil { get; set; }
        public string Email { get; set; }
        public string celular { get; set; }
        public int idTipoDocumento { get; set; }
        public int numeroDocumento { get; set; }
        #region Personal
        public int? idEmpleado { get; set; }
        public int? idMedico { get; set; }
        public int? idTipoEmpleado { get; set; }
        public string area { get; set; }
        public DateTime? fechaIngreso { get; set; }
        public int? numeroColegio { get; set; }
        public string cargo { get; set; }
        public int? idEspecialidad { get; set; }
        #endregion
        #region Paciente
        public int idPaciente { get; set; }
        public int idTipoPaciente { get; set; }
        public int idOcupacionPaciente { get; set; }
        public int idParentescoPaciente { get; set; }
        #region Ubicacion
        public int idDepartamentoUbicacion { get; set; }
        public int idProvinciaUbicacion { get; set; }
        public int idTipoViaUbicacion { get; set; }
        public string nombreViaUbicacion { get; set; }
        public int numeroUbicacion { get; set; }
        public int numeroDepartamentoUbicacion { get; set; }
        public int interiorUbicacion { get; set; }
        public int numeroLoteUbicacion { get; set; }
        #endregion
        #region Nacimiento
        public int idPaisOrigenNacimiento { get; set; }
        public int idDepartamentoNacimiento { get; set; }
        public int idProvinciaNacimiento { get; set; }
        public int idDistritoNacimiento { get; set; }
        #endregion
        #region Empresa
        public string razonSocialEmpresa { get; set; }
        public string estadoRucEmpresa { get; set; }
        public string domicilioFiscalEmpresa { get; set; }
        #endregion
        #region Compañia
        public string coberturaCompañia { get; set; }
        public string ordenAtencionMedicaCompañia { get; set; }
        public string nombreAseguradoraCompañia { get; set; }
        public string codAseguradoCompañia { get; set; }
        public string polizaCompañia { get; set; }
        public int idParentescoCompañia { get; set; }
        public string inicioVigenciaCompañia { get; set; }
        public string finVigenciaCompañia { get; set; }
        public string tipoPlanSaludCompañia { get; set; }
        public string numeroPlanSaludCompañia { get; set; }
        #endregion
        #region Convenio
        public string coberturaConvenio { get; set; }
        public string ordenAtencionMedicaConvenio { get; set; }
        public int idParentesoConvenio { get; set; }
        public string inicioVigenciaConvenio { get; set; }
        public string finVigenciaConvenio { get; set; }
        #endregion
        #region Acompañante
        public int idTipoDocumentoAcompañante { get; set; }
        public int numeroDocumentoAcompañante { get; set; }
        public string apellidoPaternoAcompañante { get; set; }
        public string apellidoMaternoAcompañante { get; set; }
        public string primerNombreAcompañante { get; set; }
        public string segundoNombreAcompañante { get; set; }
        public int idParentescoAcompañante { get; set; }
        public int edadAcompañante { get; set; }
        #endregion
        #endregion Paciente
    }
}
