using LocalBetBiga.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.ViewModel
{
    public class AssignEquipmentToManagerVM
    {
        public string EquipmentType { get; set; }
        public AdminEquipmentDistribution Distributions { get; set; }

        public int CategoryId { get; set; }

        public string BrandName { get;set; }
        public int ManagerId { get; set; }
        public int NumberOfEquipmentAssigned { get; set; }
        public DateTime DateAssigned { get; set; }
        public string ManagerUserName { get; set; }
        public IEnumerable<SelectListItem> EquipmentTypeSelectList { get; set; }
        public IEnumerable<SelectListItem> EquipmentBrandSelectList { get; set; }
        public IEnumerable<SelectListItem> ManagerNameSelectList { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
