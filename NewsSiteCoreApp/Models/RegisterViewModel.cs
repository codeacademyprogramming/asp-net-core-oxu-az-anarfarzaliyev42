using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteCoreApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Remote(action: "IsUsernameInUse",controller:"Account")]
        public string Username { get; set; }
        [Required]
        [Remote(action: "IsEmailInUse","Account")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Required(ErrorMessage ="Repeat password required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords not same")]
        public string ConfirmPassword { get; set; }
        [Required]
        public bool isAgree { get; set; }
    }
}
