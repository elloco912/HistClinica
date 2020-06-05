using HistClinica.DTO;
using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IPersonaRepository
    {
        Task<List<PersonaDTO>> GetAllPersonas();
        Task<PersonaDTO> GetById(int? PersonaID);
        //Operaciones Transaccionales
        Task<string> InsertPersona(PersonaDTO Persona);
        Task<string> UpdatePersona(PersonaDTO Persona);
        Task DeletePersona(int PersonaID);
        Task<bool> PersonaExists(int? id);
        Task Save();
    }
}
