using System;
using System.Collections.Generic;
using System.Text;
using BeerhallEF.Data.Mapping;
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerhallEF.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Brewer> Brewers { get; set; }
        //public DbSet<Beer> Beers { get; set; }
        public DbSet<Location> Locations { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=.;Database=Beerhall;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
            modelBuilder.ApplyConfiguration(new BeerConfiguration());
        }
    }
}
