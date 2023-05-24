using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models.ViewModel
{
    public class AdminVM
    {

        public class Create
        {
            [Required(ErrorMessage = "First Name is required")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Last Name  is required")]
            public string LastName { get; set; }

            public string MiddleName { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Phone Number is required")]
            public string PhoneNumber { get; set; }

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

        }

    }
}
