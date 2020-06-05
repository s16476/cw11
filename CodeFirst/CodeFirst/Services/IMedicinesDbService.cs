using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Services
{
    public interface IMedicinesDbService
    {

        Doctor GetDoctor(int id);

        IEnumerable<Doctor> GetDoctors();

        Doctor AddDoctor(Doctor doctor);

        void updateDoctor(Doctor doctor);

        void deleteDoctor(int id);

    }
}
