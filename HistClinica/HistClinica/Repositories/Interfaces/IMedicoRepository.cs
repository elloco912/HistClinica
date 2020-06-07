using HistClinica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IMedicoRepository
    {
        /*Task<List<PersonaDTO>> GetAllMedicos();
        Task<PersonaDTO> GetByDni(int? dni);*/
        //Operaciones Transaccionales
        Task<string> InsertMedico(PersonaDTO Medico,int idPersona, int idEmpleado);
        Task<string> UpdateMedico(PersonaDTO Medico);
        /*Task DeleteMedico(int MedicoID);
        Task<bool> MedicoExists(int? id);*/
        Task Save();
    }
}
