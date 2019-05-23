﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCApplication.WebUI.Models
{
    public class Signup
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [RegularExpression("^[A-z0-9]{5,20}$")]
        public string password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("password")]
        public string confirm_password { get; set; }
    }
}