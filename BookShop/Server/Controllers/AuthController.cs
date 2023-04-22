using BookShop.Server.Data;
using BookShop.Server.Services.AuthService;
using BookShop.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IHttpContextAccessor _contextAccessor;

        public AuthController(IAuthService authService, IHttpContextAccessor contextAccessor)
        {
            _authService = authService;
            _contextAccessor = contextAccessor;
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResult>> LoginAsync([FromBody] LoginModel loginModel)
        {
            return Ok(await _authService.LoginAsync(loginModel));
        }

        [HttpPost("register")]
        public async Task<ActionResult<LoginModel>> RegistrationAsync([FromBody] RegModel regModel)
        {
            return Ok(await _authService.RegistrationAsync(regModel));
        }      
    }
}
