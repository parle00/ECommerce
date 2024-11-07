using Bussines.Services;
using Core.Services;
using Core.DTOs.User;
using Core.UserInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService; // Token üretimi için
        private readonly IUserService _userService;

        public AuthController(TokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }

        [HttpPost("/Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {

            var user = await _userService.ValidateUserAsync(request.Username, request.Password);


            if (user == null)
                return Unauthorized();

            var response = new UserLoginDTO()
            {
                Email=user.Email,
                Token= _tokenService.GenerateToken(user.UserId.ToString()),
                UserId=user.UserId,
                Username=user.Username
            };


            return Ok(response);
        }

        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
