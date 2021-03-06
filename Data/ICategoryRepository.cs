using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Blog_BE.Models;

namespace DAW_Blog_BE.Data
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int id);
    }
}
