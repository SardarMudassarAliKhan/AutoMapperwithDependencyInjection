using AutoMapperwithDependencyInjection.Models;
using AutoMapperwithDependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperwithDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var user = new User { Id = 1, FullName = "Mudassar Ali" };
            var dto = _userService.GetUserDto(user);
            return Ok(dto);
        }
    }
}
