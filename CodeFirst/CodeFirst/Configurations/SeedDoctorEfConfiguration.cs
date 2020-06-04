using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Configurations
{
    public class SeedDoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            var doctors = new List<Doctor>();
            doctors.Add(new Doctor
            {

            });
            doctors.Add(new Doctor
            {

            });
            doctors.Add(new Doctor
            {

            });

        }

    }
}
