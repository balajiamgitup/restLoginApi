﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter the valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please enter ConfirmPassword")]
        [Display(Name = "confirm password ")]
        [Compare("Password", ErrorMessage = ("confirm password can't matched!"))]
        public string ConfirmPassword { get; set; }

    }
}
