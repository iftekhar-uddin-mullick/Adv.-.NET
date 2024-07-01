using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Username required!")]
        [StringLength(25, MinimumLength = 5)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required!")]
        [StringLength(50, MinimumLength = 4)]
        public string Password { get; set; }
    }
}