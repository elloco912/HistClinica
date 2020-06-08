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
    public class EmpleadoRepository: IEmpleadoRepository
    {
        private readonly ClinicaServiceContext _context;
        public EmpleadoRepository(ClinicaServiceContext context)
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

        public async Task<bool> EmpleadoExists(int? id)
        {
            return await _context.T120_EMPLEADO.AnyAsync(e => e.idEmpleado == id);
        }
        public async Task<string> InsertEmpleado(PersonaDTO Persona, int idPersona)
        {
            try
            {
                T120_EMPLEADO Empleado = new T120_EMPLEADO
                {
                    idPersona = idPersona,
                    cargo = Persona.cargo,
                    codEmpleado = Persona.codEmpleado,
                    descArea = Persona.descArea,
                    estado = Persona.estadoPersonal,
                    fecIngreso = Persona.fechaIngreso,
                    genero = Persona.genero,
                    idtpEmpleado = Persona.idTipoEmpleado,
                    precio = Persona.precio,
                    salario = Persona.salario
                };
                await _context.T120_EMPLEADO.AddAsync(Empleado);
                await Save();
                return "Ingreso Exitoso Empleado";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdateEmpleado(PersonaDTO Persona)
        {
            try
            {
                T120_EMPLEADO Empleado = new T120_EMPLEADO
                {
                    idPersona = Persona.idPersona,
                    idEmpleado = (int)Persona.idTipoEmpleado,
                    cargo = Persona.cargo,
                    codEmpleado = Persona.codEmpleado,
                    descArea = Persona.descArea,
                    estado = Persona.estadoPersonal,
                    fecIngreso = Persona.fechaIngreso,
                    genero = Persona.genero,
                    idtpEmpleado = Persona.idTipoEmpleado,
                    precio = Persona.precio,
                    salario = Persona.salario
                };
                _context.Update(Empleado);
                await Save();
                return "Actualizacion Exitosa Empleado";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<int> GetIdEmpleado(int? id)
        {
            int idEmpleado = await (from p in _context.T120_EMPLEADO
                                  where p.idPersona == id
                                  select p.idEmpleado).FirstOrDefaultAsync();
            return idEmpleado;
        }
    }
}
