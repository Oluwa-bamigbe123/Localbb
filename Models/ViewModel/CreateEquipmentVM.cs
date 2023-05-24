using LocalBetBiga.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.ViewModel
{
    public class CreateEquipmentVM
    {
        [Required]
        public Category Category { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string EquipmentType { get; set; }
        public string Brand { get; set; }
        [Range(2, int.MaxValue, ErrorMessage = "Number Of Equipment Must Be Greater Than 0")]
        public int EquipmentNumber { get; set; }
    }
}
