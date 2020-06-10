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
    public class CitaRepository : ICitaRepository
    {
        private readonly ClinicaServiceContext _context;
        public CitaRepository(ClinicaServiceContext context)
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

        public async Task<bool> CitaExists(int? id)
        {
            return await _context.T068_CITA.AnyAsync(e => e.idCita == id);
        }

        public async Task DeleteCita(int CitaID)
        {
            T068_CITA Cita = await _context.T068_CITA.FindAsync(CitaID);
            _context.T068_CITA.Remove(Cita);
            await Save();
        }
        public async Task<string> InsertCita(CitaDTO Cita)
        {
            try
            {
                await _context.T068_CITA.AddAsync(new T068_CITA()
                {
                    idEmpleado = Cita.idEmpleado,
                    idPaciente = Cita.idPaciente,
                    idProgramMedica = Cita.idProgramMedica,
                    fechaCita = DateTime.Parse(Cita.fecha)
                });
                await Save();

                await _context.D015_PAGO.AddAsync(new D015_PAGO()
                {
                    monto = Cita.total,
                    fecRegistro = DateTime.Parse(Cita.fecha + " " + Cita.hora),
                    idCita = 0, //idCita
                    estado = "Pendiente"
                });
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> UpdateCita(T068_CITA Cita)
        {
            try
            {
                _context.Entry(Cita).State = EntityState.Modified;
                await Save();
                return "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<T068_CITA>> GetAllCitas()
        {
            List<T068_CITA> Citas = await (from c in _context.T068_CITA
                                           select new T068_CITA
                                           {
                                               idCita = c.idCita,
                                               codCita = c.codCita,
                                               descripcion = c.descripcion,
                                               coa = c.coa,
                                               descuento = c.descuento,
                                               ejecutado = c.ejecutado,
                                               estadoReprogram = c.estadoReprogram,
                                               fechaCita = c.fechaCita,
                                               idConsultorio = c.idConsultorio,
                                               idEmpleado = c.idEmpleado,
                                               idEstadoCita = c.idEstadoCita,
                                               idEstaGralPac = c.idEstaGralPac,
                                               idEstAtencion = c.idEstAtencion,
                                               idPaciente = c.idPaciente,
                                               idProgramMedica = c.idProgramMedica,
                                               idTpAtencion = c.idTpAtencion,
                                               igv = c.igv,
                                               nroCita = c.nroCita,
                                               nroHC = c.nroHC,
                                               precio = c.precio,
                                               prioridad = c.prioridad,
                                               servicio = c.servicio,
                                               tpAtencion = c.tpAtencion,
                                               ultCie10 = c.ultCie10
                                           }).ToListAsync();

            return Citas;
        }
        public async Task<T068_CITA> GetById(int? Id)
        {
            T068_CITA Cita = await (from c in _context.T068_CITA
                                    where c.idCita == Id
                                    select new T068_CITA
                                    {
                                        idCita = c.idCita,
                                        codCita = c.codCita,
                                        descripcion = c.descripcion,
                                        coa = c.coa,
                                        descuento = c.descuento,
                                        ejecutado = c.ejecutado,
                                        estadoReprogram = c.estadoReprogram,
                                        fechaCita = c.fechaCita,
                                        idConsultorio = c.idConsultorio,
                                        idEmpleado = c.idEmpleado,
                                        idEstadoCita = c.idEstadoCita,
                                        idEstaGralPac = c.idEstaGralPac,
                                        idEstAtencion = c.idEstAtencion,
                                        idPaciente = c.idPaciente,
                                        idProgramMedica = c.idProgramMedica,
                                        idTpAtencion = c.idTpAtencion,
                                        igv = c.igv,
                                        nroCita = c.nroCita,
                                        nroHC = c.nroHC,
                                        precio = c.precio,
                                        prioridad = c.prioridad,
                                        servicio = c.servicio,
                                        tpAtencion = c.tpAtencion,
                                        ultCie10 = c.ultCie10
                                    }).FirstOrDefaultAsync();
            return Cita;
        }
    }
}
