using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalBetBiga.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace LocalBetBiga.Models.ViewModel
{
    public class AssignEquipmentToAgentVM
    {
        public string EquipmentType { get; set; }
        public int ManagerId { get; set; }
        [Required]
        public string NameOfAgent { get; set; }
        
        public string BrandName { get; set; }
        public string NameOfEquipmentAssigned { get; set; }

        [Required]
        public string ShopAddress { get; set; }
        public DateTime DateAssigned { get; set; }

        public List<AdminEquipmentDistribution> Equipments { get; set; }

        public IEnumerable<SelectListItem> EquipmentNameSelectList { get; set; }
        public IEnumerable<SelectListItem> EquipmentBrandSelectList { get; set; }
        public int NumberOfEquipmentAssigned { get; set; }
    }
}
