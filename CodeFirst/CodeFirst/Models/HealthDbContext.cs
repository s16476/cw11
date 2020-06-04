using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class HealthDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }

        public HealthDbContext()
        {

        }

        public HealthDbContext(DbContextOptions options) :base(options)
        {

        }

    }
}
