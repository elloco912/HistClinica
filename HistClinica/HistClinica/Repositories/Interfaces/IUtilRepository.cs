using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IUtilRepository
    {
        Task<object> GetTipo(string nombretipo);
    }
}
