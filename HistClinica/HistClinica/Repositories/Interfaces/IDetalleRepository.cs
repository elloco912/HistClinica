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
        Task<List<DetalleDTO>> GetAllDetalles(string filtro);
        Task<DetalleDTO> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertDetalle(DetalleDTO Detalle);
        Task<string> UpdateDetalle(DetalleDTO Detalle);
        Task DeleteDetalle(int DetalleID);
        Task<bool> DetalleExists(int? id);
        Task Save();
    }
}
