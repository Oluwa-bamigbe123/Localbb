using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using LocalBetBiga.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LocalBetBiga.Controllers
{
    public class RetrivalController : Controller
    {
        private readonly IRetrivalService _retrivalService;
        private readonly IManagerService _managerService;

        public RetrivalController(IRetrivalService retrivalService, IManagerService managerService)
        {
            _retrivalService = retrivalService;
            _managerService = managerService;
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_retrivalService.GetAll());
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public IActionResult Create(CreateRetrivalVM createVm)
        {
            Retrival retrival = new Retrival();

            int managerId = int.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

            _retrivalService.AddRetrival(managerId, createVm.NameOfAgent, createVm.NameOfEquipmentRetrieved, createVm.NameOfAgentReassignedTo, createVm.DateRetrieved);

            return RedirectToAction(nameof(GetAllRetrievedEquipment));
        }

        [HttpGet]
        [Authorize(Roles = "Manager")]
        public IActionResult GetAllRetrievedEquipment()
        {
            int managerId = int.Parse(User.Claims.FirstOrDefault(cl => cl.Type == ClaimTypes.NameIdentifier).Value);

            return View(_retrivalService.GetAllRetrivalsByManagerId(managerId));
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult ExportToExcel()
        {
            List<Retrival> retrivals = _retrivalService.GetAll();

            var builder = new StringBuilder();

            foreach (var retrival in retrivals)
            {
                builder.AppendLine($"{retrival.Manager.UserName}, {retrival.NameOfAgent},{retrival.NameOfEquipmentRetrieved}, {retrival.NameOfAgentReassignedTo}, {retrival.DateRetrieved}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Retrivals.csv");
        }
    }
}
