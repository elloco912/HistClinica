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
    public class MedicoRepository:IMedicoRepository
    {
        private readonly ClinicaServiceContext _context;
        public MedicoRepository(ClinicaServiceContext context)
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

        public async Task<bool> MedicoExists(int? id)
        {
            return await _context.T212_MEDICO.AnyAsync(e => e.idMedico == id);
        }
        public async Task<string> InsertMedico(PersonaDTO PersonaDTO,int idPersona, int idEmpleado)
        {
            try
            {
                T212_MEDICO Medico = new T212_MEDICO()
                {
                    idEmpleado = idEmpleado,
                    idPersona = idPersona,
                    nroColegio = PersonaDTO.numeroColegio,
                    nroRuc = PersonaDTO.ruc,
                    idEspecialidad = PersonaDTO.idEspecialidad,
                    codMedico = null,
                    condicion = null,
                    estado = "Activo",
                    nroRne = null
                };
                await _context.T212_MEDICO.AddAsync(Medico);
                await Save();
                return "Ingreso Exitoso Medico";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdateMedico(PersonaDTO PersonaDTO)
        {
            try
            {
                T212_MEDICO Medico = new T212_MEDICO()
                {
                    idEmpleado = PersonaDTO.idEmpleado,
                    idMedico = int.Parse(PersonaDTO.idMedico.ToString()),
                    nroColegio = PersonaDTO.numeroColegio,
                    nroRuc = PersonaDTO.ruc,
                    idEspecialidad = PersonaDTO.idEspecialidad,
                    codMedico = null,
                    condicion = null,
                    estado = "Activo",
                    nroRne = null,
                    idtpDocumento = null,
                    idPersona = PersonaDTO.idPersona
                };
                _context.Update(Medico);
                await Save();
                return "Actualizacion Exitosa Medico";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }

        public async Task<int> GetIdMedico(int? id)
        {
            int idMedico = await (from p in _context.T212_MEDICO
                                        where p.idPersona == id
                                            select p.idMedico).FirstOrDefaultAsync();
            return idMedico;
        }
    }
}
