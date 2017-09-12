using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [Display(Name = "User first name")]
        public string UserFirstName { get; set; }

        [Required]
        [Display(Name = "User last name")]
        public string UserLastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Cellphone number")]
        public int? MobileNumber { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email ID")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public virtual State State { get; set; }
    }
}