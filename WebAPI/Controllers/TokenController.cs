using Business.Abstract;
using Core.Helper;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User user)
        {

            var userToCheck = _userService.GetByName(user.UserName);
            var passwordToCheck = _userService.GetByPassword(user.Password);

            if (userToCheck == null || passwordToCheck == null)
                return NotFound(new { message = "User or password invalid" });

            var token = TokenService.CreateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }

}
