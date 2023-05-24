using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.Entities
{
    public class Retrival : BaseEntity
    {
        public Manager Manager { get; set; }
        public int ManagerId { get; set; }
        public string NameOfAgent { get; set; }
        public string NameOfEquipmentRetrieved { get; set; }
        public DateTime DateRetrieved { get; set; }
        public string NameOfAgentReassignedTo { get; set; }

    }
}
