using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Tutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pump> Pumps { get; set; }
        // public DbSet<PumpForecast> PumpForecasts {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Pumps)
                .WithOne(p => p.User)
                .HasForeignKey(pu => pu.UserId)
                .IsRequired();

            modelBuilder.Entity<Pump>()
                .HasOne(e => e.User)
                .WithMany(e => e.Pumps)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            // modelBuilder.Entity<Pump>()
            //     .HasMany(u => u.PumpForecasts)
            //     .WithOne(p => p.Pump)
            //     .HasForeignKey(pu => pu.PumpId)
            //     .IsRequired();
            
            // modelBuilder.Entity<PumpForecast>()
            //     .HasOne(e => e.Pump)
            //     .WithMany(e => e.PumpForecasts)
            //     .HasForeignKey(e => e.PumpId)
            //     .IsRequired();

            var UsersList = new List<User>() {
                    new User {
                        UserId = 1,
                        Username = "test1",
                        Email = "test1@123.com",
                        Password = "test1"
                    }
                };

            var PumpsList = new List<Pump>() {
                new Pump {
                    PumpId = 1,
                    Name = "Pump 1",
                    Type = "Centrifugal Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    PumpId = 2,
                    Name = "Pump 2",
                    Type = "Jet Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    PumpId = 3,
                    Name = "Pump 3",
                    Type = "Piston Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    PumpId = 4,
                    Name = "Pump 4",
                    Type = "Centrifugal Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    PumpId = 5,
                    Name = "Pump 5",
                    Type = "Jet Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    PumpId = 6,
                    Name = "Pump 6",
                    Type = "Jet Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    PumpId = 7,
                    Name = "Pump 7",
                    Type = "Piston Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    PumpId = 8,
                    Name = "Pump 8",
                    Type = "Piston Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    PumpId = 9,
                    Name = "Pump 9",
                    Type = "Centrifugal Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    PumpId = 10,
                    Name = "Pump 10",
                    Type = "Jet Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    PumpId = 11,
                    Name = "Pump 11",
                    Type = "Jet Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    PumpId = 12,
                    Name = "Pump 12",
                    Type = "Centrifugal Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    PumpId = 13,
                    Name = "Pump 13",
                    Type = "Piston Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    PumpId = 14,
                    Name = "Pump 14",
                    Type = "Piston Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    PumpId = 15,
                    Name = "Pump 15",
                    Type = "Centrifugal Pump",
                    Status = true,
                    UserId = 1
                }
            };

            // var PumpForecastList = new List<PumpForecast>() {
            //     new PumpForecast {
            //         Id = 1,
            //         Day = "2022-04-01",
            //         Forecast = 101,
            //         PumpId = 1
            //     }
            // };
                        

            
            modelBuilder.Entity<Pump>().HasData(PumpsList);
            modelBuilder.Entity<User>().HasData(UsersList);
            // modelBuilder.Entity<PumpForecast>().HasData(PumpForecastList); 

        }
    }
}
