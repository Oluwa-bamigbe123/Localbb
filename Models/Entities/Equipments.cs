using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.Entities
{
    public class Equipments : BaseEntity
    {
        [Required]
        public string EquipmentType { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Number Of Equipment Must Be Greater Than 0")]
        public int NumberInStore { get; set; }
        public string Brand { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
