using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Entities
{
    public class AdminEquipmentDistribution : BaseEntity
    {
        public Equipments Equipments { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int EquipmentsId { get; set; }
        public Manager Manager { get; set; }
    
        public int ManagerId { get; set; }
        public Admin Admin { get; set; }

        public int AdminId { get; set; }

   
        public DateTime DateAssigned { get; set; }

        public int NumberOfEquipmentAssigned { get; set; }
    }
}
