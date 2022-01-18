using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers
{
    [Route("")]
    [ApiController]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("succes");
        }
    }
}