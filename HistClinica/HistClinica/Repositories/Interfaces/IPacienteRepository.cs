using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IPacienteRepository
    {
        Task<List<Paciente>> GetAllPacientes();
        Task<Paciente> GetByDni(int? dni);
        //Operaciones Transaccionales
        Task<string> InsertPaciente(Paciente Order);
        Task<string> UpdatePaciente(Paciente Order);
        Task DeletePaciente(int PacienteID);
        Task<bool> PacienteExists(int? id);
        Task Save();
    }
}
