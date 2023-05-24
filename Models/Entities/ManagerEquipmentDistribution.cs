using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.Entities
{
    public class ManagerEquipmentDistribution : BaseEntity
    {
        public Manager Manager { get; set; }
        public Equipments Equipment { get; set; }
        public int EquipmentId { get; set; }
        public int ManagerId { get; set; }
        public string NameOfAgentAssignedTo { get; set; }
        public int NumberOfEquipmentAssigned { get; set; }
        public string ShopAddress { get; set; }
        public DateTime DateAssigned { get; set; }
    }
}
