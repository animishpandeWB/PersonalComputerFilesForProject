// using Internal;
// using Internal;
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
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(400)]
        public IActionResult GetUsersById(int id)
        {
            if (!_userInterface.UserExists(id))
                return NotFound();

            var user = _userInterface.GetUserById(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateUser([FromBody] User userCreate)
        {
            if (userCreate == null)
            {
                return BadRequest(ModelState);
            }

            var userExistsCheck = _userInterface.GetUserById(userCreate.UserId);
            if (userExistsCheck != null)
            {
                ModelState.AddModelError("", "User already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // userCreate = _userInterface.CreateUser(userCreate);
            if (!_userInterface.CreateUser(userCreate))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("User successfully created");
        }

        // [HttpPost]
        // [Route("checkUserPass")]
        // [ProducesResponseType(204)]
        // [ProducesResponseType(400)]
        // public IActionResult checkUserPass(int userId, string password)
        // {
        //     Console.WriteLine("ABC");
        //     Console.WriteLine(password);
        //     if (password == null)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     bool verifyUserPass = _userInterface.CheckUserLogin(userId, password);
        //     return Ok(verifyUserPass);
        // }
    }
}