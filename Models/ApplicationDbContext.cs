using Microsoft.EntityFrameworkCore;

namespace PalletizingReworked.Models
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\FarmTrace\Database\PalletizingDatabase.sqlite");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ScaleSettings> ScaleSettings { get; set; }
        public DbSet<CreateRun> CreateRun { get; set; }
        public DbSet<Blocks> Blocks { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Count> Count { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Pack> Pack { get; set; }
        public DbSet<PalletRecord> Pallets { get; set; }
    }
}
