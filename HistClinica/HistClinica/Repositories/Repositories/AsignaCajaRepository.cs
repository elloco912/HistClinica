using HistClinica.Data;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class AsignaCajaRepository:IAsignaCaja
    {
        private readonly ClinicaServiceContext _context;
        public AsignaCajaRepository(ClinicaServiceContext context)
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

        public async Task<bool> AsignaCajaExists(int? id)
        {
            return await _context.T068_CITA.AnyAsync(e => e.idCita == id);
        }
        public async Task<string> InsertAsignaCaja(int idCaja, int idEmpleado)
        {
            try
            {
                await _context.D025_ASIGNACAJA.AddAsync(new D025_ASIGNACAJA()
                {
                    idEmpleado = idEmpleado,
                    idCaja = idCaja
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
