using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Entities
{
    public class Equipments : BaseEntity
    {
   
        public string EquipmentType { get; set; }

        public int NumberInStore { get; set; }
        public string Brand { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
