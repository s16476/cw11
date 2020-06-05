using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Services
{
    public interface IMedicinesDbService
    {

        IEnumerable<Doctor> GetDoctors();

    }
}
