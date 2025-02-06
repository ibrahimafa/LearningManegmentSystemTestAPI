using ClassLibrary.Core.Data;
using ClassLibrary.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningManegmentSystemTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService iauthService;
        public AuthController(IAuthService _iauthService) 
        {
            iauthService = _iauthService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Login login)
        {
            var result = iauthService.Login(login);
            if (result == null) return Unauthorized("Invaled");
            return Ok(result);
        }
    }
}
