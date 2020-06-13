﻿using HistClinica.Data;
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
            return await _context.T068_CITA.AnyAsync(e => e.idCita == id);
        }
        public async Task<string> InsertUsuario(UsuarioDTO Usuario,int idEmpleado)
        {
            try
            {
                T000_PERSONA persona = await (from p in _context.T000_PERSONA
                                            join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                            where e.idEmpleado == idEmpleado
                                            select p).FirstOrDefaultAsync();
                await _context.D001_USUARIO.AddAsync(new D001_USUARIO()
                {
                    idEmpleado = idEmpleado,
                    fechaRegistra = DateTime.Now.ToString(),
                    loginUser = persona.primerNombre.Substring(0,1) + persona.apePaterno + persona.fecNacimiento.Substring(0,2),
                    claveUser = Usuario.claveUser,
                    usuRegistra = Usuario.usuRegistra,
                    estado = "ACTIVO"
                });
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
    }
}