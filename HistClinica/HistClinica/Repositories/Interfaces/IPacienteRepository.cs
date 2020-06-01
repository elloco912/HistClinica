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
        Task<Paciente> GetByIdPaciente(int PacienteID);
        //Operaciones Transaccionales
        Task<string> InsertPaciente(Paciente Order);
        Task<string> UpdatePaciente(Paciente Order);
        Task DeletePaciente(int PacienteID);
        Task Save();
    }
}
