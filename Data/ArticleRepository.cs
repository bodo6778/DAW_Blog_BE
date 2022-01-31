using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Blog_BE.Models;

namespace DAW_Blog_BE.Data
{
    public class ArticleRepository: IArticleRepository
    {
        private readonly UserContext _context;

        public ArticleRepository(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<Article> GetArticles()
        {
            return _context.Articles.ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(u => u.Id == id);
        }

        
    }
}
