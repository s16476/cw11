using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.DTO
{
    public class DoctorDTO
    {
        public int IdDoctor { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DoctorDTO(Doctor input)
        {
            IdDoctor = input.IdDoctor;
            FirstName = input.FirstName;
            LastName = input.LastName;
            Email = input.Email;
        }

    }
}
