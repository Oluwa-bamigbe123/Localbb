using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using LocalBetBiga.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IEquipmentService _equipmentService;
        private readonly ICategoryService _categoryService;


        public EquipmentController(IEquipmentService equipmentService, ICategoryService categoryService)
        {
            _equipmentService = equipmentService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View(_equipmentService.GetAll());
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]

        public IActionResult Create()
        {
            CreateEquipmentVM createEquipmentVM = new CreateEquipmentVM();


            List<SelectListItem> CategorySelectList = new List<SelectListItem>();

            List<Category> category = _categoryService.GetAll();


            foreach (var categories in category)
            {
                CategorySelectList.Add(new SelectListItem
                {
                    Value = categories.Id.ToString(),
                    Text = categories.CategoryName
                });
            }

            createEquipmentVM.CategorySelectList = CategorySelectList;



            return View(createEquipmentVM);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateEquipmentVM createEquipmentVM)
        {
            Category category = new Category();
            int categoryId = int.Parse(createEquipmentVM.CategoryId.ToString());

            Equipments equipments = new Equipments
            {
                CategoryId = categoryId,
                Brand = createEquipmentVM.Brand,
                NumberInStore = createEquipmentVM.EquipmentNumber,
                EquipmentType = createEquipmentVM.EquipmentType
            };

            _equipmentService.AddEquipment(equipments);

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipment = _equipmentService.FindEquipmentById(id.Value);
            if (equipment == null)
            {
                return NotFound();
            }
            return View(equipment);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            _equipmentService.DeleteEquipment(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Details(int? id)
        {
            return View(_equipmentService.FindEquipmentById(id.Value));
        }
        [HttpGet]
        public IActionResult Edit(int? id, EditEquipmentVM editEquipment)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipments = _equipmentService.FindEquipmentById(id.Value);
            if (equipments == null)
            {
                return NotFound();
            }
            return View(editEquipment);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id, EditEquipmentVM editEquipment)
        {
            //Equipments equipment = new Equipments();



            int equipmentId = int.Parse(editEquipment.Id.ToString());


            if (id != editEquipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _equipmentService.UpdateEquipmentNumber(id, editEquipment.NumberToBeAdded);
                return RedirectToAction(nameof(Index));
            }
            return View(editEquipment);
        }

        [HttpGet]
        public JsonResult GetEquipmentByCategoryId(int? id)
        { 
            int categoryId = id.Value;

            Console.WriteLine("Fetching.... ");

           List<Equipments> equipments =  _equipmentService.FindByCategoryId(categoryId);

            List<CategoryEquipmentVM> vm = new List<CategoryEquipmentVM>();

            foreach(var equipment in equipments)
            {
                CategoryEquipmentVM categoryEquipmentVM = new CategoryEquipmentVM
                {
                    Id = equipment.Id,
                    EquipmentType = equipment.EquipmentType
                };

                vm.Add(categoryEquipmentVM);
            }

            var res = Json(vm);

            return res;

        }


        [HttpGet]
        public JsonResult GetBrandsByEquipmentType(string id)
        {
            //string equipmentType = HttpContext.Request.Cookies.FirstOrDefault(e => e.Key == "equipmentType").Value;

            //Console.WriteLine(equipmentType);

            var equipmentType = id.Replace('_', ' ');


            List<String> brands = _equipmentService.GetAllBrandByEquipmentType(equipmentType);

            List<EquipmentBrandVM> vm = new List<EquipmentBrandVM>();

            foreach (var brand in brands)
            {
                EquipmentBrandVM equipmentBrandVM = new EquipmentBrandVM
                {
                    BrandName = brand
                   
                };

                vm.Add(equipmentBrandVM);
            }

            var res = Json(vm);

            return res;
        }
    }
}
