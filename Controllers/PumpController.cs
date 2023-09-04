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

        [HttpGet("users/{userId}")]
        public IActionResult GetPumpsByUserId(int userId)
        {
            var pumps = _pumpRepository.GetPumpByUserId(userId);
            if(pumps == null) {
                return BadRequest("No pumps available");
            }
            return Ok(pumps);
        }

        [HttpGet("{pumpId}")]
        public IActionResult GetPumpsByPumpId(int pumpId)
        {
            var pumps = _pumpRepository.GetPumpByPumpId(pumpId);
            if(pumps == null) {
                return BadRequest("No pumps available");
            }
            return Ok(pumps);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult AddPump([FromBody] Pump pump) 
        {
            if(pump == null) 
            {
                return BadRequest("Pump is null");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_pumpRepository.AddPump(pump))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }
            
            return Ok("Pump successfully Added");
        }

        [HttpDelete("{pumpId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeletePump(int pumpId) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if(!_pumpRepository.DeletePump(pumpId)) 
            {
                ModelState.AddModelError("", "Something went wrong deleting pump");
            }
            return Ok("Pump deleted successfully");
        }

        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdatePump([FromBody] Pump pump)
        {
            if(_pumpRepository.GetPumpByPumpId(pump.PumpId) == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
                return BadRequest();
            if(!_pumpRepository.UpdatePump(pump))
            {
                ModelState.AddModelError("", "Something went wrong updating pump");
                return StatusCode(500, ModelState);
            }
            return Ok("Successfully updated pump");
        }
    }
}