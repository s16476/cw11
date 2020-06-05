using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class MedicinesDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }


        public MedicinesDbContext()
        {

        }

        public MedicinesDbContext(DbContextOptions options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Prescription_Medicament>()
                .HasKey(e => new { e.IdMedicament, e.IdPrescription});

            modelBuilder.Entity<Prescription_Medicament>()
                .Property(e => e.Details)
                .HasMaxLength(100)
                .IsRequired();


            var doctors = new List<Doctor>();
            var doctor1 = new Doctor
            {
                IdDoctor = 1,
                FirstName = "Michał",
                LastName = "Kalisz",
                Email = "mkalisz@zdrowie.pl"
            };
            doctors.Add(doctor1);
            var doctor2 = new Doctor
            {
                IdDoctor = 2,
                FirstName = "Anna",
                LastName = "Górna",
                Email = "agorna@zdrowie.pl"
            };
            doctors.Add(doctor2);


            var patients = new List<Patient>();
            var pat1 = new Patient
            {
                IdPatient = 1,
                FirstName = "Zofia",
                LastName = "Chomczyk",
                Birthdate = DateTime.Now.AddYears(-50)
            };
            patients.Add(pat1);
            var pat2 = new Patient
            {
                IdPatient = 2,
                FirstName = "Ryszard",
                LastName = "Niewiadomski",
                Birthdate = DateTime.Now.AddYears(-30).AddDays(73)
            };
            patients.Add(pat2);
            var pat3 = new Patient
            {
                IdPatient = 3,
                FirstName = "Ewa",
                LastName = "Sarna",
                Birthdate = DateTime.Now.AddYears(-41).AddDays(-131)
            };
            patients.Add(pat3);

            var prescriptions = new List<Prescription>();
            var pre1 = new Prescription
            {
                IdPrescription = 1,
                Date = DateTime.Now.AddDays(-60),
                DueDate = DateTime.Now.AddDays(30),
                IdPatient = 1,
                IdDoctor = 1
            };
            prescriptions.Add(pre1);
            var pre2 = new Prescription
            {
                IdPrescription = 2,
                Date = DateTime.Now.AddDays(-7),
                DueDate = DateTime.Now.AddDays(43),
                IdPatient = 2,
                IdDoctor = 1
            };
            prescriptions.Add(pre2);
            var pre3 = new Prescription
            {
                IdPrescription = 3,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(50),
                IdPatient = 3,
                IdDoctor = 2
            };
            prescriptions.Add(pre3);

            var medicaments = new List<Medicament>();
            var med1 = new Medicament
            {
                IdMedicament = 1,
                Name = "Nerwosol",
                Description = "Lek na nerwy",
                Type = "uspokajające"
            };
            medicaments.Add(med1);
            var med2 = new Medicament
            {
                IdMedicament = 2,
                Name = "Gripomax",
                Description = "Lek na grypę",
                Type = "przeziębienie"
            };
            medicaments.Add(med2);

            var pre_med = new List<Prescription_Medicament>();
            var pm1 = new Prescription_Medicament
            {
                IdMedicament = 1,
                IdPrescription = 1,
                Dose = 100,
                Details = "2x dziennie"
            };
            pre_med.Add(pm1);
            var pm2 = new Prescription_Medicament
            {
                IdMedicament = 1,
                IdPrescription = 2,
                Dose = 50,
                Details = "1x dziennie"
            };
            pre_med.Add(pm2);
            var pm3 = new Prescription_Medicament
            {
                IdMedicament = 2,
                IdPrescription = 1,
                Dose = 85,
                Details = "2x dziennie"
            };
            pre_med.Add(pm3);
            var pm4 = new Prescription_Medicament
            {
                IdMedicament = 2,
                IdPrescription = 3,
                Dose = 1,
                Details = "3x dziennie"
            };
            pre_med.Add(pm4);

            modelBuilder.Entity<Doctor>().HasData(doctors);
            modelBuilder.Entity<Patient>().HasData(patients);
            modelBuilder.Entity<Prescription>().HasData(prescriptions);
            modelBuilder.Entity<Medicament>().HasData(medicaments);
            modelBuilder.Entity<Prescription_Medicament>().HasData(pre_med);

        }

    }
}
