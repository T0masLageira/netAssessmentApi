using Microsoft.EntityFrameworkCore;

namespace tomasLageiraDatabase.Models
{
    public class OwnersDb : DbContext
    {
        public OwnersDb(DbContextOptions<OwnersDb> options)
            : base(options) { }

        public DbSet<Owners> Owner => Set<Owners>();


    }
}
