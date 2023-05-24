using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using LocalBetBiga.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LocalBetBiga.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IManagerService _managerService;
        private readonly ICategoryService _categoryService;
        private readonly IEquipmentService _equipmentService;
        private readonly IAdminEquipmentDistributionService _adminEquipmentDistribution;
       
        public AdminController(IAdminService adminService, IManagerService managerService, ICategoryService categoryService, IEquipmentService equipmentService, IAdminEquipmentDistributionService adminEquipmentDistribution)
        {
            _adminService = adminService;
            _managerService = managerService;
            _categoryService = categoryService;
            _equipmentService = equipmentService;
            _adminEquipmentDistribution = adminEquipmentDistribution;


        }
        public IActionResult Index()
        {
            return View(_adminService.GetAll());
        }
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AdminVM.Create createVm)
        {
            if (ModelState.IsValid)
            {

                Admin admin = new Admin
                {
                    Email = createVm.Email,
                    FirstName = createVm.FirstName,
                    LastName = createVm.LastName,
                    MiddleName = createVm.MiddleName,
                    Password = createVm.Password,
                    PhoneNumber = createVm.PhoneNumber

                };
                _adminService.AddAdmin(admin);
                return RedirectToAction(nameof(Index));

            }
            return View(createVm);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(AdminVM.Login loginVm)
        {

            if (ModelState.IsValid)
            {
                var admin = _adminService.Login(loginVm.Email, loginVm.Password);
                if (admin == null)
                {
                    ViewBag.Message = "Invalid Username/Password";
                    return View();
                }
                else
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, $"{admin.FirstName}"),
                    new Claim(ClaimTypes.GivenName, $"{admin.FirstName} {admin.LastName}"),
                    new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
                    new Claim(ClaimTypes.Email, admin.Email),
                    new Claim(ClaimTypes.Role, "Admin"),

                };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authenticationProperties = new AuthenticationProperties();
                    var principal = new ClaimsPrincipal(claimsIdentity);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                    return RedirectToAction(nameof(GetAllAssignedEquipment));
                }
            }

            return View(loginVm);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Admin");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Dashboard()
        {

            return View();

        }
        [Authorize(Roles = "Admin")]
        public IActionResult AssignEquipment()
        {
            AssignEquipmentToManagerVM assignEquipmentVM = new AssignEquipmentToManagerVM();

            List<SelectListItem> ManagerNameSelectList = new List<SelectListItem>();
            List<SelectListItem> CategorySelectList = new List<SelectListItem>();
         

            List<Manager> managers = _managerService.GetAll();
            List<Category> categories = _categoryService.GetAll();

         



            foreach (var manager in managers)
            {
                ManagerNameSelectList.Add(new SelectListItem
                {
                    Value = manager.Id.ToString(),
                    Text = manager.UserName
                });
            }
            foreach (var category in categories)
            {
                CategorySelectList.Add(new SelectListItem
                {
                    Value = category.Id.ToString(),
                    Text = category.CategoryName
                });
            }
        


           
            assignEquipmentVM.ManagerNameSelectList = ManagerNameSelectList;
            assignEquipmentVM.CategorySelectList = CategorySelectList;


            return View(assignEquipmentVM);


        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AssignEquipment(AssignEquipmentToManagerVM assignEquipmentVM)
        {
          

            Admin admin = new Admin();

            AdminEquipmentDistribution equipmentDistribution = new AdminEquipmentDistribution();

            Equipments equipment = _equipmentService.FindByTypeAndBrand(assignEquipmentVM.EquipmentType, assignEquipmentVM.BrandName);

            int equipmentId = int.Parse(equipment.Id.ToString());

            int adminId = int.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            int managerId = int.Parse(assignEquipmentVM.ManagerId.ToString());

            Manager manager = _managerService.GetManager(managerId);

            DateTime dateAssigned = DateTime.Parse(assignEquipmentVM.DateAssigned.ToString());

            if (manager == null)
            {
                return View(assignEquipmentVM);
            }
            else
            {

                if(assignEquipmentVM.NumberOfEquipmentAssigned >= equipment.NumberInStore)
                {
                    ViewBag.Message = "Add More Equipment Before Distribution";
                    return View();
                }
                else
                {
                    _adminEquipmentDistribution.CreateDistribution(adminId, assignEquipmentVM.ManagerId, assignEquipmentVM.NumberOfEquipmentAssigned, equipmentId, assignEquipmentVM.DateAssigned);

                    _equipmentService.DeductEquipment(equipmentId, assignEquipmentVM.NumberOfEquipmentAssigned);
                }
               


            }

            return RedirectToAction(nameof(GetAllAssignedEquipment));

        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult GetAllAssignedEquipment()
        {

            return View(_adminEquipmentDistribution.GetAllAssignedEquipments());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ExportToExcel()
        {
            List<AdminEquipmentDistribution> distributions = _adminEquipmentDistribution.GetAllAssignedEquipments();

            var builder = new StringBuilder();

            foreach (var distribution in distributions)
            {
                builder.AppendLine($"{distribution.Equipments.EquipmentType}, {distribution.Equipments.Brand},{distribution.Manager.UserName}, {distribution.NumberOfEquipmentAssigned}, {distribution.DateAssigned}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Distribution.csv");
        }



    }
}
