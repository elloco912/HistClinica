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
                    .FirstOrDefaultAsync(m => m.dniPersona == PersonaDTO.dni)).idPersona;
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
                //}
                if (PersonaDTO.idTipoEmpleado == 2)
                {
                    T212_MEDICO Medico = new T212_MEDICO()
                    {
                        idEmpleado = null,
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
                _context.Entry(Empleado).State = EntityState.Modified;
                //}
                if (PersonaDTO.idTipoEmpleado == 2)
                {
                    T212_MEDICO Medico = new T212_MEDICO()
                    {
                        idEmpleado = null,
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
                    _context.Entry(Medico).State = EntityState.Modified;
                }
                _context.Entry(new T000_PERSONA()
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
                }).State = EntityState.Modified;
                await Save();
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
                                            where p.idPersona == (from m in _context.T212_MEDICO where m.idPersona == p.idPersona select m.idPersona).First() 
                                            || p.idPersona == (from e in _context.T120_EMPLEADO where e.idPersona == p.idPersona select e.idPersona).FirstOrDefault()
                                            select new PersonaDTO
                                            {
                                                idPersona = p.idPersona,
                                                nombres = p.nombres,
                                                apellidos = p.apePaterno + " " + p.apeMaterno,
                                                fechaIngreso = null, //Empleado
                                                telefono = p.telefono,
                                                cargo = "" //Empleado
                                            }).ToListAsync();

            return Personas;
        }
        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO Persona = await (from p in _context.T000_PERSONA
                                     where (p.idPersona == (from m in _context.T212_MEDICO where m.idPersona == p.idPersona select m.idPersona).First()
                                     || p.idPersona == (from e in _context.T120_EMPLEADO where e.idPersona == p.idPersona select e.idPersona).FirstOrDefault())
                                     && p.idPersona == id
                                     select new PersonaDTO
                                     {
                                         idPersona = p.idPersona,
                                         nombres = p.nombres,
                                         apellidos = p.apePaterno + " " + p.apeMaterno,
                                         fechaIngreso = null,
                                         telefono = p.telefono,
                                         cargo = "",
                                         area = "",
                                         dni = p.dniPersona,
                                         idEmpleado = 0,
                                         idEspecialidad = 0,
                                         idMedico = 0,
                                         idTipoEmpleado = 0,
                                         numeroColegio = 0,
                                         ruc = p.nroRuc
                                     }).FirstOrDefaultAsync();
            return Persona;
        }
    }

}
