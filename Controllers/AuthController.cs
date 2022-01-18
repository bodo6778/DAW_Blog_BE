using DAW_Blog_BE.Data;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers
{
    [Route("")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IUserRepository _repository;

        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Hello()
        {
            
            return Ok("succes");
        }
    }
}