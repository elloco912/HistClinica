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
        public async Task<string> InsertEmpleado(PersonaDTO PersonaDTO, int idPersona)
        {
            try
            {
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
                return "Ingreso Exitoso Empleado";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdateEmpleado(PersonaDTO PersonaDTO)
        {
            try
            {
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
