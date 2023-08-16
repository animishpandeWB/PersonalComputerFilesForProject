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
    public class UserAuthController : Controller
    {
        private readonly IUserAuth _userAuthRepository;

        public UserAuthController(IUserAuth userAuthRepository)
        {
            _userAuthRepository = userAuthRepository;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CheckUserLogin(UserAuth userAuth)
        {
            if (userAuth == null)
            {
                return BadRequest("No Data Found in UserAuth");
            }

            bool verifyUserPass = _userAuthRepository.CheckUserLogin(userAuth);
            return Ok(verifyUserPass);
        }
    }
}