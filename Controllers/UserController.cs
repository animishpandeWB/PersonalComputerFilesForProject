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
    public class UserController : Controller
    {
        private readonly IUser _userInterface;
        public UserController(IUser userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        {
            var users = _userInterface.GetUsers();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsersById(int id)
        {
            var user = _userInterface.GetUserById(id);
             if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser(User userCreate)
        {
            if(userCreate == null)
            {
                return BadRequest(ModelState);
            }
            if(_userInterface.UserExists(userCreate.Id) != null) 
            {
                ModelState.AddModelError("", "Owner already exists");
                return StatusCode(422, ModelState);
            }
            userCreate = _userInterface.CreateUser(userCreate);
            // var response = Request.CreateResponse<User>(HttpStatusCode.Created, userCreate);
            // if(!_userInterface.CreateUser(userCreate)) 
            // {
            //     ModelState.AddModelError("", "Something went wrong while saving");
            //     return StatusCode(500, ModelState);
            // }
            return Ok("User successfully created");
        }
    }
}