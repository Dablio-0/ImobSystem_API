using Microsoft.EntityFrameworkCore;
using ImobSystem_API.Models;


namespace ImobSystem_API.Data
{
    public class AppDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ImobSystem_API.sqlite");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.getId());
            modelBuilder.Entity<Agreement>().HasKey(a => a.GetId());
            modelBuilder.Entity<House>().HasKey(h => h.getId());
            modelBuilder.Entity<Owner>().HasKey(o => o.GetId());
            modelBuilder.Entity<Tenant>().HasKey(t => t.GetId());

            /**
             * One to One Relations
             */

            // Agreement & House (One to One)
            modelBuilder.Entity<House>()
                .HasOne(h => h.GetAgreement())
                .WithOne(a => a.GetHouse())
                .HasForeignKey<House>(h => h.getId());

            /**
             * Many to Many Relations
             */

            // House & Onwer (Many to Many)
            modelBuilder.Entity<House>()
                .HasMany(h => h.GetOwners())
                .WithMany(o => o.GetHouses())
                .UsingEntity(j => j.ToTable("HouseOwner"));

            // Agreement & Tenant (Many to Many)
            modelBuilder.Entity<Agreement>()
                .HasMany(a => a.GetTenants())
                .WithMany(t => t.GetAgreements())
                .UsingEntity(j => j.ToTable("AgreementTenant"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
