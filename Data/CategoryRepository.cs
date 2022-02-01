using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Blog_BE.Models;

namespace DAW_Blog_BE.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly UserContext _context;

        public CategoryRepository(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(u => u.Id == id);
        }
    }
}
