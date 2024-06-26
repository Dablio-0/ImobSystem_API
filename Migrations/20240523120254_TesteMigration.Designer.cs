﻿// <auto-generated />
using ImobSystem_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImobSystem_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240523120254_TesteMigration")]
    partial class TesteMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("AgreementTenant", b =>
                {
                    b.Property<uint>("Agreementsid")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Tenantsid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Agreementsid", "Tenantsid");

                    b.HasIndex("Tenantsid");

                    b.ToTable("AgreementTenant", (string)null);
                });

            modelBuilder.Entity("HouseOwner", b =>
                {
                    b.Property<uint>("Housesid")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Ownersid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Housesid", "Ownersid");

                    b.HasIndex("Ownersid");

                    b.ToTable("HouseOwner", (string)null);
                });

            modelBuilder.Entity("ImobSystem_API.Models.Agreement", b =>
                {
                    b.Property<uint>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("ImobSystem_API.Models.House", b =>
                {
                    b.Property<uint>("id")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Owner", b =>
                {
                    b.Property<uint>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Tenant", b =>
                {
                    b.Property<uint>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("ImobSystem_API.Models.User", b =>
                {
                    b.Property<uint>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AgreementTenant", b =>
                {
                    b.HasOne("ImobSystem_API.Models.Agreement", null)
                        .WithMany()
                        .HasForeignKey("Agreementsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImobSystem_API.Models.Tenant", null)
                        .WithMany()
                        .HasForeignKey("Tenantsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseOwner", b =>
                {
                    b.HasOne("ImobSystem_API.Models.House", null)
                        .WithMany()
                        .HasForeignKey("Housesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImobSystem_API.Models.Owner", null)
                        .WithMany()
                        .HasForeignKey("Ownersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImobSystem_API.Models.House", b =>
                {
                    b.HasOne("ImobSystem_API.Models.Agreement", "Agreement")
                        .WithOne("House")
                        .HasForeignKey("ImobSystem_API.Models.House", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agreement");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Agreement", b =>
                {
                    b.Navigation("House");
                });
#pragma warning restore 612, 618
        }
    }
}
