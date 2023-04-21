using PacSensors.Models;

namespace PacSensors.Repositories
{
    public interface IGP_OVERVIEW_Repository
    {
        Task<GP_OVERVIEW> GetById(int id);
        Task<IEnumerable<GP_OVERVIEW>> GetByDateTime(string dateTime);
        Task<GP_OVERVIEW> GetLast();
    }
}
