using Bussines.Services;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService; // Token üretimi için

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("/Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {

            if (request.Username == "string" && request.Password == "string") 
            {
                var token = _tokenService.GenerateToken("userId");
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
