using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.ViewModel
{
    public class EditEquipmentVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberToBeAdded { get; set; }
    }
}
