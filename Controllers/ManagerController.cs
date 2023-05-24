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
    public class ManagerController : Controller
    {
        private readonly IManagerService _managerService;
        private readonly IManagerEquipmentDistributionService _managerEquipmentDistributionService;
        private readonly IAdminEquipmentDistributionService _adminEquipmentDistribution;
        private readonly IEquipmentService _equipmentService;


        public ManagerController(IManagerService managerService, IManagerEquipmentDistributionService managerEquipmentDistributionService, IAdminEquipmentDistributionService adminEquipmentDistributionService, IEquipmentService equipmentService)
        {
            _managerService = managerService;
            _managerEquipmentDistributionService = managerEquipmentDistributionService;
            _adminEquipmentDistribution = adminEquipmentDistributionService;
            _equipmentService = equipmentService;

        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_managerService.GetAll());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();

        }
        // POST CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
  
        public IActionResult Create(ManagerVM.Create createVm)
        {
            if (ModelState.IsValid)
            {
                Manager manager = new Manager
                {
                    UserName = createVm.UserName,
                    Email = createVm.Email,
                    Password = createVm.Password,
                    PhoneNumber = createVm.PhoneNumber,
                    Address = createVm.Address
                    

                };
                _managerService.AddManager(manager);
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(ManagerVM.Login loginVm)
        {
            if (ModelState.IsValid)
            {
                var manager = _managerService.Login(loginVm.Email, loginVm.Password);
                if (manager == null)
                {
                    ViewBag.Message = "Invalid Username/Password";
                    return View();
                }
                else
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, $"{manager.UserName}"),
                    new Claim(ClaimTypes.GivenName, $"{manager.UserName} {manager.Email}"),
                    new Claim(ClaimTypes.NameIdentifier, manager.Id.ToString()),
                    new Claim(ClaimTypes.Email, manager.Email),
                    new Claim(ClaimTypes.MobilePhone, manager.PhoneNumber),
                    new Claim(ClaimTypes.Role, "Manager"),

                };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authenticationProperties = new AuthenticationProperties();
                    var principal = new ClaimsPrincipal(claimsIdentity);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                    return RedirectToAction(nameof(History));
                }
            }

            return View(loginVm);
           


        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Manager");
        }


        [Authorize(Roles = "Manager")]
        public IActionResult Dashboard()
        {

            int managerId = int.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            Manager manager = _managerService.GetManager(managerId);
            return View(manager);

        }

        public IActionResult ViewDetails(ManagerViewDetailsVM managerViewDetails)
        {
            int managerId = int.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            Manager manager = _managerService.GetManager(managerId);

            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;

            Manager managerV = _managerService.FindByUserName(userName);

            string email = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;

            Manager manEmail = _managerService.GetManagerByEmail(email);

            string phoneNumber = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.MobilePhone).Value;

            Manager mgPhone = _managerService.FindByPhoneNumber(phoneNumber);

            managerViewDetails.ManagerId = managerId;
            managerViewDetails.UserName = userName;
            managerViewDetails.Email = email;
            managerViewDetails.PhoneNumber = phoneNumber;


            return View(managerViewDetails);
        }

        public IActionResult ExportToExcel()
        {
            List<ManagerEquipmentDistribution> distributions = _managerEquipmentDistributionService.GetAllAssignedEquipmentByAgentId(int.Parse(User.Claims.FirstOrDefault(cl => cl.Type == ClaimTypes.NameIdentifier).Value));

            var builder = new StringBuilder();

            foreach (var distribution in distributions)
            {
                builder.AppendLine($"{distribution.NameOfAgentAssignedTo}, {distribution.Equipment.EquipmentType}, {distribution.Equipment.Brand},{distribution.NumberOfEquipmentAssigned}, {distribution.ShopAddress}, {distribution.DateAssigned}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Manager Equipment Distribution.csv");
        }

        [HttpGet]
        public IActionResult GetAllAssignedEquipment()
        {
            int managerId = int.Parse(User.Claims.FirstOrDefault(cl => cl.Type == ClaimTypes.NameIdentifier).Value);

            return View(_managerEquipmentDistributionService.GetAllAssignedEquipmentByAgentId(managerId));
        }

        [HttpGet]
        public IActionResult History(int managerId)
        {
            managerId = int.Parse(User.Claims.FirstOrDefault(cl => cl.Type == ClaimTypes.NameIdentifier).Value);

            

            return View(_adminEquipmentDistribution.GetAllAssignedEquipmentByManagerId(managerId));

        }

        [HttpGet]
        public IActionResult AssignEquipmentToAgent()
        {
            AssignEquipmentToAgentVM assignEquipmentVM = new AssignEquipmentToAgentVM();


            List<SelectListItem> EquipmentNameSelectList = new List<SelectListItem>();

            int managerId = int.Parse(User.Claims.FirstOrDefault(cl => cl.Type == ClaimTypes.NameIdentifier).Value);

            List<AdminEquipmentDistribution> equipmentDistributions = _adminEquipmentDistribution.GetAllAssignedEquipmentByManagerId(managerId);

            List<string> distinctEquipments = new List<string>();

            foreach (var equipment in equipmentDistributions)
            {
                if (!distinctEquipments.Contains(equipment.Equipments.EquipmentType))
                {
                    distinctEquipments.Add((equipment.Equipments.EquipmentType));

                    EquipmentNameSelectList.Add(new SelectListItem
                    {
                        Value = equipment.Equipments.EquipmentType,
                        Text = equipment.Equipments.EquipmentType
                    });
                }

                
            }

            assignEquipmentVM.EquipmentNameSelectList = EquipmentNameSelectList;



            return View(assignEquipmentVM);

        }

        [HttpPost]
        public JsonResult GetBrandsByEquipmentType()
        {
            string equipmentType = HttpContext.Request.Cookies.FirstOrDefault(e => e.Key == "equipmentType").Value;

            Console.WriteLine(equipmentType);

            List<String> brands = _adminEquipmentDistribution.GetAllAssignedBrandByEquipmentType(equipmentType);

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

            Console.WriteLine(vm);
            return res;
        }

        [HttpPost]
        public IActionResult AssignEquipmentToAgent(AssignEquipmentToAgentVM assignEquipmentVM)
        {
            ManagerEquipmentDistribution equipmentDistribution = new ManagerEquipmentDistribution();

            Equipments equipment = _equipmentService.FindByTypeAndBrand(assignEquipmentVM.EquipmentType, assignEquipmentVM.BrandName);

            int equipmentId = int.Parse(equipment.Id.ToString());

            int managerId = int.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            string shopAddress = assignEquipmentVM.ShopAddress;


            DateTime dateAssigned = DateTime.Parse(assignEquipmentVM.DateAssigned.ToString());

            Manager manager = _managerService.GetManager(managerId);

            List<AdminEquipmentDistribution> allEquipmentAssigned = _adminEquipmentDistribution.GetAllAssignedEquipmentByManagerId(managerId);

            if (allEquipmentAssigned == null)
            {
                return View(assignEquipmentVM);
            }
            else
            {


                //_managerEquipmentDistributionService.DeductEquipment(equipmentId, assignEquipmentVM.NumberOfEquipmentAssigned, managerId);

                _managerEquipmentDistributionService.CreateDistribution(managerId, assignEquipmentVM.NumberOfEquipmentAssigned, assignEquipmentVM.NameOfAgent, dateAssigned, shopAddress,equipmentId);



            }

            return RedirectToAction(nameof(History));

        }

    }
}
