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

        public async Task<bool> PersonaExists(int id)
        {
            return await _context.Persona.AnyAsync(e => e.idPersona == id);
        }

        public async Task DeletePersona(int PersonaID)
        {
            Persona Persona = await _context.Persona.FindAsync(PersonaID);
            _context.Persona.Remove(Persona);
        }
        public async Task<string> InsertPersona(PersonaDTO PersonaDTO)
        {
            int idMedico = 0;
            int idEmpleado = 0;
            try
            {
                if (PersonaDTO.idTipoEmpleado == 1)
                {
                    Empleado Empleado = new Empleado
                    {
                        cargo = PersonaDTO.cargo,
                        codEmpleado = null,
                        descArea = null,
                        estado = null,
                        fecIngreso = DateTime.Parse(PersonaDTO.fechaIngreso),
                        gender = null,
                        idHorario = 0,
                        idTipoEmpleado = PersonaDTO.idTipoEmpleado,
                        name = PersonaDTO.nombres + "" + PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        precio = null,
                        salary = null
                    };
                    await _context.Empleado.AddAsync(Empleado);
                    await Save();
                    idEmpleado = (await _context.Empleado
                    .FirstOrDefaultAsync(m => m.nroDni == PersonaDTO.dni)).idEmpleado;
                }
                else
                {
                    Medico Medico = new Medico()
                    {
                        area = PersonaDTO.area,
                        nombres = PersonaDTO.nombres,
                        apellidos = PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        fecIngreso = PersonaDTO.fechaIngreso,
                        nroColegio = PersonaDTO.numeroColegio,
                        cargo = PersonaDTO.cargo,
                        nroRuc = PersonaDTO.ruc,
                        telefono = PersonaDTO.telefono,
                        idEspecialidad = PersonaDTO.idEspecialidad,
                        codMedico = null,
                        condicion = null,
                        especialidad = null,
                        estado = "Activo",
                        nroRne = null,
                        tpDocumento = null
                    };
                    await _context.Medico.AddAsync(Medico);
                    await Save();
                    idMedico = (await _context.Medico
                    .FirstOrDefaultAsync(m => m.nroDni == PersonaDTO.dni)).idMedico;
                }
                await _context.Persona.AddAsync(new Persona()
                {
                    nombres = PersonaDTO.nombres,
                    apePaterno = PersonaDTO.apellidos.Split(" ")[0],
                    apeMaterno = PersonaDTO.apellidos.Split(" ")[1],
                    dniPersona = PersonaDTO.dni,
                    nroRuc = PersonaDTO.ruc,
                    telefono = int.Parse(PersonaDTO.telefono),
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
                    iddatoReniec = null,
                    iddatoSiteds = null,
                    iddatoSunat = null,
                    idEmpleado = null,
                    idemprConvenio = null,
                    idEstCivil = null,
                    idEtnico = null,
                    idFactorrh = null,
                    idgpoSangre = null,
                    idGrdInstruc = null,
                    idMedico =null,
                    idOcupacion =null,
                    idPaciente =null,
                    idParentesco =null,
                    idReligion =null,
                    idSexo =null,
                    idtipoIafa =null,
                    idtipoVia =null,
                    idtpDocumento =null,
                    idUbigeoNace =null,
                    idUbigeoResi =null,
                    idUsuario =null,
                    interior =null,
                    manzana =null,
                    nombreVia =null,
                    nroBlock =null,
                    nroDpto =null,
                    nroEtapa =null,
                    nroKm =null,
                    nroLote =null,
                    nroVia =null,
                    razonSocial = null
                });
                await Save();
                return "Ingreso Exitoso Persona,Medico,Empleado";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> UpdatePersona(PersonaDTO PersonaDTO)
        {
            try
            {
                if (PersonaDTO.idTipoEmpleado == 1)
                {
                    Medico Medico = new Medico()
                    {
                        area = PersonaDTO.area,
                        nombres = PersonaDTO.nombres,
                        apellidos = PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        fecIngreso = PersonaDTO.fechaIngreso,
                        nroColegio = PersonaDTO.numeroColegio,
                        cargo = PersonaDTO.cargo,
                        nroRuc = PersonaDTO.ruc,
                        telefono = PersonaDTO.telefono,
                        idEspecialidad = PersonaDTO.idEspecialidad
                    };
                    _context.Entry(Medico).State = EntityState.Modified;
                }
                else
                {
                    Empleado Empleado = new Empleado
                    {
                        cargo = PersonaDTO.cargo,
                        codEmpleado = null,
                        descArea = null,
                        estado = null,
                        fecIngreso = DateTime.Parse(PersonaDTO.fechaIngreso),
                        gender = null,
                        idHorario = 0,
                        idTipoEmpleado = PersonaDTO.idTipoEmpleado,
                        name = PersonaDTO.nombres + "" + PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        precio = null,
                        salary = null
                    };
                    await _context.Empleado.AddAsync(Empleado);
                }
                _context.Entry(new Persona()
                {
                    nombres = PersonaDTO.nombres,
                    apePaterno = PersonaDTO.apellidos.Split(" ")[0],
                    apeMaterno = PersonaDTO.apellidos.Split(" ")[1],
                    dniPersona = PersonaDTO.dni,
                    nroRuc = PersonaDTO.ruc,
                    telefono = int.Parse(PersonaDTO.telefono),
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
                    iddatoReniec = null,
                    iddatoSiteds = null,
                    iddatoSunat = null,
                    idEmpleado = null,
                    idemprConvenio = null,
                    idEstCivil = null,
                    idEtnico = null,
                    idFactorrh = null,
                    idgpoSangre = null,
                    idGrdInstruc = null,
                    idMedico = null,
                    idOcupacion = null,
                    idPaciente = null,
                    idParentesco = null,
                    idReligion = null,
                    idSexo = null,
                    idtipoIafa = null,
                    idtipoVia = null,
                    idtpDocumento = null,
                    idUbigeoNace = null,
                    idUbigeoResi = null,
                    idUsuario = null,
                    interior = null,
                    manzana = null,
                    nombreVia = null,
                    nroBlock = null,
                    nroDpto = null,
                    nroEtapa = null,
                    nroKm = null,
                    nroLote = null,
                    nroVia = null,
                    razonSocial = null
                }).State = EntityState.Modified;
                await Save();
                return "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<Persona>> GetAllPersonas()
        {
            List<Persona> Personas = await (from p in _context.Persona
                                              select new Persona
                                              {
                                                  idPersona = p.idPersona,
                                                  apePaterno = p.apePaterno,
                                                  apeMaterno = p.apeMaterno
                                              }).ToListAsync();

            return Personas;
        }
        public async Task<Persona> GetById(int? id)
        {
            Persona Persona = await (from p in _context.Persona
                                        where p.idPersona == id
                                        select new Persona
                                        {
                                            idPersona = p.idPersona,
                                            apePaterno = p.apePaterno,
                                            apeMaterno = p.apeMaterno
                                        }).FirstOrDefaultAsync();
            return Persona;
        }
    }

}
