﻿using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            Paciente.estado = "2";
            _context.Update(Paciente);
            await Save();
        }
        public async Task<string> InsertPaciente(PersonaDTO persona, int idPersona)
        {
            try
            {
                await _context.T001_PACIENTE.AddAsync(new T001_PACIENTE()
                {
                    codPaciente = persona.paciente.codPaciente,
                    descripcion = persona.paciente.descripcion,
                    nrohc = persona.paciente.nrohc,
                    nombreAcom = persona.paciente.NombreAcompañante,
                    edadAcom = persona.paciente.edadAcompañante,
                    dniAcom = persona.paciente.numeroDocumentoAcompañante,
                    idgpoSangre = persona.paciente.idGrupoSanguineo,
                    idFactorrh = persona.paciente.idFactorRrh,
                    cobertura = persona.paciente.coberturaCompañia ?? persona.paciente.coberturaConvenio,
                    ordenAtenMed = persona.paciente.ordenAtencionMedicaCompañia ?? persona.paciente.ordenAtencionMedicaConvenio,
                    nomAsegurado = persona.paciente.nombreAseguradoraCompañia,
                    codAsegurado = persona.paciente.codAseguradoCompañia,
                    poliza = persona.paciente.polizaCompañia,
                    parentesco = persona.paciente.idParentescoPaciente,
                    iniVigencia = persona.paciente.inicioVigenciaCompañia ?? persona.paciente.inicioVigenciaConvenio,
                    finVigencia = persona.paciente.finVigenciaCompañia ?? persona.paciente.finVigenciaConvenio,
                    tpPlanSalud = persona.paciente.tipoPlanSaludCompañia,
                    nroPlanSalud = persona.paciente.numeroPlanSaludCompañia,
                    estadoSeguro = persona.paciente.estadoSeguro,
                    tpAfiliacion = persona.paciente.tpAfiliacion,
                    fecAfiliacion = persona.paciente.fecAfiliacion,
                    codTitular = persona.paciente.codTitular,
                    moneda = persona.paciente.moneda,
                    nomContratante = persona.paciente.nomContratante,
                    tpDocumento = persona.paciente.idTipoDocumentoAcompañante,
                    dniContratante = persona.paciente.dniContratante,
                    planSalud = persona.paciente.planSalud,
                    codCobertura = persona.paciente.codCobertura,
                    beneficio = persona.paciente.beneficio,
                    restriccion = persona.paciente.restriccion,
                    copagoFijo = persona.paciente.copagoFijo,
                    copagoVariable = persona.paciente.copagoVariable,
                    finCarencia = persona.paciente.finCarencia,
                    convenio = persona.paciente.convenio,
                    descuento = persona.paciente.descuento,
                    //codPaConvenio = persona.paciente.codPaConvenio,
                    //dsPacConv = persona.paciente.dsPacConv,
                    //statPaconv = persona.paciente.
                    //codPacSoat = dr["codPacSoat"].ToString(),
                    //dsPacSoat = dr["dsPacSoat"].ToString(),
                    //statPacSoat = dr["statPacSoat"].ToString(),
                    //codpacExterno = persona.paciente.cod,
                    //dspacExter = dr["dspacExter"].ToString(),
                    //stapacexter = dr["stapacexter"].ToString(),
                    tpPaciente = persona.paciente.idTipoPaciente,
                    idPersona = idPersona,
                    //hojafiliacion = persona.paciente.afi,
                    //concienteDato = persona.paciente.concienteDato,
                    estado = persona.paciente.estadoPaciente
                });
                await Save();
                return "Ingreso Exitoso Paciente";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> UpdatePaciente(PersonaDTO persona)
        {
            try
            {
                _context.Update(new T001_PACIENTE()
                {
                    idPaciente = (int)persona.paciente.idPaciente,
                    codPaciente = persona.paciente.codPaciente,
                    descripcion = persona.paciente.descripcion,
                    nrohc = persona.paciente.nrohc,
                    nombreAcom = persona.paciente.NombreAcompañante,
                    edadAcom = persona.paciente.edadAcompañante,
                    dniAcom = persona.paciente.numeroDocumentoAcompañante,
                    idgpoSangre = persona.paciente.idGrupoSanguineo,
                    idFactorrh = persona.paciente.idFactorRrh,
                    cobertura = persona.paciente.coberturaCompañia ?? persona.paciente.coberturaConvenio,
                    ordenAtenMed = persona.paciente.ordenAtencionMedicaCompañia ?? persona.paciente.ordenAtencionMedicaConvenio,
                    nomAsegurado = persona.paciente.nombreAseguradoraCompañia,
                    codAsegurado = persona.paciente.codAseguradoCompañia,
                    poliza = persona.paciente.polizaCompañia,
                    parentesco = persona.paciente.idParentescoPaciente,
                    iniVigencia = persona.paciente.inicioVigenciaCompañia ?? persona.paciente.inicioVigenciaConvenio,
                    finVigencia = persona.paciente.finVigenciaCompañia ?? persona.paciente.finVigenciaConvenio,
                    tpPlanSalud = persona.paciente.tipoPlanSaludCompañia,
                    nroPlanSalud = persona.paciente.numeroPlanSaludCompañia,
                    estadoSeguro = persona.paciente.estadoSeguro,
                    tpAfiliacion = persona.paciente.tpAfiliacion,
                    fecAfiliacion = persona.paciente.fecAfiliacion,
                    codTitular = persona.paciente.codTitular,
                    moneda = persona.paciente.moneda,
                    nomContratante = persona.paciente.nomContratante,
                    tpDocumento = persona.paciente.idTipoDocumentoAcompañante,
                    dniContratante = persona.paciente.dniContratante,
                    planSalud = persona.paciente.planSalud,
                    codCobertura = persona.paciente.codCobertura,
                    beneficio = persona.paciente.beneficio,
                    restriccion = persona.paciente.restriccion,
                    copagoFijo = persona.paciente.copagoFijo,
                    copagoVariable = persona.paciente.copagoVariable,
                    finCarencia = persona.paciente.finCarencia,
                    convenio = persona.paciente.convenio,
                    descuento = persona.paciente.descuento,
                    //codPaConvenio = persona.paciente.codPaConvenio,
                    //dsPacConv = persona.paciente.dsPacConv,
                    //statPaconv = persona.paciente.
                    //codPacSoat = dr["codPacSoat"].ToString(),
                    //dsPacSoat = dr["dsPacSoat"].ToString(),
                    //statPacSoat = dr["statPacSoat"].ToString(),
                    //codpacExterno = persona.paciente.cod,
                    //dspacExter = dr["dspacExter"].ToString(),
                    //stapacexter = dr["stapacexter"].ToString(),
                    tpPaciente = persona.paciente.idTipoPaciente,
                    idPersona = persona.idPersona,
                    //hojafiliacion = persona.paciente.afi,
                    //concienteDato = persona.paciente.concienteDato,
                    estado = persona.paciente.estadoPaciente
                });

                await Save();
                return "Actualizacion Exitosa Paciente";
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
                                                   select p).ToListAsync();

            return Pacientes;
        }
        public async Task<PersonaDTO> GetByDni(int? Dni)
        {
            PersonaDTO Persona = await (from p in _context.T000_PERSONA
                                        join pa in _context.T001_PACIENTE on p.idPersona equals pa.idPersona
                                        where p.dniPersona == Dni 
                                        select new PersonaDTO
                                        {
                                            nombres = p.nombres,
                                            apellidoPaterno = p.apePaterno,
                                            apellidoMaterno = p.apeMaterno,
                                            numeroDocumento = p.dniPersona,
                                            correo = p.correo,
                                            edad = p.edad,
                                            descripcionOcupacion = (from det in _context.D00_TBDETALLE where det.idDet == p.idOcupacion select det.descripcion).FirstOrDefault(),
                                            paciente = new PacienteDTO()
                                            {
                                                idPaciente = (from pa in _context.T001_PACIENTE
                                                              where pa.idPersona == p.idPersona
                                                              select pa.idPaciente).FirstOrDefault(),
                                                cita = new List<CitaDTO>()
                                            }
                                        }).FirstOrDefaultAsync();
            if (Persona != null)
            {
                Persona.paciente.cita = (from c in _context.T068_CITA
                                         where c.idPaciente == Persona.paciente.idPaciente
                                         select new CitaDTO
                                         {
                                             idCita = c.idCita,
                                             nroCita = c.nroCita,
                                             idTipoCita = c.tipoCita,
                                             TipoCita = (from tb in _context.D00_TBDETALLE
                                                     where tb.idDet == c.tipoCita
                                                     select tb.descripcion).FirstOrDefault(),
                                             fecha = (c.fechaCita).Value.Date.ToString(),
                                             hora = (c.fechaCita).Value.ToString("H:mm"),
                                             consultorio = (from de in _context.D00_TBDETALLE
                                                            where de.idDet == c.idConsultorio
                                                            select de.descripcion).FirstOrDefault(),
                                             descripcion = (from sc in _context.D00_TBDETALLE
                                                            where sc.idDet == c.idservicioCli
                                                            select sc.descripcion).FirstOrDefault(),
                                             medico = (from cm in _context.D012_CRONOMEDICO
                                                       join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                       join p in _context.T000_PERSONA on m.idPersona equals p.idPersona
                                                       where cm.idProgramMedica == c.idProgramMedica
                                                       select (p.nombres + " " + p.apePaterno + " " + p.apeMaterno)).FirstOrDefault(),
                                             especialidad = (from tb in _context.D00_TBDETALLE
                                                             join cm in _context.D012_CRONOMEDICO on c.idProgramMedica equals cm.idProgramMedica
                                                             join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                             where tb.idDet == m.idEspecialidad
                                                             select tb.descripcion).FirstOrDefault(),
                                             precio = c.precio,
                                             igv = c.igv,
                                             estado = (from ec in _context.T109_ESTADOCITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                             estadoPago = (from ep in _context.D015_PAGO
                                                           where ep.idCita == c.idCita
                                                           select ep.estado).FirstOrDefault()
                                         }).ToList();
            }
            //for (int i = 0; i < Persona.paciente.cita.Count; i++)
            //{
            //    Persona.paciente.cita[i].especialidad = (from tb in _context.D00_TBDETALLE where tb.idDet == Persona.paciente.cita[i].idEspecialidad select tb.descripcion).FirstOrDefault();
            //}
            return Persona;
        }
    }
}
