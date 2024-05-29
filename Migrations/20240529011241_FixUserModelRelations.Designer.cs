﻿// <auto-generated />
using System;
using ImobSystem_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImobSystem_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240529011241_FixUserModelRelations")]
    partial class FixUserModelRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("AgreementTenant", b =>
                {
                    b.Property<uint>("AgreementsId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TenantsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AgreementsId", "TenantsId");

                    b.HasIndex("TenantsId");

                    b.ToTable("AgreementTenant", (string)null);
                });

            modelBuilder.Entity("HouseOwner", b =>
                {
                    b.Property<uint>("HousesId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("OwnersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("HousesId", "OwnersId");

                    b.HasIndex("OwnersId");

                    b.ToTable("HouseOwner", (string)null);
                });

            modelBuilder.Entity("ImobSystem_API.Models.Agreement", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FinalDateAgreement")
                        .HasColumnType("TEXT");

                    b.Property<uint>("HouseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InitDateAgreement")
                        .HasColumnType("TEXT");

                    b.Property<uint>("NumInstallments")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PeriodAgreement")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tenant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("TenantId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.Property<uint>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ValueAgreement")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("ImobSystem_API.Models.House", b =>
                {
                    b.Property<uint>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("Rooms")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Owner", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Age")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<uint>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Tenant", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Age")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<uint>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("ImobSystem_API.Models.User", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Age")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AgreementTenant", b =>
                {
                    b.HasOne("ImobSystem_API.Models.Agreement", null)
                        .WithMany()
                        .HasForeignKey("AgreementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImobSystem_API.Models.Tenant", null)
                        .WithMany()
                        .HasForeignKey("TenantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseOwner", b =>
                {
                    b.HasOne("ImobSystem_API.Models.House", null)
                        .WithMany()
                        .HasForeignKey("HousesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImobSystem_API.Models.Owner", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImobSystem_API.Models.Agreement", b =>
                {
                    b.HasOne("ImobSystem_API.Models.User", "User")
                        .WithMany("Agreements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ImobSystem_API.Models.House", b =>
                {
                    b.HasOne("ImobSystem_API.Models.Agreement", "Agreement")
                        .WithOne("House")
                        .HasForeignKey("ImobSystem_API.Models.House", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImobSystem_API.Models.User", "User")
                        .WithMany("Houses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agreement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Owner", b =>
                {
                    b.HasOne("ImobSystem_API.Models.User", "User")
                        .WithMany("Owners")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Tenant", b =>
                {
                    b.HasOne("ImobSystem_API.Models.User", "User")
                        .WithMany("Tenants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ImobSystem_API.Models.Agreement", b =>
                {
                    b.Navigation("House")
                        .IsRequired();
                });

            modelBuilder.Entity("ImobSystem_API.Models.User", b =>
                {
                    b.Navigation("Agreements");

                    b.Navigation("Houses");

                    b.Navigation("Owners");

                    b.Navigation("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}
