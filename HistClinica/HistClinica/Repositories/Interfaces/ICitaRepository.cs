using HistClinica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface ICitaRepository
    {
        Task<List<T068_CITA>> GetAllCitas();
        Task<T068_CITA> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertCita(T068_CITA Cita);
        Task<string> UpdateCita(T068_CITA Cita);
        Task DeleteCita(int CitaID);
        Task<bool> CitaExists(int? id);
        Task Save();
    }
}
