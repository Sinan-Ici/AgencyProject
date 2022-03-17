using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
   
    public class UserController : Controller
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService; 
        }

        //[Authorize(Roles = "admin")]
        [HttpPost("addagency")]
        public IActionResult AddAgency(User user)
        {

            _userService.AddAgency(user);
            return Ok(user);
            
        }


        [Authorize(Roles = "agency,admin")]
        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(User user)
        {
            _userService.AddCustomer(user);
            return Ok(user);
        }

        [Authorize(Roles = "admin")]
        [HttpPost("deleteagency")]
        public IActionResult DeleteAgency(User user)
        {
            _userService.DeleteAgency(user);
            return Ok(user);
        }

        [Authorize(Roles = "admin")]
        [Authorize(Roles = "agency")]
        [HttpPost("deletecustomer")]
        public IActionResult DeleteCustomer(User user)
        {
            _userService.DeleteCustomer(user);
            return Ok(user);
        }
        [AllowAnonymous]
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            var result= _userService.GetAll();
            return Ok(result);
        }



    }
}
