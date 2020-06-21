using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class DetalleRepository:IDetalleRepository
    {
        private readonly ClinicaServiceContext _context;
        public DetalleRepository(ClinicaServiceContext context)
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

        public async Task<bool> DetalleExists(int? id)
        {
            return await _context.D00_TBDETALLE.AnyAsync(e => e.idDet == id);
        }

        public async Task<List<D00_TBDETALLE>> GetAllDetalles(string filtro)
        {
            List<D00_TBDETALLE> listaDetalle = new List<D00_TBDETALLE>();
            if(filtro == "")
            {
                listaDetalle = await (from detalle in _context.D00_TBDETALLE
                                where detalle.idTab == 1
                                select new D00_TBDETALLE
                                {
                                    idDet = detalle.idDet,
                                    coddetTab = detalle.coddetTab,
                                    descripcion = detalle.descripcion,
                                    abrev = detalle.abrev,
                                    estado = detalle.estado,
                                    fuente = detalle.fuente,
                                    idTab = detalle.idTab
                                }).ToListAsync();
            }
            else
            {
                listaDetalle = await (from detalle in _context.D00_TBDETALLE
                                      where detalle.idTab == 1 && detalle.coddetTab.Contains(filtro)
                                      select new D00_TBDETALLE
                                      {
                                          idDet = detalle.idDet,
                                          coddetTab = detalle.coddetTab,
                                          descripcion = detalle.descripcion,
                                          abrev = detalle.abrev,
                                          estado = detalle.estado,
                                          fuente = detalle.fuente,
                                          idTab = detalle.idTab
                                      }).ToListAsync();
            }
            return listaDetalle;
        }

        public async Task<D00_TBDETALLE> GetById(int? Id)
        {
            D00_TBDETALLE listaDetalle = new D00_TBDETALLE();
            listaDetalle = await (from detalle in _context.D00_TBDETALLE
                                 where detalle.idTab == 1 && detalle.idDet == Id
                                 select new D00_TBDETALLE
                                 {
                                     idDet = detalle.idDet,
                                     coddetTab = detalle.coddetTab,
                                     descripcion = detalle.descripcion,
                                     abrev = detalle.abrev,
                                     estado = detalle.estado,
                                     fuente = detalle.fuente,
                                     idTab = detalle.idTab
                                 }).FirstOrDefaultAsync();
            return listaDetalle;
        }

        public async Task<string> InsertDetalle(D00_TBDETALLE detalle)
        {
            try
            {
                await _context.D00_TBDETALLE.AddAsync(new D00_TBDETALLE()
                {
                    idDet = detalle.idDet,
                    coddetTab = detalle.coddetTab,
                    descripcion = detalle.descripcion,
                    abrev = detalle.abrev,
                    estado = detalle.estado,
                    fuente = detalle.fuente,
                    idTab = detalle.idTab
                });
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }

        public async Task DeleteDetalle(int DetalleID)
        {
            D00_TBDETALLE Detalle = await _context.D00_TBDETALLE.FindAsync(DetalleID);
            _context.D00_TBDETALLE.Remove(Detalle);
            await Save();
        }

        public async Task<string> UpdateDetalle(D00_TBDETALLE detalle)
        {
            try
            {
                _context.D00_TBDETALLE.Update(new D00_TBDETALLE()
                {
                    idDet = detalle.idDet,
                    coddetTab = detalle.coddetTab,
                    descripcion = detalle.descripcion,
                    abrev = detalle.abrev,
                    estado = detalle.estado,
                    fuente = detalle.fuente,
                    idTab = detalle.idTab
                });
                await Save();
                return "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
    }
}
