using DAL.Data;
using DAL.Models.DTOs.Users;
using DAL.Models.Enums;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAW.Services.UserService;
using BCryptNet = BCrypt.Net.BCrypt;
using DAW.Helpers.Attributes;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsers());
        }
        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser(UserRequestDto user)
        {
            var userToCreate = new User
            {
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = Role.User,
                Email = user.Email,
                PasswordHash = BCryptNet.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }

        [HttpPost("create-admin")]
        public async Task<IActionResult> CreateAdmin(UserRequestDto user)
        {
            var userToCreate = new User
            {
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = Role.Admin,
                Email = user.Email,
                PasswordHash = BCryptNet.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authentificate(UserRequestDto user)
        {

            var response = _userService.Authentificate(user);
            
            if (response == null)
            {
                return BadRequest("Username or password is invalid!");
            }
            return Ok(response);
        }

        [Authorization(Role.Admin)]
        [HttpGet("admin")]
        public IActionResult CheckAdmin()
        {
            return Ok("admin");
        }

        [Authorization(Role.User)]
        [HttpGet("user")]
        public IActionResult CheckUser()
        {
            return Ok("User");
        }
    }
}
