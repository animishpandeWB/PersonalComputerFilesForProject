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
    public class JsonDataController : Controller
    {
        private readonly IJsondata _jsonRepository;
        public JsonDataController(IJsondata jsonRepository)
        {
            _jsonRepository = jsonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetJsonData()
        {
            var data = _jsonRepository.GetJsonData();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetJsonDataById(int id)
        {
            var data = _jsonRepository.GetJsonDataById(id);
            if(data == null)
                return BadRequest("No Data for Id");
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(data);
        }
    }
}