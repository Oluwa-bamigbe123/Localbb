using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.ViewModel
{
    public class CreateRetrivalVM
    {
       public Retrival Retrivals { get; set; }
        public string NameOfAgent { get; set; }
        public string NameOfEquipmentRetrieved { get; set; }
        public DateTime DateRetrieved { get; set; }
        public string NameOfAgentReassignedTo { get; set; }
    }
}
