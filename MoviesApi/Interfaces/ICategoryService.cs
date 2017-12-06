using MoviesApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        void AddCategory(Category category);

        void UpdateCategory(Category category);

        void RemoveCategory(int id);
    }
}
