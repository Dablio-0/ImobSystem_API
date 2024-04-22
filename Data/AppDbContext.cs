using Microsoft.EntityFrameworkCore;
using ImobSystem_API.Models;


namespace ImobSystem_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<House> House { get; set; }
    }
}
