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
   
    public class AdminController : Controller
    {
        IUserService _userService;
        public AdminController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("addagency")]
        public IActionResult AddAgency(User user)
        {

            _userService.AddAgency(user);
            return Ok(user);
            
        }
        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(User user)
        {
            _userService.AddCustomer(user);
            return Ok(user);
        }
        [HttpPost("deleteagency")]
        public IActionResult DeleteAgency(User user)
        {
            _userService.DeleteAgency(user);
            return Ok(user);
        }
        [HttpPost("deletecustomer")]
        public IActionResult DeleteCustomer(User user)
        {
            _userService.DeleteCustomer(user);
            return Ok(user);
        }
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            var result= _userService.GetAll();
            return Ok(result);
        }



    }
}
