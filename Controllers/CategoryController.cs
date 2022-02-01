using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Blog_BE.Data;
using Microsoft.AspNetCore.Mvc;

namespace DAW_Blog_BE.Controllers
{
    [Route("api/[category]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("all")]
        public IActionResult GetCategories()
        {
            var category = _repository.GetCategories();
            if (category == null)
            {
                return BadRequest(new { Message = "No categories found." });
            }
            return Ok(category);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _repository.GetCategoryById(id);
            if (category == null)
            {
                return BadRequest(new { Message = "No category found." });
            }
            return Ok(category);
        }
    }
}
