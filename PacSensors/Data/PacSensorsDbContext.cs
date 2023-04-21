using Microsoft.EntityFrameworkCore;
using PacSensors.Models;

namespace PacSensors.Data
{
    public class PacSensorsDbContext : DbContext
    {

        public PacSensorsDbContext(DbContextOptions<PacSensorsDbContext> options) : base(options)
        {

        }


        public DbSet<GP_INST> gp1_inst { get; set; }
        public DbSet<GP_OVERVIEW> gp1_overview { get; set; }
    }
}
