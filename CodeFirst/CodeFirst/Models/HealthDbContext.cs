using CodeFirst.Configurations;
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

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }


        public HealthDbContext()
        {

        }

        public HealthDbContext(DbContextOptions options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Prescription_Medicament>()
                .HasKey(e => e.IdMedicament);

            modelBuilder.Entity<Prescription_Medicament>()
                .HasKey(e => e.IdPrescription);

            modelBuilder.Entity<Prescription_Medicament>()
                .Property(e => e.Details)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Prescription_Medicament>()
                .Property(e => e.Dose)
                .IsRequired(false);










/*            modelBuilder.ApplyConfiguration(new SeedDoctorEfConfiguration());
            modelBuilder.ApplyConfiguration(new SeedMedicamentEfConfiguration());
            modelBuilder.ApplyConfiguration(new SeedPatientEfConfiguration());
            modelBuilder.ApplyConfiguration(new SeedPrescriptionEfConfiguration());
            modelBuilder.ApplyConfiguration(new SeedPrescriptionMedicamentEfConfiguration());*/

        }

    }
}
