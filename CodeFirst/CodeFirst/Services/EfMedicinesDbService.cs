using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Services
{
    public class EfMedicinesDbService : IMedicinesDbService
    {

        private readonly MedicinesDbContext db;

        public EfMedicinesDbService(MedicinesDbContext ctx)
        {
            db = ctx;
        }

        public Doctor AddDoctor(Doctor doctor)
        {
            db.Attach(doctor);
            db.Entry(doctor).State = EntityState.Added;
            db.SaveChanges();
            return doctor;
        }

        public void deleteDoctor(int id)
        {
            var doc = new Doctor
            {
                IdDoctor = id
            };

            db.Attach(doc);
            db.Remove(doc);
            db.SaveChanges();
        }

        public Doctor GetDoctor(int id)
        {
            return db.Doctors.Find(id);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return db.Doctors.ToList();
        }

        public void updateDoctor(Doctor doctor)
        {
            db.Attach(doctor);
            if (doctor.FirstName != null && doctor.FirstName.Trim().Length > 0)
            {
                db.Entry(doctor).Property("FirstName").IsModified = true;
            }
            if (doctor.LastName != null && doctor.LastName.Trim().Length > 0)
            {
                db.Entry(doctor).Property("LastName").IsModified = true;
            }
            if (doctor.Email != null && doctor.Email.Trim().Length > 0)
            {
                db.Entry(doctor).Property("Email").IsModified = true;
            }

            db.SaveChanges();
        }
    }
}
