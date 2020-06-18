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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ClinicaServiceContext _context;
        public UsuarioRepository(ClinicaServiceContext context)
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

        public async Task<bool> UsuarioExists(int? id)
        {
            return await _context.D001_USUARIO.AnyAsync(e => e.idEmpleado == id);
        }
        public async Task<string> InsertUsuario(PersonaDTO persona)
        {
            T000_PERSONA Persona = await (from p in _context.T000_PERSONA
                                        join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                        where e.idEmpleado == persona.personal.idEmpleado
                                            select p).FirstOrDefaultAsync();
            try
            {
                if (await UsuarioExists(persona.personal.idEmpleado))
                {
                    D001_USUARIO Usuario = await (from u in _context.D001_USUARIO where u.idEmpleado == persona.personal.idEmpleado select u).FirstOrDefaultAsync();
                    return await UpdateUsuario(new D001_USUARIO()
                    {
                        idUsuario = Usuario.idUsuario,
                        idEmpleado = Usuario.idEmpleado,
                        fechaRegistra = Usuario.fechaRegistra,
                        loginUser = Usuario.loginUser,
                        //claveUser = persona.asignacion.claveUser,
                        claveUser = persona.numeroDocumento.ToString(),
                        usuRegistra = Usuario.usuRegistra,
                        estado = Usuario.estado
                    });
                }
                else
                {
                    string fecNacimiento = Persona.fecNacimiento;
                    if (fecNacimiento != null) fecNacimiento = Persona.fecNacimiento.Substring(0, 2);
                    else fecNacimiento = "";
                    await _context.D001_USUARIO.AddAsync(new D001_USUARIO()
                    {
                        idEmpleado = persona.personal.idEmpleado,
                        fechaRegistra = DateTime.Now.ToString(),
                        loginUser = Persona.apePaterno.Substring(0, 1) + Persona.primerNombre + Persona.fecNacimiento.Substring(0, 2),
                        //claveUser = persona.asignacion.claveUser,
                        claveUser = persona.numeroDocumento.ToString(),
                        usuRegistra = persona.asignacion.usuRegistra,
                        estado = "ACTIVO",
                        usuMod = "",
                        fechaMod = ""
                    });
                    await Save();
                    return "Se asigno usuario correctamente";   
                }
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }

        public async Task<string> UpdateUsuario(D001_USUARIO usuario)
        {
            _context.Update(usuario);
            await Save();
            return "Actualizacion Exitosa Usuario";
        }
    }
}
