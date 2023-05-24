using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Entities
{
    public class Manager : BaseEntity
    {
        public Manager()
        {
            AdminEquipmentDistribution = new List<AdminEquipmentDistribution>();
            ManagerEquipmentDistribution = new List<ManagerEquipmentDistribution>();


        }
        public string UserName { get; set; }
      
   
        public string Email { get; set; }
 
        public string PhoneNumber { get; set; }
   
        public string Password { get; set; }

        public string Address { get; set; }
        public IList<AdminEquipmentDistribution> AdminEquipmentDistribution { get; set; }
        public IList<ManagerEquipmentDistribution> ManagerEquipmentDistribution { get; set; }
    }
}
