using DAW_Blog_BE.Data;
using Microsoft.AspNetCore.Mvc;

namespace DAW_Blog_BE.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IUserRepository _repository;

        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }
        [HttpPost("register")]
        public IActionResult Register()
        {
            
            return Ok("succes");
        }
    }
}