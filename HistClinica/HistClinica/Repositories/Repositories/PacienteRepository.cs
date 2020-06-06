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

        public async Task<bool> PacienteExists(int? id)
        {
            return await _context.T001_PACIENTE.AnyAsync(e => e.idPaciente == id);
        }

        public async Task DeletePaciente(int PacienteID)
        {
            T001_PACIENTE Paciente = await _context.T001_PACIENTE.FindAsync(PacienteID);
            _context.T001_PACIENTE.Remove(Paciente);
            await Save();
        }
        public async Task<string> InsertPaciente(T001_PACIENTE Paciente)
        {
            try
            {
                await _context.T001_PACIENTE.AddAsync(Paciente);
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> UpdatePaciente(T001_PACIENTE Paciente)
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
        public async Task<List<T001_PACIENTE>> GetAllPacientes()
        {
            List<T001_PACIENTE> Pacientes = await (  from p in _context.T001_PACIENTE
                                                join o in _context.T000_PERSONA on p.idPersona equals o.idPersona
                                                select new T001_PACIENTE
                                                {
                                                    idPaciente = p.idPaciente,
                                                    codPaciente = p.codPaciente,
                                                    descripcion = p.descripcion,
                                                    dniAcom = p.dniAcom,
                                                    edadAcom = p.edadAcom,
                                                    estado = p.estado,
                                                    idAsegurado = p.idAsegurado,
                                                    idFactorrh = p.idFactorrh,
                                                    idgpoSangre = p.idgpoSangre,
                                                    idPacConvenio = p.idPacConvenio,
                                                    idPersona = p.idPersona,
                                                    idtpPaciente = p.idtpPaciente,
                                                    nombreAcom = p.nombreAcom,
                                                    nrohc = p.nrohc
                                                }).ToListAsync();

            return Pacientes;
        }
        public async Task<T001_PACIENTE> GetByDni(int? Dni)
        {
            T001_PACIENTE Paciente = await ( from p in _context.T001_PACIENTE
                                        join o in _context.T000_PERSONA on p.idPersona equals o.idPersona
                                        where o.dniPersona == Dni
                                        select new T001_PACIENTE
                                        {
                                            idPaciente = p.idPaciente,
                                            codPaciente = p.codPaciente,
                                            descripcion = p.descripcion,
                                            dniAcom = p.dniAcom,
                                            edadAcom = p.edadAcom,
                                            estado = p.estado,
                                            idAsegurado = p.idAsegurado,
                                            idFactorrh = p.idFactorrh,
                                            idgpoSangre = p.idgpoSangre,
                                            idPacConvenio = p.idPacConvenio,
                                            idPersona = p.idPersona,
                                            idtpPaciente = p.idtpPaciente,
                                            nombreAcom = p.nombreAcom,
                                            nrohc = p.nrohc
                                        }).FirstOrDefaultAsync();
            return Paciente;
        }
    }
}
