using HistClinica.DTO;
using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IPacienteRepository
    {
        Task<List<T001_PACIENTE>> GetAllPacientes();
        Task<T001_PACIENTE> GetByDni(int? dni);
        //Operaciones Transaccionales
        Task<string> InsertPaciente(PersonaDTO Paciente,int idPersona);
        Task<string> UpdatePaciente(PersonaDTO Paciente);
        Task DeletePaciente(int PacienteID);
        Task<bool> PacienteExists(int? id);
        Task Save();
    }
}
