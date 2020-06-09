using HistClinica.Data;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using HistClinica.Models;
using System.Threading.Tasks;
using HistClinica.DTO;

namespace HistClinica.Repositories.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ClinicaServiceContext _context;
        private readonly IMedicoRepository _medicoRepository;
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IPacienteRepository _pacienteRepository;
        public PersonaRepository(ClinicaServiceContext context, IMedicoRepository medicorepository, IEmpleadoRepository empleadoRepository, IPacienteRepository pacienteRepository)
        {
            _context = context;
            _medicoRepository = medicorepository;
            _empleadoRepository = empleadoRepository;
            _pacienteRepository = pacienteRepository;
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

        public async Task<bool> PersonaExists(int? id)
        {
            return await _context.T000_PERSONA.AnyAsync(e => e.idPersona == id);
        }

        public async Task DeletePersona(int PersonaID)
        {
            T000_PERSONA Persona = await _context.T000_PERSONA.FindAsync(PersonaID);
            _context.T000_PERSONA.Remove(Persona);
            await Save();
        }
        public async Task<string> InsertPersona(PersonaDTO Persona)
        {
            int idPersona = 0;
            int idEmpleado = 0;
            try
            {
                await _context.T000_PERSONA.AddAsync(new T000_PERSONA()
                {
                    nombres = Persona.primerNombre + " " + Persona.segundoNombre,
                    apePaterno = Persona.apellidoPaterno,
                    apeMaterno = Persona.apellidoMaterno,
                    dniPersona = Persona.numeroDocumento,
                    nroRuc = Persona.ruc,
                    telefono = Persona.telefono,
                    celular = Persona.celular,
                    centroEduca = Persona.centroEduca,
                    condicionRuc = Persona.condicionRuc,
                    correo = Persona.correo,
                    domiFiscal = Persona.domiFiscal,
                    edad = Persona.edad,
                    estado = Persona.estado,
                    estadoRuc = Persona.estadoRuc,
                    fecNacimiento = Persona.fechaNacimiento,
                    fotografia = Persona.fotografia,
                    idciaSeguro = Persona.idciaSeguro,
                    iddatoSiteds = Persona.iddatoSiteds,
                    idemprConvenio = Persona.idemprConvenio,
                    idEstCivil = Persona.idEstCivil,
                    idEtnico = Persona.idEtnico,
                    idFactorrh = Persona.idFactorRrh,
                    idgpoSangre = Persona.idgpoSangre,
                    idGrdInstruc = Persona.idGrdInstruc,
                    idOcupacion = Persona.idOcupacion,
                    idParentesco = Persona.idParentesco,
                    idReligion = Persona.idReligion,
                    idSexo = Persona.idSexo,
                    idtipoIafa = Persona.idtipoIafa,
                    idtipoVia = Persona.idtipoVia,
                    idtpDocumento = Persona.idTipoDocumento,
                    idUbigeoNace = Persona.idUbigeoNace,
                    idUbigeoResi = Persona.idUbigeoResi,
                    interior = Persona.interiorUbicacion,
                    manzana = Persona.manzana,
                    nombreVia = Persona.nombreViaUbicacion,
                    nroBlock = Persona.numeroUbicacion,
                    nroDpto = Persona.numeroDepartamentoUbicacion,
                    nroEtapa = Persona.nroEtapa,
                    nroKm = Persona.nroKm,
                    nroLote = Persona.numeroLoteUbicacion,
                    nroVia = Persona.nroVia,
                    razonSocial = Persona.razonSocial,
                    tpPersona = Persona.tpPersona
                });
                await Save();
                idPersona = (await _context.T000_PERSONA
                    .FirstOrDefaultAsync(p => p.dniPersona == Persona.numeroDocumento)).idPersona;
                if (Persona.idTipoEmpleado != null)
                {
                    await _empleadoRepository.InsertEmpleado(Persona, idPersona);
                    idEmpleado = await _empleadoRepository.GetIdEmpleado(idPersona);
                    if (Persona.idTipoEmpleado == 109)
                    {
                        await _medicoRepository.InsertMedico(Persona, idPersona, idEmpleado);
                    }
                }
                else
                {
                    await _pacienteRepository.InsertPaciente(Persona, idPersona);
                }
                return "Ingreso Exitoso Persona";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdatePersona(PersonaDTO Persona)
        {
            try
            {
                _context.Update(new T000_PERSONA()
                {
                    idPersona = (int)Persona.idPersona,
                    nombres = Persona.primerNombre + " " + Persona.segundoNombre,
                    apePaterno = Persona.apellidoPaterno,
                    apeMaterno = Persona.apellidoMaterno,
                    dniPersona = Persona.numeroDocumento,
                    nroRuc = Persona.ruc,
                    telefono = Persona.telefono,
                    celular = Persona.celular,
                    centroEduca = Persona.centroEduca,
                    condicionRuc = Persona.condicionRuc,
                    correo = Persona.correo,
                    domiFiscal = Persona.domiFiscal,
                    edad = Persona.edad,
                    estado = Persona.estado,
                    estadoRuc = Persona.estadoRuc,
                    fecNacimiento = Persona.fechaNacimiento,
                    fotografia = Persona.fotografia,
                    idciaSeguro = Persona.idciaSeguro,
                    iddatoSiteds = Persona.iddatoSiteds,
                    idemprConvenio = Persona.idemprConvenio,
                    idEstCivil = Persona.idEstCivil,
                    idEtnico = Persona.idEtnico,
                    idFactorrh = Persona.idFactorRrh,
                    idgpoSangre = Persona.idgpoSangre,
                    idGrdInstruc = Persona.idGrdInstruc,
                    idOcupacion = Persona.idOcupacion,
                    idParentesco = Persona.idParentesco,
                    idReligion = Persona.idReligion,
                    idSexo = Persona.idSexo,
                    idtipoIafa = Persona.idtipoIafa,
                    idtipoVia = Persona.idtipoVia,
                    idtpDocumento = Persona.idTipoDocumento,
                    idUbigeoNace = Persona.idUbigeoNace,
                    idUbigeoResi = Persona.idUbigeoResi,
                    interior = Persona.interiorUbicacion,
                    manzana = Persona.manzana,
                    nombreVia = Persona.nombreViaUbicacion,
                    nroBlock = Persona.numeroUbicacion,
                    nroDpto = Persona.numeroDepartamentoUbicacion,
                    nroEtapa = Persona.nroEtapa,
                    nroKm = Persona.nroKm,
                    nroLote = Persona.numeroLoteUbicacion,
                    nroVia = Persona.nroVia,
                    razonSocial = Persona.razonSocial,
                    tpPersona = Persona.tpPersona
                });
                await Save();
                if (Persona.idTipoEmpleado != null)
                {
                    await _empleadoRepository.UpdateEmpleado(Persona);
                    if (Persona.idTipoEmpleado == 109)
                    {
                        await _medicoRepository.UpdateMedico(Persona);
                    }
                }
                else
                {
                    await _pacienteRepository.UpdatePaciente(Persona);
                }
                return "Actualizacion Exitosa Persona";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<PersonaDTO>> GetAllPersonas()
        {
            List<PersonaDTO> Personas = await (from p in _context.T000_PERSONA
                                               join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                               select new PersonaDTO
                                               {
                                                   idPersona = p.idPersona,
                                                   primerNombre = p.nombres,
                                                   segundoNombre = "",
                                                   apellidoPaterno = p.apePaterno,
                                                   apellidoMaterno = p.apeMaterno,
                                                   fechaIngreso = e.fecIngreso,
                                                   telefono = p.telefono,
                                                   cargo = e.cargo
                                               }).ToListAsync();

            return Personas;
        }
        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO Persona;
            Persona = await (from p in _context.T000_PERSONA
                             join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                             where p.idPersona == id
                             select new PersonaDTO
                             {
                                 idPersona = p.idPersona,
                                 primerNombre = p.nombres,
                                 segundoNombre = "",
                                 apellidoPaterno = p.apePaterno,
                                 apellidoMaterno = p.apeMaterno,
                                 fechaIngreso = e.fecIngreso,
                                 telefono = p.telefono,
                                 cargo = e.cargo,
                                 area = e.descArea,
                                 numeroDocumento = (int)p.dniPersona,
                                 idEmpleado = e.idEmpleado,
                                 idEspecialidad = 0,
                                 idMedico = 0,
                                 idTipoEmpleado = e.idtpEmpleado,
                                 numeroColegio = 0,
                                 ruc = p.nroRuc
                             }).FirstOrDefaultAsync();
            if (Persona.idTipoEmpleado != 1)
            {
                var personaTemporal = await (from m in _context.T212_MEDICO
                                             where m.idEmpleado == Persona.idEmpleado
                                             select new PersonaDTO
                                             {
                                                 idEspecialidad = m.idEspecialidad,
                                                 idMedico = m.idMedico,
                                                 numeroColegio = m.nroColegio
                                             }).FirstOrDefaultAsync();
                Persona.idEspecialidad = personaTemporal.idEspecialidad;
                Persona.idMedico = personaTemporal.idMedico;
                Persona.numeroColegio = personaTemporal.numeroColegio;
            }
            return Persona;
        }
    }

}