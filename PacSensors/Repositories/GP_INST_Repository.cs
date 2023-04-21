using Microsoft.EntityFrameworkCore;
using PacSensors.Data;
using PacSensors.Models;

namespace PacSensors.Repositories
{
    public class GP_INST_Repository : IGP_INST_Repository
    {

        private readonly PacSensorsDbContext _context;

        public GP_INST_Repository(PacSensorsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GP_INST>> GetByDateTime(string dateTime) => await _context.gp1_inst.Where(g => g.LocalTime == dateTime).ToListAsync();

        public async Task<GP_INST> GetById(int id) => await _context.gp1_inst.Where(g => g.id == id).FirstOrDefaultAsync();

        public async Task<GP_INST> GetLast()
        {
            var lastId = _context.gp1_inst.Max(g=> g.id);
            return await _context.gp1_inst.Where(g => g.id == lastId).SingleOrDefaultAsync();
        }
    }
}
