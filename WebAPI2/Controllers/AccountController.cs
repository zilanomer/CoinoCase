using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
        public IActionResult Register(UserRegisterDto userDto)
        {
            User user = new User();
            if (user != null)
            {
                user.Name = userDto.Name;
                user.SurName = userDto.SurName;
                user.Email = userDto.Email;
                user.Phone = userDto.Phone;
                user.Password = userDto.Password;
                user.Address = userDto.Address;
                user.CreateDate = DateTime.Now;
                user.Status = 1;
            }

            var result = _userService.RegisterUser(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginDto userDto)
        {


            User user = new User();
            if (user != null)
            {
                user.Email = userDto.Email;
                user.Password = userDto.Password;
            }

            var result = _userService.LoginUser(user);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
