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



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ImobSystem_API.sqlite");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Agreement>().HasKey(a => a.Id);
            modelBuilder.Entity<House>().HasKey(h => h.Id);
            modelBuilder.Entity<Owner>().HasKey(o => o.Id);
            modelBuilder.Entity<Tenant>().HasKey(t => t.Id);

            /**
             * One to One Relations
             */

            // Agreement & House (One to One)
            modelBuilder.Entity<House>()
                .HasOne(h => h.Agreement)
                .WithOne(a => a.House)
                .HasForeignKey<House>(h => h.Id);

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

            //// Configurando a tabela de junção (HouseOwner)
            //modelBuilder.Entity<HouseOwner>()
            //    .HasKey(ho => new { ho.HouseId, ho.OwnerId });

            //// Configurando relacionamento entre HouseOwner e House
            //modelBuilder.Entity<HouseOwner>()
            //    .HasOne(ho => ho.House)
            //    .WithMany(h => h.HouseOwners)
            //    .HasForeignKey(ho => ho.HouseId);

            //// Configurando relacionamento entre HouseOwner e Owner
            //modelBuilder.Entity<HouseOwner>()
            //    .HasOne(ho => ho.Owner)
            //    .WithMany(o => o.HouseOwners)
            //    .HasForeignKey(ho => ho.OwnerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
