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
        // public DbSet<PumpForecast> PumpForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Pumps)
                .WithOne(p => p.User)
                .HasForeignKey(pu => pu.UserId)
                .IsRequired();

            // modelBuilder.Entity<Pump>()
            //     .HasMany(p => p.PumpForecasts)
            //     .WithOne(pf => pf.Pump)
            //     .HasForeignKey(pf => pf.PumpId)
            //     .IsRequired();
            var Users = new List<User>() {
                new User
                    {
                        UserId = 1,
                        Username = "Test1",
                        Email = "test1@123.com",
                        Password = "test1",
                        Pumps = {
                            new Pump () {
                                PumpId = 1,
                                PumpName = "Pump 1",
                                PumpType = "Centrifugal Pump",
                                PumpTime = DateTime.UtcNow.AddDays(1),
                                PumpStatus = true,
                                // PumpForecast = new List<int>() {1, 2, 3, 4, 5, 6}
                            },
                            new Pump () {
                                PumpId = 2,
                                PumpName = "Pump 2",
                                PumpType = "Jet Pump",
                                PumpTime = DateTime.UtcNow.AddDays(2),
                                PumpStatus = false,
                                // PumpForecast = new List<int>() {1, 2, 3, 4, 5, 6}
                            }
                        }
                    },
                    new User
                    {
                        UserId = 2,
                        Username = "Test2",
                        Email = "test2@123.com",
                        Password = "test2",
                        Pumps = {
                            new Pump () {
                                PumpId = 1,
                                PumpName = "Pump 1",
                                PumpType = "Jet Pump",
                                PumpTime = DateTime.UtcNow.AddDays(1),
                                PumpStatus = true,
                                // PumpForecast = new List<int>() {1, 2, 3, 4, 5, 6}
                            },
                            new Pump () {
                                PumpId = 2,
                                PumpName = "Pump 2",
                                PumpType = "Centrifugal Pump",
                                PumpTime = DateTime.UtcNow.AddDays(2),
                                PumpStatus = false,
                                // PumpForecast = new List<int>() {1, 2, 3, 4, 5, 6}
                            }
                        }
                    },
                    new User
                    {
                        UserId = 3,
                        Username = "Test3",
                        Email = "test3@123.com",
                        Password = "test3",
                        Pumps = {
                            new Pump () {
                                PumpId = 1,
                                PumpName = "Pump 1",
                                PumpType = "Centrifugal Pump",
                                PumpTime = DateTime.UtcNow.AddDays(1),
                                PumpStatus = true,
                                // PumpForecast = new List<int>() {1, 2, 3, 4, 5, 6}
                            },
                            new Pump () {
                                PumpId = 2,
                                PumpName = "Pump 2",
                                PumpType = "Jet Pump",
                                PumpTime = DateTime.UtcNow.AddDays(2),
                                PumpStatus = false,
                                // PumpForecast = new List<int>() {1, 2, 3, 4, 5, 6}
                            }
                        }
                    }
                };

            modelBuilder.Entity<User>().HasData(Users);

        }
    }
}