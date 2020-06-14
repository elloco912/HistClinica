using HistClinica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<string> InsertUsuario(string claveUser,string usuRegistra,int idEmpleado);
        Task<bool> UsuarioExists(int? id);
        Task Save();
    }
}
