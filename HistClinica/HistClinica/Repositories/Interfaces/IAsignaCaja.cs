using HistClinica.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IAsignaCaja
    {
        Task<string> InsertAsignaCaja(PersonaDTO persona);
        Task<bool> AsignaCajaExists(int? id);
        Task Save();
    }
}
