﻿// <auto-generated />
using EF_Tutorial.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Tutorial.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230810055858_NewDBSeed-changed")]
    partial class NewDBSeedchanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Tutorial.Models.Pump", b =>
                {
                    b.Property<int>("PumpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PumpId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PumpId");

                    b.HasIndex("UserId");

                    b.ToTable("Pumps");

                    b.HasData(
                        new
                        {
                            PumpId = 1,
                            Name = "Pump 1",
                            Status = true,
                            Type = "Centrifugal Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 2,
                            Name = "Pump 2",
                            Status = false,
                            Type = "Jet Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 3,
                            Name = "Pump 3",
                            Status = false,
                            Type = "Piston Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 4,
                            Name = "Pump 4",
                            Status = false,
                            Type = "Centrifugal Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 5,
                            Name = "Pump 5",
                            Status = true,
                            Type = "Jet Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 6,
                            Name = "Pump 6",
                            Status = true,
                            Type = "Jet Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 7,
                            Name = "Pump 7",
                            Status = false,
                            Type = "Piston Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 8,
                            Name = "Pump 8",
                            Status = true,
                            Type = "Piston Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 9,
                            Name = "Pump 9",
                            Status = false,
                            Type = "Centrifugal Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 10,
                            Name = "Pump 10",
                            Status = true,
                            Type = "Jet Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 11,
                            Name = "Pump 11",
                            Status = false,
                            Type = "Jet Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 12,
                            Name = "Pump 12",
                            Status = true,
                            Type = "Centrifugal Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 13,
                            Name = "Pump 13",
                            Status = true,
                            Type = "Piston Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 14,
                            Name = "Pump 14",
                            Status = false,
                            Type = "Piston Pump",
                            UserId = 1
                        },
                        new
                        {
                            PumpId = 15,
                            Name = "Pump 15",
                            Status = true,
                            Type = "Centrifugal Pump",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EF_Tutorial.Models.PumpForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Forecast")
                        .HasColumnType("int");

                    b.Property<int>("PumpId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PumpId");

                    b.ToTable("PumpForecast");
                });

            modelBuilder.Entity("EF_Tutorial.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "test1@123.com",
                            Password = "test1",
                            Username = "test1"
                        });
                });

            modelBuilder.Entity("EF_Tutorial.Models.Pump", b =>
                {
                    b.HasOne("EF_Tutorial.Models.User", "User")
                        .WithMany("Pumps")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EF_Tutorial.Models.PumpForecast", b =>
                {
                    b.HasOne("EF_Tutorial.Models.Pump", "Pump")
                        .WithMany("PumpForecasts")
                        .HasForeignKey("PumpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pump");
                });

            modelBuilder.Entity("EF_Tutorial.Models.Pump", b =>
                {
                    b.Navigation("PumpForecasts");
                });

            modelBuilder.Entity("EF_Tutorial.Models.User", b =>
                {
                    b.Navigation("Pumps");
                });
#pragma warning restore 612, 618
        }
    }
}
