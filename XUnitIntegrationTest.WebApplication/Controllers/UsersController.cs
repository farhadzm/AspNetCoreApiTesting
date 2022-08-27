using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XUnitIntegrationTest.WebApplication.Models;
using XUnitIntegrationTest.WebApplication.Services;

namespace XUnitIntegrationTest.WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<UserModel> Get()
        {
            return _userService.GetUsers();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);

            if (user is null)
                return NotFound();

            return Ok(user);
        }
    }

}
