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
    public class PumpForecastController : Controller
    {
        private readonly IPumpForecast _pumpForecastRepository;

        public PumpForecastController(IPumpForecast pumpForecastRepository)
        {
            _pumpForecastRepository = pumpForecastRepository;
        }

        [HttpGet("/{pumpId}")]
        public IActionResult GetPumpForecastsByPumpId(int pumpId)
        {
            var pumpForecasts = _pumpForecastRepository.GetPumpForecastsByPumpId(pumpId);
            if(pumpForecasts == null) {
                return BadRequest("No pumps available");
            }
            return Ok(pumpForecasts);
        }
    }
}