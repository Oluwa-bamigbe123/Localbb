using LocalBetBiga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.ViewModel
{
    public class ManagerVM
    {
        public class Create
        {
            [Required(ErrorMessage = "User Name is required")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Phone Number is required")]
            public string PhoneNumber { get; set; }


            [Required(ErrorMessage = "Address is required")]
            public string Address { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required(ErrorMessage = "Confirm Password is required")]
            [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
            [DataType(DataType.Password)]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }
        }

        public class Login
        {
            [Required(ErrorMessage = "Email is required")]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public class Dashboard
        {
            public Manager Manager { get; set; }
        }
    }
}
