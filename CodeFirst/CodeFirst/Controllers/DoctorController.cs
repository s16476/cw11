using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return Ok(context.GetDoctors());
        }





    }
}