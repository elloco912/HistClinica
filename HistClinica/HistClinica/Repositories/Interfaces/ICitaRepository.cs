using HistClinica.DTO;
using HistClinica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface ICitaRepository
    {
        Task<List<T068_CITA>> GetAllCitas();
        Task<CitaDTO> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertCita(CitaDTO Cita);
        Task<string> AnularCita(int? CitaID);
        Task<string> ReprogramarCita(CitaDTO cita);
        Task DeleteCita(int CitaID);
        Task<bool> CitaExists(int? id);
        Task Save();
    }
}
