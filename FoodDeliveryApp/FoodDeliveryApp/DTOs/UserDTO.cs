using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodDeliveryApp.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z-]*$", ErrorMessage = "First Name can only contain letters and hyphens.")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z-]*$", ErrorMessage = "Last Name can only contain letters and hyphens.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).*$", ErrorMessage = "Password must contain at least 1 capital letter, 1 small letter, and 1 number.")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm Password must match Password.")]
        public string ConfirmPassword { get; set; }
        public string Type { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone number can only contain numbers.")]
        [StringLength(11, MinimumLength = 11)]
        public string Phone { get; set; }
    }
}