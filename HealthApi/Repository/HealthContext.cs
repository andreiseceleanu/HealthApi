using HealthApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApi.Context
{
    public class HealthContext : DbContext
    {
        public HealthContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            base.OnModelCreating(builder);

        }

        


        public DbSet<User> Users { get; set; }
        public DbSet<Ailment> Ailments { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
