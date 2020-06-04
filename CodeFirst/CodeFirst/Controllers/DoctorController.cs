using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private readonly HealthDbContext context;
        public DoctorController(HealthDbContext ctx) 
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok();
        }
    }
}