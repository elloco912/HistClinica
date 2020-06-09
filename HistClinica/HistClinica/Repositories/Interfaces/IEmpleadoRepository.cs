using HistClinica.DTO;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IEmpleadoRepository
    {
        /*Task<List<PersonaDTO>> GetAllMedicos();*/
        Task<int> GetIdEmpleado(int? id);
        //Operaciones Transaccionales
        Task<string> InsertEmpleado(PersonaDTO Empleado, int idPersona);
        Task<string> UpdateEmpleado(PersonaDTO Empleado);
        /*Task DeleteMedico(int MedicoID);
        Task<bool> MedicoExists(int? id);*/
        Task Save();
    }
}
