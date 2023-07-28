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
        public DbSet<PumpForecast> PumpForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PumpForecast>()
             .HasNoKey();

            modelBuilder.Entity<Pump>()
             .HasMany(p => p.PumpForecasts);


        }
    }
}