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

        public async Task<List<DetalleDTO>> GetAllDetalles(string filtro)
        {
            List<DetalleDTO> listaDetalle = new List<DetalleDTO>();
            if(filtro == "")
            {
                listaDetalle = await (from detalle in _context.D00_TBDETALLE
                                where detalle.idTab == 1
                                select new DetalleDTO
                                {
                                    idDet = detalle.idDet,
                                    coddetTab = detalle.coddetTab,
                                    descripcion = detalle.descripcion
                                }).ToListAsync();
            }
            else
            {
                listaDetalle = await (from detalle in _context.D00_TBDETALLE
                                      where detalle.idTab == 1 && detalle.coddetTab.Contains(filtro)
                                      select new DetalleDTO
                                      {
                                          idDet = detalle.idDet,
                                          coddetTab = detalle.coddetTab,
                                          descripcion = detalle.descripcion
                                      }).ToListAsync();
            }
            return listaDetalle;
        }

        public async Task<DetalleDTO> GetById(int? Id)
        {
            DetalleDTO listaDetalle = new DetalleDTO();
            listaDetalle = await (from detalle in _context.D00_TBDETALLE
                                 where detalle.idTab == 1 && detalle.idDet == Id
                                 select new DetalleDTO
                                 {
                                     idDet = detalle.idDet,
                                     coddetTab = detalle.coddetTab,
                                     descripcion = detalle.descripcion
                                 }).FirstOrDefaultAsync();
            return listaDetalle;
        }

        public async Task<string> InsertDetalle(DetalleDTO Detalle)
        {
            try
            {
                await _context.D00_TBDETALLE.AddAsync(new D00_TBDETALLE()
                {
                    coddetTab = Detalle.coddetTab,
                    descripcion = Detalle.descripcion,
                    idTab = 1
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

        public async Task<string> UpdateDetalle(DetalleDTO Detalle)
        {
            try
            {
                await _context.D00_TBDETALLE.AddAsync(new D00_TBDETALLE()
                {
                    idDet = Detalle.idDet,
                    coddetTab = Detalle.coddetTab,
                    descripcion = Detalle.descripcion,
                    idTab = 1
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
