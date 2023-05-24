using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Entities
{
    public class Admin : BaseEntity
    {
        public Admin()
        {
            EquipmentDistribution = new List<AdminEquipmentDistribution>();

        }

        public string FirstName { get; set; }
   
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    
        public string Email { get; set; }
   
        public string PhoneNumber { get; set; }
      
     
        public string Password { get; set; }
        public IList<AdminEquipmentDistribution> EquipmentDistribution { get; set; }

    }
}
