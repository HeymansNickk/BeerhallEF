using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BeerhallEF.Data
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=.;Database=Beerhall;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
