using HistClinica.Data;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using HistClinica.Models;
using System.Threading.Tasks;
using HistClinica.DTO;
using Microsoft.Data.SqlClient;

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
            return await _context.Persona.AnyAsync(e => e.idPersona == id);
        }

        public async Task DeletePersona(int PersonaID)
        {
            Persona Persona = await _context.Persona.FindAsync(PersonaID);
            _context.Persona.Remove(Persona);
        }
        public async Task<string> InsertPersona(PersonaDTO PersonaDTO)
        {
            int idPersona = 0;
            try
            {
                await _context.Persona.AddAsync(new Persona()
                {
                    nombres = PersonaDTO.nombres,
                    apePaterno = PersonaDTO.apellidos.Split(" ")[0],
                    apeMaterno = PersonaDTO.apellidos.Split(" ")[1],
                    dniPersona = PersonaDTO.dni,
                    nroRuc = PersonaDTO.ruc,
                    telefono = int.Parse(PersonaDTO.telefono.ToString()),
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
                    razonSocial = null
                });
                await Save();
                idPersona = (await _context.Persona
                    .FirstOrDefaultAsync(m => m.dniPersona == PersonaDTO.dni)).idPersona;
                if (PersonaDTO.idTipoEmpleado == 1)
                {
                    Empleado Empleado = new Empleado
                    {
                        cargo = PersonaDTO.cargo,
                        codEmpleado = null,
                        descArea = null,
                        estado = null,
                        fecIngreso = PersonaDTO.fechaIngreso,
                        genero = null,
                        idHorario = 0,
                        idTipoEmpleado = PersonaDTO.idTipoEmpleado,
                        nombres = PersonaDTO.nombres + "" + PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        precio = null,
                        salario = null,
                        idPersona = idPersona
                    };
                    await _context.Empleado.AddAsync(Empleado);
                    await Save();
                }
                if (PersonaDTO.idTipoEmpleado == 2)
                {
                    Medico Medico = new Medico()
                    {
                        idEmpleado = null,
                        idPersona = idPersona,
                        area = PersonaDTO.area,
                        nombres = PersonaDTO.nombres,
                        apellidos = PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        fecIngreso = PersonaDTO.fechaIngreso,
                        nroColegio = PersonaDTO.numeroColegio,
                        cargo = PersonaDTO.cargo,
                        nroRuc = PersonaDTO.ruc,
                        telefono = PersonaDTO.telefono.ToString(),
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
                }
                return "Ingreso Exitoso Persona,Medico,Empleado";
            }
            catch (SqlException ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdatePersona(PersonaDTO PersonaDTO)
        {
            try
            {
                if (PersonaDTO.idTipoEmpleado == 1)
                {
                    Empleado Empleado = new Empleado
                    {
                        idEmpleado = int.Parse(PersonaDTO.idEmpleado.ToString()),
                        cargo = PersonaDTO.cargo,
                        codEmpleado = null,
                        descArea = null,
                        estado = null,
                        fecIngreso = PersonaDTO.fechaIngreso,
                        genero = null,
                        idHorario = 0,
                        idTipoEmpleado = PersonaDTO.idTipoEmpleado,
                        nombres = PersonaDTO.nombres + "" + PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        precio = null,
                        salario = null,
                        idPersona = PersonaDTO.idPersona
                    };
                    _context.Entry(Empleado).State = EntityState.Modified;
                }
                if (PersonaDTO.idTipoEmpleado == 2)
                {
                    Medico Medico = new Medico()
                    {
                        idMedico = int.Parse(PersonaDTO.idMedico.ToString()),
                        idEmpleado = null,
                        area = PersonaDTO.area,
                        nombres = PersonaDTO.nombres,
                        apellidos = PersonaDTO.apellidos,
                        nroDni = PersonaDTO.dni,
                        fecIngreso = PersonaDTO.fechaIngreso,
                        nroColegio = PersonaDTO.numeroColegio,
                        cargo = PersonaDTO.cargo,
                        nroRuc = PersonaDTO.ruc,
                        telefono = PersonaDTO.telefono.ToString(),
                        idEspecialidad = PersonaDTO.idEspecialidad,
                        codMedico = null,
                        condicion = null,
                        especialidad = null,
                        estado = "Activo",
                        nroRne = null,
                        tpDocumento = null
                    };
                    _context.Entry(Medico).State = EntityState.Modified;
                }
                _context.Entry(new Persona()
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
                    iddatoReniec = null,
                    iddatoSiteds = null,
                    iddatoSunat = null,
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
        public async Task<List<PersonaDTO>> GetAllPersonas()
        {
            List<PersonaDTO> Personas = await (from p in _context.Persona
                                            where p.idPersona == (from m in _context.Medico where m.idPersona == p.idPersona select m.idPersona).First() 
                                            || p.idPersona == (from e in _context.Empleado where e.idPersona == p.idPersona select e.idPersona).FirstOrDefault()
                                            select new PersonaDTO
                                            {
                                                idPersona = p.idPersona,
                                                nombres = p.nombres,
                                                apellidos = p.apePaterno + " " + p.apeMaterno,
                                                fechaIngreso = "",
                                                telefono = p.telefono,
                                                cargo = ""
                                            }).ToListAsync();

            return Personas;
        }
        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO Persona = await (from p in _context.Persona
                                     where (p.idPersona == (from m in _context.Medico where m.idPersona == p.idPersona select m.idPersona).First()
                                     || p.idPersona == (from e in _context.Empleado where e.idPersona == p.idPersona select e.idPersona).FirstOrDefault())
                                     && p.idPersona == id
                                     select new PersonaDTO
                                     {
                                         idPersona = p.idPersona,
                                         nombres = p.nombres,
                                         apellidos = p.apePaterno + " " + p.apeMaterno,
                                         fechaIngreso = "",
                                         telefono = p.telefono,
                                         cargo = ""
                                     }).FirstOrDefaultAsync();
            return Persona;
        }
    }

}
