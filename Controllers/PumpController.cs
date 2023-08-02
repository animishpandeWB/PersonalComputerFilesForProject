using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Interface;
using EF_Tutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Tutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PumpController : Controller
    {
        private readonly IPump _pumpRepository;

        public PumpController(IPump pumpRepository)
        {
            _pumpRepository = pumpRepository;
        }

        [HttpGet]
        public IActionResult GetPumps() 
        {
            var pumps = _pumpRepository.GetPumps();
            if(pumps == null) {
                return BadRequest("No pumps available");
            }
            return Ok(pumps);
        }

        [HttpGet("{userId}")]
        public IActionResult GetPumpsByUserId(int userId)
        {
            var pumps = _pumpRepository.GetPumpByUserId(userId);
            if(pumps == null) {
                return BadRequest("No pumps available");
            }
            return Ok(pumps);
        }
    }
}