using HistClinica.DTO;
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
        Task<string> InsertCita(CitaDTO Cita);
        Task<string> AnularCita(int? CitaID);
        Task<string> ReprogramarCita(int? CitaID,int? CronoMedicoID);
        Task DeleteCita(int CitaID);
        Task<bool> CitaExists(int? id);
        Task Save();
    }
}
