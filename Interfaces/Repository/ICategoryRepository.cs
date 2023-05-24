using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface ICategoryRepository
    {
        public Category AddCategory(Category category);
        public Category FindCategoryById(int id);
        public void DeleteCategory(int id);
        public List<Category> GetAll();
        public Category GetCategory(int id);
    }
}
