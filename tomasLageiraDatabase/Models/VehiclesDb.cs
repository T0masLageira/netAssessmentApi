using Microsoft.EntityFrameworkCore;

namespace tomasLageiraDatabase.Models
{
    public class VehiclesDb : DbContext
    {
        public VehiclesDb(DbContextOptions<VehiclesDb> options)
            : base(options) { }

        public DbSet<Vehicles> Vehicle => Set<Vehicles>();


    }
}
