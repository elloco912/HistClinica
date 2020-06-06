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
        public PersonaRepository(ClinicaServiceContext context)
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

        public async Task<bool> PersonaExists(int? id)
        {
            return await _context.T000_PERSONA.AnyAsync(e => e.idPersona == id);
        }

        public async Task DeletePersona(int PersonaID)
        {
            T000_PERSONA Persona = await _context.T000_PERSONA.FindAsync(PersonaID);
            _context.T000_PERSONA.Remove(Persona);
        }
        public async Task<string> InsertPersona(PersonaDTO PersonaDTO)
        {
            int idPersona = 0;
            int idEmpleado = 0;
            try
            {
                await _context.T000_PERSONA.AddAsync(new T000_PERSONA()
                {
                    nombres = PersonaDTO.nombres,
                    apePaterno = PersonaDTO.apellidos.Split(" ")[0],
                    apeMaterno = PersonaDTO.apellidos.Split(" ")[1],
                    dniPersona = PersonaDTO.dni,
                    nroRuc = PersonaDTO.ruc,
                    telefono = PersonaDTO.telefono,
                    celular = null,
                    centroEduca = null,
                    condicionRuc = null,
                    correo = null,
                    domiFiscal = null,
                    edad = null,
                    estado = null,
                    estadoRuc = null,
                    fecNacimiento = null,
                    fotografia = null,
                    idciaSeguro = null,
                    iddatoSiteds = null,
                    idemprConvenio = null,
                    idEstCivil = null,
                    idEtnico = null,
                    idFactorrh = null,
                    idgpoSangre = null,
                    idGrdInstruc = null,
                    idOcupacion = null,
                    idParentesco = null,
                    idReligion = null,
                    idSexo = null,
                    idtipoIafa = null,
                    idtipoVia = null,
                    idtpDocumento = null,
                    idUbigeoNace = null,
                    idUbigeoResi = null,
                    interior = null,
                    manzana = null,
                    nombreVia = null,
                    nroBlock = null,
                    nroDpto = null,
                    nroEtapa = null,
                    nroKm = null,
                    nroLote = null,
                    nroVia = null,
                    razonSocial = null,
                    tpPersona = null
                });
                await Save();
                idPersona = (await _context.T000_PERSONA
                    .FirstOrDefaultAsync(p => p.dniPersona == PersonaDTO.dni)).idPersona;
                //if (PersonaDTO.idTipoEmpleado == 1)
                //{
                T120_EMPLEADO Empleado = new T120_EMPLEADO
                {
                    cargo = PersonaDTO.cargo,
                    codEmpleado = null,
                    descArea = null,
                    estado = null,
                    fecIngreso = PersonaDTO.fechaIngreso,
                    genero = null,
                    idtpEmpleado = PersonaDTO.idTipoEmpleado,
                    precio = null,
                    salario = null,
                    idPersona = idPersona
                };
                await _context.T120_EMPLEADO.AddAsync(Empleado);
                await Save();
                idEmpleado = (await _context.T120_EMPLEADO
                    .FirstOrDefaultAsync(e => e.idPersona == idPersona)).idEmpleado;
                //}
                if (PersonaDTO.idTipoEmpleado == 2)
                {
                    T212_MEDICO Medico = new T212_MEDICO()
                    {
                        idEmpleado = idEmpleado,
                        idPersona = idPersona,
                        nroColegio = PersonaDTO.numeroColegio,
                        nroRuc = PersonaDTO.ruc,
                        idEspecialidad = PersonaDTO.idEspecialidad,
                        codMedico = null,
                        condicion = null,
                        estado = "Activo",
                        nroRne = null
                    };
                    await _context.T212_MEDICO.AddAsync(Medico);
                    await Save();
                }
                return "Ingreso Exitoso Persona,Medico,Empleado";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdatePersona(PersonaDTO PersonaDTO)
        {
            try
            {
                _context.Update(new T000_PERSONA()
                {
                    idPersona = int.Parse(PersonaDTO.idPersona.ToString()),
                    nombres = PersonaDTO.nombres,
                    apePaterno = PersonaDTO.apellidos.Split(" ")[0],
                    apeMaterno = PersonaDTO.apellidos.Split(" ")[1],
                    dniPersona = PersonaDTO.dni,
                    nroRuc = PersonaDTO.ruc,
                    telefono = PersonaDTO.telefono,
                    celular = null,
                    centroEduca = null,
                    condicionRuc = null,
                    correo = null,
                    domiFiscal = null,
                    edad = null,
                    estado = null,
                    estadoRuc = null,
                    fecNacimiento = null,
                    fotografia = null,
                    idciaSeguro = null,
                    iddatoSiteds = null,
                    idemprConvenio = null,
                    idEstCivil = null,
                    idEtnico = null,
                    idFactorrh = null,
                    idgpoSangre = null,
                    idGrdInstruc = null,
                    idOcupacion = null,
                    idParentesco = null,
                    idReligion = null,
                    idSexo = null,
                    idtipoIafa = null,
                    idtipoVia = null,
                    idtpDocumento = null,
                    idUbigeoNace = null,
                    idUbigeoResi = null,
                    interior = null,
                    manzana = null,
                    nombreVia = null,
                    nroBlock = null,
                    nroDpto = null,
                    nroEtapa = null,
                    nroKm = null,
                    nroLote = null,
                    nroVia = null,
                    razonSocial = null,
                    tpPersona = null
                });
                await Save();
                //if (PersonaDTO.idTipoEmpleado == 1)
                //{
                T120_EMPLEADO Empleado = new T120_EMPLEADO
                {
                    cargo = PersonaDTO.cargo,
                    codEmpleado = null,
                    descArea = null,
                    estado = null,
                    fecIngreso = PersonaDTO.fechaIngreso,
                    genero = null,
                    idEmpleado = int.Parse(PersonaDTO.idTipoEmpleado.ToString()),
                    idtpEmpleado = PersonaDTO.idTipoEmpleado,
                    precio = null,
                    salario = null,
                    idPersona = PersonaDTO.idPersona
                };
                _context.Update(Empleado);
                await Save();
                //}
                if (PersonaDTO.idTipoEmpleado == 2)
                {
                    T212_MEDICO Medico = new T212_MEDICO()
                    {
                        idEmpleado = PersonaDTO.idEmpleado,
                        idPersona = PersonaDTO.idPersona,
                        nroColegio = PersonaDTO.numeroColegio,
                        nroRuc = PersonaDTO.ruc,
                        idEspecialidad = PersonaDTO.idEspecialidad,
                        codMedico = null,
                        condicion = null,
                        estado = "Activo",
                        nroRne = null,
                        idtpDocumento = null,
                        idMedico = int.Parse(PersonaDTO.idMedico.ToString())
                    };
                    _context.Update(Medico);
                    await Save();
                }
                return "Actualizacion Exitosa";
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
                                                nombres = p.nombres,
                                                apellidos = p.apePaterno + " " + p.apeMaterno,
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
                                         nombres = p.nombres,
                                         apellidos = p.apePaterno + " " + p.apeMaterno,
                                         fechaIngreso = e.fecIngreso,
                                         telefono = p.telefono,
                                         cargo = e.cargo,
                                         area = e.descArea,
                                         dni = p.dniPersona,
                                         idEmpleado = e.idEmpleado,
                                         idEspecialidad = 0,
                                         idMedico = 0,
                                         idTipoEmpleado = e.idtpEmpleado,
                                         numeroColegio = 0,
                                         ruc = p.nroRuc
                                     }).FirstOrDefaultAsync();
            if(Persona.idTipoEmpleado != 1)
            {
                var personaTemporal = await (from m in _context.T212_MEDICO
                                             where m.idEmpleado == Persona.idEmpleado
                                             select new PersonaDTO {
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
