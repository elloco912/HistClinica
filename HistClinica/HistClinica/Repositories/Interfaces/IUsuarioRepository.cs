using HistClinica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<string> InsertUsuario(PersonaDTO persona);
        Task<bool> UsuarioExists(int? id);
        Task Save();
    }
}
