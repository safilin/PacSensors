using Microsoft.EntityFrameworkCore;
using PacSensors.Data;
using PacSensors.Models;
using System;

namespace PacSensors.Repositories
{
    public class GP_OVERVIEW_Repository : IGP_OVERVIEW_Repository
    {

        private readonly PacSensorsDbContext _context;

        public GP_OVERVIEW_Repository(PacSensorsDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<GP_OVERVIEW>> GetByDateTime(string dateTime) => await _context.gp1_overview.Where(g => g.LocalTime == dateTime).ToListAsync();

        public async Task<GP_OVERVIEW> GetById(int id) => await _context.gp1_overview.Where(g => g.id == id).FirstOrDefaultAsync();

        public async Task<GP_OVERVIEW> GetLast()
        {
            var lastId = _context.gp1_overview.Max(g => g.id);
            return await _context.gp1_overview.Where(g => g.id == lastId).SingleOrDefaultAsync();
        }
    }
}
