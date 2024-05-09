using Microsoft.EntityFrameworkCore;
using ImobSystem_API.Models;


namespace ImobSystem_API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ImobSystem_API.sqlite");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.id);
            modelBuilder.Entity<Agreement>().HasKey(a => a.id);
            modelBuilder.Entity<House>().HasKey(h => h.id);
            modelBuilder.Entity<Owner>().HasKey(o => o.id);
            modelBuilder.Entity<Tenant>().HasKey(t => t.id);

            /**
             * One to One Relations
             */

            // Agreement & House (One to One)
            modelBuilder.Entity<House>()
                .HasOne(h => h.Agreement)
                .WithOne(a => a.House)
                .HasForeignKey<House>(h => h.id);

            /**
             * Many to Many Relations
             */

            // House & Onwer (Many to Many)
            modelBuilder.Entity<House>()
                .HasMany(h => h.Owners)
                .WithMany(o => o.Houses)
                .UsingEntity(j => j.ToTable("HouseOwner"));

            // Agreement & Tenant (Many to Many)
            modelBuilder.Entity<Agreement>()
                .HasMany(a => a.Tenants)
                .WithMany(t => t.Agreements)
                .UsingEntity(j => j.ToTable("AgreementTenant"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
