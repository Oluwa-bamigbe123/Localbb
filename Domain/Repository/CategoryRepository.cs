using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Models;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public Category AddCategory(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var category = _context.Category.Find(id);
            _context.Remove(category);
            _context.SaveChanges();
        }

        public Category FindCategoryById(int id)
        {
            return _context.Category.FirstOrDefault(i => i.Id == id);
        }

        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Category.Find(id);
        }
    }
}
