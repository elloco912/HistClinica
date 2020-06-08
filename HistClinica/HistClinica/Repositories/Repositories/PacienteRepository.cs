using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ClinicaServiceContext _context;
        public PacienteRepository(ClinicaServiceContext context)
        {
            _context = context;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PacienteExists(int? id)
        {
            return await _context.T001_PACIENTE.AnyAsync(e => e.idPaciente == id);
        }
        public async Task DeletePaciente(int PacienteID)
        {
            T001_PACIENTE Paciente = await _context.T001_PACIENTE.FindAsync(PacienteID);
            _context.T001_PACIENTE.Remove(Paciente);
            await Save();
        }
        public async Task<string> InsertPaciente(PersonaDTO Persona,int idPersona)
        {
            int? idAsegurado=null;
            int? idConvenio=null;
            int? idPaciente = null;
            try
            {
                if(Persona.idTipoPaciente == 151)//Compañia
                {
                    await _context.T001_PACASEGURADO.AddAsync(new T001_PACASEGURADO()
                    {
                        cobertura =         Persona.coberturaCompañia,
                        ordenAtenMed =      Persona.ordenAtencionMedicaCompañia,
                        nomAseguradora =    Persona.nombreAseguradoraCompañia,
                        codAsegurado =      Persona.codAseguradoCompañia,
                        poliza =            Persona.polizaCompañia,
                        idParentesco =      Persona.idParentescoCompañia,
                        idPaciente =        Persona.idPaciente,
                        estado =            Persona.estado,
                        idtpDocumento =     Persona.idTipoDocumento,
                        iniVigencia =       Persona.inicioVigenciaCompañia,
                        finVigencia =       Persona.finVigenciaCompañia,
                        tpPlanSalud =       Persona. tpPlanSalud,
                        nroplanSalud =      Persona.numeroPlanSaludCompañia,
                        estadoSeguro =      Persona.estadoSeguro,
                        tpAfiliacion =      Persona.tpAfiliacion,
                        fecAfiliacion =     Persona.fecAfiliacion,
                        codTitular =        Persona.codTitular,
                        moneda =            Persona.moneda,
                        nomContratante =    Persona.nomContratante,
                        dniContratante =    Persona.numeroDocumento,
                        planSalud =         Persona.planSalud,
                        codCobertura =      Persona.codCobertura,
                        beneficio =         Persona.beneficio,
                        restriccion =       Persona.restriccion,
                        copagoFijo =        Persona.copagoFijo,
                        copagoVariable =    Persona.copagoVariable,
                        finCarencia =       Persona.finCarencia,
                        convenio =          Persona.convenio,
                        descuento =         Persona.descuento
                    });
                    await Save();
                    idAsegurado = (await _context.T001_PACASEGURADO
                    .FirstOrDefaultAsync(p => p.dniContratante == Persona.numeroDocumento)).idAsegurado;
                }
                else if (Persona.idTipoPaciente == 152)//Convenio
                {
                    await _context.T001_PACCONVENIO.AddAsync(new T001_PACCONVENIO()
                    {
                        cobertura = Persona.coberturaCompañia,
                        idParentesco = Persona.idParentescoCompañia,
                        idPaciente = Persona.idPaciente,
                        estado = Persona.estadoConven.ToString(),
                        idtpDocumento = Persona.idTipoDocumento,
                        iniVigencia = Persona.inicioVigenciaCompañia,
                        finVigencia = Persona.finVigenciaCompañia,
                        tpAfiliacion = Persona.tpAfiliacion,
                        fecAfiliacion = Persona.fecAfiliacion,
                        codTitular = Persona.codTitular,
                        moneda = Persona.moneda,
                        nomContratante = Persona.nomContratante,
                        dniContratante = Persona.numeroDocumento,
                        beneficio = Persona.beneficio,
                        restriccion = Persona.restriccion,
                        copagoFijo = Persona.copagoFijo,
                        copagoVariable = Persona.copagoVariable,
                        estadoConvenio = Persona.estadoConvenio.ToString(),
                        ordAtenMedica = Persona.ordenAtencionMedicaConvenio
                    });
                    await Save();
                    idConvenio = (await _context.T001_PACCONVENIO
                    .FirstOrDefaultAsync(p => p.dniContratante == idPersona)).idPacConvenio;
                }
                await _context.T001_PACIENTE.AddAsync(new T001_PACIENTE()
                {
                    idPersona = idPersona,
                    codPaciente = Persona.codPaciente,
                    descripcion = Persona.descripcion,
                    dniAcom = Persona.numeroDocumentoAcompañante,
                    edadAcom = Persona.edadAcompañante,
                    estado = Persona.estadoPaciente.ToString(),
                    idAsegurado = idAsegurado,
                    idFactorrh = Persona.idFactorRrh,
                    idgpoSangre = Persona.idGrupoSanguineo,
                    idPacConvenio = idConvenio,
                    idtpPaciente = Persona.idTipoPaciente,
                    nombreAcom = Persona.primerNombreAcompañante + " " + Persona.segundoNombreAcompañante + " " + Persona.apellidoPaternoAcompañante + " " + Persona.apellidoMaternoAcompañante,
                    nrohc = Persona.nrohc
                });
                await Save();
                idPaciente = (await _context.T001_PACIENTE
                    .FirstOrDefaultAsync(p => p.idPersona == idPersona)).idPaciente;
                await _context.D010_PACACOMPANA.AddAsync(new D010_PACACOMPANA()
                {
                    tpDocumento = Persona.idTipoDocumentoAcompañante.ToString(),
                    dniAcom = Persona.numeroDocumentoAcompañante,
                    nombresAcom = Persona.primerNombre + " " + Persona.segundoNombre,
                    apePatAcom = Persona.apellidoPaterno,
                    apeMatAcom = Persona.apellidoMaterno,
                    parentesco = Persona.idParentescoAcompañante.ToString(),
                    idPersona = idPersona,
                    estado = Persona.estadoAcompañante.ToString(),
                    idPaciente = idPaciente
                });
                await Save();
                return "Ingreso Exitoso Paciente";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> UpdatePaciente(PersonaDTO Persona)
        {
            try
            {
                if (Persona.idTipoPaciente == 151)//Compañia
                {
                    _context.Update(new T001_PACASEGURADO()
                    {
                        idAsegurado = (int)Persona.idAsegurado,
                        cobertura = Persona.coberturaCompañia,
                        ordenAtenMed = Persona.ordenAtencionMedicaCompañia,
                        nomAseguradora = Persona.nombreAseguradoraCompañia,
                        codAsegurado = Persona.codAseguradoCompañia,
                        poliza = Persona.polizaCompañia,
                        idParentesco = Persona.idParentescoCompañia,
                        idPaciente = Persona.idPaciente,
                        estado = Persona.estadoCompañia.ToString(),
                        idtpDocumento = Persona.idTipoDocumento,
                        iniVigencia = Persona.inicioVigenciaCompañia,
                        finVigencia = Persona.finVigenciaCompañia,
                        tpPlanSalud = Persona.tpPlanSalud,
                        nroplanSalud = Persona.numeroPlanSaludCompañia,
                        estadoSeguro = Persona.estadoSeguro,
                        tpAfiliacion = Persona.tpAfiliacion,
                        fecAfiliacion = Persona.fecAfiliacion,
                        codTitular = Persona.codTitular,
                        moneda = Persona.moneda,
                        nomContratante = Persona.nomContratante,
                        dniContratante = Persona.numeroDocumento,
                        planSalud = Persona.planSalud,
                        codCobertura = Persona.codCobertura,
                        beneficio = Persona.beneficio,
                        restriccion = Persona.restriccion,
                        copagoFijo = Persona.copagoFijo,
                        copagoVariable = Persona.copagoVariable,
                        finCarencia = Persona.finCarencia,
                        convenio = Persona.convenio,
                        descuento = Persona.descuento
                    });
                    await Save();
                }
                else if (Persona.idTipoPaciente == 152)//Convenio
                {
                    _context.Update(new T001_PACCONVENIO()
                    {
                        idPacConvenio = (int)Persona.idConvenio,
                        cobertura = Persona.coberturaCompañia,
                        idParentesco = Persona.idParentescoCompañia,
                        idPaciente = Persona.idPaciente,
                        estado = Persona.estadoConven.ToString(),
                        idtpDocumento = Persona.idTipoDocumento,
                        iniVigencia = Persona.inicioVigenciaCompañia,
                        finVigencia = Persona.finVigenciaCompañia,
                        tpAfiliacion = Persona.tpAfiliacion,
                        fecAfiliacion = Persona.fecAfiliacion,
                        codTitular = Persona.codTitular,
                        moneda = Persona.moneda,
                        nomContratante = Persona.nomContratante,
                        dniContratante = Persona.numeroDocumento,
                        beneficio = Persona.beneficio,
                        restriccion = Persona.restriccion,
                        copagoFijo = Persona.copagoFijo,
                        copagoVariable = Persona.copagoVariable,
                        estadoConvenio = Persona.estadoConvenio.ToString(),
                        ordAtenMedica = Persona.ordenAtencionMedicaConvenio
                    });
                    await Save();
                }
                _context.Update(new T001_PACIENTE()
                {
                    idPersona = Persona.idPersona,
                    idPaciente = (int)Persona.idPaciente,
                    codPaciente = Persona.codPaciente,
                    descripcion = Persona.descripcion,
                    dniAcom = Persona.numeroDocumentoAcompañante,
                    edadAcom = Persona.edadAcompañante,
                    estado = Persona.estadoPaciente.ToString(),
                    idAsegurado = Persona.idAsegurado,
                    idFactorrh = Persona.idFactorRrh,
                    idgpoSangre = Persona.idGrupoSanguineo,
                    idPacConvenio = Persona.idConvenio,
                    idtpPaciente = Persona.idTipoPaciente,
                    nombreAcom = Persona.primerNombreAcompañante + " " + Persona.segundoNombreAcompañante + " " + Persona.apellidoPaternoAcompañante + " " + Persona.apellidoMaternoAcompañante,
                    nrohc = Persona.nrohc
                });
                await Save();
                _context.Update(new D010_PACACOMPANA()
                {
                    tpDocumento = Persona.idTipoDocumentoAcompañante.ToString(),
                    dniAcom = Persona.numeroDocumentoAcompañante,
                    nombresAcom = Persona.primerNombre + " " + Persona.segundoNombre,
                    apePatAcom = Persona.apellidoPaterno,
                    apeMatAcom = Persona.apellidoMaterno,
                    parentesco = Persona.idParentescoAcompañante.ToString(),
                    idPersona = Persona.idPersona,
                    estado = Persona.estadoAcompañante.ToString(),
                    idPaciente = Persona.idPaciente
                });
                await Save();
                return "Ingreso Exitoso Paciente";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<T001_PACIENTE>> GetAllPacientes()
        {
            List<T001_PACIENTE> Pacientes = await (from p in _context.T001_PACIENTE
                                                   join o in _context.T000_PERSONA on p.idPersona equals o.idPersona
                                                   select new T001_PACIENTE
                                                   {
                                                       idPaciente = p.idPaciente,
                                                       codPaciente = p.codPaciente,
                                                       descripcion = p.descripcion,
                                                       dniAcom = p.dniAcom,
                                                       edadAcom = p.edadAcom,
                                                       estado = p.estado,
                                                       idAsegurado = p.idAsegurado,
                                                       idFactorrh = p.idFactorrh,
                                                       idgpoSangre = p.idgpoSangre,
                                                       idPacConvenio = p.idPacConvenio,
                                                       idPersona = p.idPersona,
                                                       idtpPaciente = p.idtpPaciente,
                                                       nombreAcom = p.nombreAcom,
                                                       nrohc = p.nrohc
                                                   }).ToListAsync();

            return Pacientes;
        }
        public async Task<T001_PACIENTE> GetByDni(int? Dni)
        {
            T001_PACIENTE Paciente = await (from p in _context.T001_PACIENTE
                                            join o in _context.T000_PERSONA on p.idPersona equals o.idPersona
                                            where o.dniPersona == Dni
                                            select new T001_PACIENTE
                                            {
                                                idPaciente = p.idPaciente,
                                                codPaciente = p.codPaciente,
                                                descripcion = p.descripcion,
                                                dniAcom = p.dniAcom,
                                                edadAcom = p.edadAcom,
                                                estado = p.estado,
                                                idAsegurado = p.idAsegurado,
                                                idFactorrh = p.idFactorrh,
                                                idgpoSangre = p.idgpoSangre,
                                                idPacConvenio = p.idPacConvenio,
                                                idPersona = p.idPersona,
                                                idtpPaciente = p.idtpPaciente,
                                                nombreAcom = p.nombreAcom,
                                                nrohc = p.nrohc
                                            }).FirstOrDefaultAsync();
            return Paciente;
        }
    }
}
