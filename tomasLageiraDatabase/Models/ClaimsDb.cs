using Microsoft.EntityFrameworkCore;

namespace tomasLageiraDatabase.Models
{
    public class ClaimsDb : DbContext
    {
        public ClaimsDb(DbContextOptions<ClaimsDb> options)
            : base(options) { }

        public DbSet<Claims> Claim => Set<Claims>();


    }
}
