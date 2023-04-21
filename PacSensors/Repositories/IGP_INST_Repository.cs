using PacSensors.Models;

namespace PacSensors.Repositories
{
    public interface IGP_INST_Repository
    {
        Task<GP_INST> GetById(int id);
        Task<IEnumerable<GP_INST>> GetByDateTime(string dateTime);
    }
}
