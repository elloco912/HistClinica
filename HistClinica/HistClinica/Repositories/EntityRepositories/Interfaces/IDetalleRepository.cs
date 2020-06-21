using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistClinica.DTO;
using HistClinica.Models;

namespace HistClinica.Repositories.Interfaces
{
    public interface IDetalleRepository
    {
        Task<List<D00_TBDETALLE>> GetAllDetalles(string filtro);
        Task<D00_TBDETALLE> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertDetalle(D00_TBDETALLE Detalle);
        Task<string> UpdateDetalle(D00_TBDETALLE Detalle);
        Task DeleteDetalle(int DetalleID);
        Task<bool> DetalleExists(int? id);
        Task Save();
    }
}
