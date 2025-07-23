using BookManagementSystemAPI.Dto;
using BookManagementSystemAPI.Models;
using BookManagementSystemAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystemAPI.Controllers
{
    /// <summary>
    /// AUTH API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequest)
        {
            string token = await _authService.Register(registerRequest);
            return StatusCode(201, token);
        }
    }
}
