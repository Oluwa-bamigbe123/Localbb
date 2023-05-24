using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Services
{
    public interface ICategoryService
    {
        public Category AddCategory(Category category);
        public Category FindByCategoryId(int id);
        public void DeleteCategory(int id);
        public Category GetCategory(int id);
        public List<Category> GetAll();
    }
}
