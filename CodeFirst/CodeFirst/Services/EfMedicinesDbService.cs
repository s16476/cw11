using CodeFirst.Models;
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

        public IEnumerable<Doctor> GetDoctors()
        {
            return db.Doctors.ToList();
        }


    }
}
