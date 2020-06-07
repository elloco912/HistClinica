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
        public async Task<string> InsertPaciente(PersonaDTO PersonaDTO,int idPersona)
        {
            try
            {
                await _context.T001_PACIENTE.AddAsync(new T001_PACIENTE()
                {
                    idPersona = idPersona,
                    codPaciente = "",
                    descripcion = "",
                    dniAcom = 0,
                    edadAcom = 0,
                    estado = "",
                    idAsegurado = 0,
                    idFactorrh = 0,
                    idgpoSangre = 0,
                    idPacConvenio = 0,
                    idPaciente = 0,
                    idtpPaciente = 0,
                    nombreAcom = "",
                    nrohc = 0
                }
                );
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> UpdatePaciente(PersonaDTO PersonaDTO)
        {
            try
            {
                _context.Update(new T001_PACIENTE()
                {
                    
                }
                );
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
            List<T001_PACIENTE> Pacientes = await (from p in _context.T001_PACIENTE
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
            T001_PACIENTE Paciente = await (from p in _context.T001_PACIENTE
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
