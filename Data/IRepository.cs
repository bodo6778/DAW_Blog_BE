using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW_Blog_BE.Data
{
    public interface IRepository<TModel> where TModel : class
    {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        void Add(TModel entity);
        void Remove(TModel entity);
    }
}
