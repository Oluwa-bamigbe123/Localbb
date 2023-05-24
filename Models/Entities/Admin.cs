using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.Entities
{
    public class Admin : BaseEntity
    {
        public Admin()
        {
            EquipmentDistribution = new List<AdminEquipmentDistribution>();

        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
          ErrorMessage = "Email is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        [MaxLength(72)]
        public string Password { get; set; }
        public IList<AdminEquipmentDistribution> EquipmentDistribution { get; set; }

    }
}
