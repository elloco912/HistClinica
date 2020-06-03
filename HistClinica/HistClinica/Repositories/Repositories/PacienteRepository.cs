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
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ClinicaServiceContext _context;
        public PacienteRepository(ClinicaServiceContext context)
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

        public async Task<bool> PacienteExists(int id)
        {
            return await _context.Paciente.AnyAsync(e => e.idPaciente == id);
        }

        public async Task DeletePaciente(int PacienteID)
        {
            Paciente Paciente = await _context.Paciente.FindAsync(PacienteID);
            _context.Paciente.Remove(Paciente);
            await Save();
        }
        public async Task<string> InsertPaciente(Paciente Paciente)
        {
            try
            {
                await _context.Paciente.AddAsync(Paciente);
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> UpdatePaciente(Paciente Paciente)
        {
            try
            {
                _context.Entry(Paciente).State = EntityState.Modified;
                await Save();
                return "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<Paciente>> GetAllPacientes()
        {
            List<Paciente> Pacientes = await (from p in _context.Paciente
                                                 select new Paciente
                                                 {
                                                     idPaciente = p.idPaciente,
                                                     apePaterno = p.apePaterno,
                                                     apeMaterno = p.apeMaterno
                                                 }).ToListAsync();

            return Pacientes;
        }
        public async Task<Paciente> GetByIdPaciente(int? PacienteID)
        {
            Paciente Paciente = await (from p in _context.Paciente
                                          where p.idPaciente == PacienteID
                                          select new Paciente
                                          {
                                              idPaciente = p.idPaciente,
                                              apePaterno = p.apePaterno,
                                              apeMaterno = p.apeMaterno
                                          }).FirstOrDefaultAsync();
            return Paciente;
        }
    }
}
