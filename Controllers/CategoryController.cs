using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_categoryService.GetAll());
        }
        //GET - CREATE
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();

        }

        //POST - CREATE
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {

            if (ModelState.IsValid)
            {
                _categoryService.AddCategory(category);
                return RedirectToAction(nameof(Index));

            }
            return View(category);


        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _categoryService.GetCategory(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            _categoryService.DeleteCategory(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Details(int? id)
        {
            return View(_categoryService.GetCategory(id.Value));
        }
    }
}
