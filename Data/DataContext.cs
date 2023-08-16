using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text.Json;
// using EF_Tutorial.Models;
using EF_Tutorial.Data;
using EF_Tutorial.Interface;

namespace EF_Tutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pump> Pumps { get; set; }
        public DbSet<JsonData> JsonData { get; set; }

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
            //     .HasMany(j => j.JsonData)
            //     .WithOne(p => p.Pump)
            //     .HasForeignKey(p => p.pumpId)
            //     .IsRequired();

            // modelBuilder.Entity<JsonData>()
            //     .HasOne(p => p.Pump)
            //     .WithMany(j => j.JsonData)
            //     .HasForeignKey(p => p.pumpId)
            //     .IsRequired();


            modelBuilder.Entity<User>()
                .HasKey(x => new { x.Id });

            modelBuilder.Entity<Pump>()
                .HasKey(x => new { x.Id });

            var UsersList = new List<User>() {
                    new User {
                        Id = 1,
                        UserId = 1,
                        Username = "test1",
                        Email = "test1@123.com",
                        Password = "test1"
                    }
                };

            var PumpsList = new List<Pump>() {
                new Pump {
                    Id = 1,
                    PumpId = 1,
                    Name = "Pump 1",
                    Type = "Centrifugal Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    Id = 2,
                    PumpId = 2,
                    Name = "Pump 2",
                    Type = "Jet Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    Id = 3,
                    PumpId = 3,
                    Name = "Pump 3",
                    Type = "Piston Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    Id = 4,
                    PumpId = 4,
                    Name = "Pump 4",
                    Type = "Centrifugal Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    Id = 5,
                    PumpId = 5,
                    Name = "Pump 5",
                    Type = "Jet Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    Id = 6,
                    PumpId = 6,
                    Name = "Pump 6",
                    Type = "Jet Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    Id = 7,
                    PumpId = 7,
                    Name = "Pump 7",
                    Type = "Piston Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    Id = 8,
                    PumpId = 8,
                    Name = "Pump 8",
                    Type = "Piston Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    Id = 9,
                    PumpId = 9,
                    Name = "Pump 9",
                    Type = "Centrifugal Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    Id = 10,
                    PumpId = 10,
                    Name = "Pump 10",
                    Type = "Jet Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    Id = 11,
                    PumpId = 11,
                    Name = "Pump 11",
                    Type = "Jet Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    Id = 12,
                    PumpId = 12,
                    Name = "Pump 12",
                    Type = "Centrifugal Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    Id = 13,
                    PumpId = 13,
                    Name = "Pump 13",
                    Type = "Piston Pump",
                    Status = true,
                    UserId = 1
                },
                new Pump {
                    Id = 14,
                    PumpId = 14,
                    Name = "Pump 14",
                    Type = "Piston Pump",
                    Status = false,
                    UserId = 1
                },
                new Pump {
                    Id = 15,
                    PumpId = 15,
                    Name = "Pump 15",
                    Type = "Centrifugal Pump",
                    Status = true,
                    UserId = 1
                }
            };
            string jsonFile = File.ReadAllText(@"./Repository/TimeSeriesData.json");
            var pumpForecastData = JsonSerializer.Deserialize<List<JsonData>>(jsonFile);
            var addData = new List<JsonData>();
            int jsonDataId = 1;
            foreach (var item in pumpForecastData)
            {
                addData.Add(new JsonData
                {
                    id = jsonDataId++,
                    jsonId = item.id,
                    date = item.date,
                    value1 = item.value1,
                    value2 = item.value2
                });
            }



            modelBuilder.Entity<Pump>().HasData(PumpsList);
            modelBuilder.Entity<User>().HasData(UsersList);
            foreach (var d in addData)
            {
                modelBuilder.Entity<JsonData>().HasData(d);
            }


        }
    }
}
