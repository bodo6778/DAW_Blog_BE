using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Blog_BE.Data;
using Microsoft.AspNetCore.Mvc;

namespace DAW_Blog_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _repository;

        public ArticleController(IArticleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("all")]
        public IActionResult GetAllArticles()
        {
            var articles = _repository.GetArticles();
            if (articles == null)
            {
                return BadRequest(new { Message = "No articles found." });
            }
            return Ok(articles);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var article = _repository.GetArticleById(id);
            if (article == null)
            {
                return BadRequest(new { Message = "No articles found." });
            }
            return Ok(article);
        }
    }
}
