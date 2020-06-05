using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.DTO;
using CodeFirst.Models;
using CodeFirst.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private readonly IMedicinesDbService context;
        public DoctorController(IMedicinesDbService ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            var dc = context.GetDoctors();
            var res = new List<DoctorDTO>();
            foreach(Doctor d in dc)
            {
                res.Add(new DoctorDTO(d));
            }
            return Ok(res);
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            return Ok(new DoctorDTO(context.GetDoctor(id)));
        }

        [HttpPost]
        public IActionResult CreateDoctor(Doctor doctor)
        {
            var res = new DoctorDTO(context.AddDoctor(doctor));
            return Ok(res);
        }

        [HttpPut]
        public IActionResult UpdateDoctor(Doctor doctor)
        {
            context.updateDoctor(doctor);
            return Ok("Doctor " + doctor.IdDoctor + " updated!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            context.deleteDoctor(id);
            return Ok("Doctor " + id + " deleted!");
        }

    }
}