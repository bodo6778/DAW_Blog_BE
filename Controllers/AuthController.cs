using System;
using DAW_Blog_BE.Data;
using DAW_Blog_BE.DTOs;
using DAW_Blog_BE.Helpers;
using DAW_Blog_BE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAW_Blog_BE.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly JWTService _jwtService;

        public AuthController(IUserRepository repository, JWTService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;
        }
        [HttpPost("register")]
        public IActionResult Register(RegisterDTO dto)
        {
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
                
            };

            _repository.Create(user);
            return Ok(user);
            //return Created("succes", _repository.Create(user));
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {
            var user = _repository.GetByEmail(dto.Email);

            if (user == null) return BadRequest(new { message = "Invalid Email" });

            if(!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                return BadRequest(new { message = "Invalid Password" });
            }

            var jwt = _jwtService.Generate(user.Id);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true
            });

            return Ok(new { message = "success" }); 
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            try {
                var jwt = Request.Cookies["jwt"];

                var token = _jwtService.Verify(jwt);

                int userId = int.Parse(token.Issuer);

                var user = _repository.GetById(userId);

                return Ok(user);
            } catch(Exception _)
            {
                return Unauthorized();
            }
            

        }
    }
}