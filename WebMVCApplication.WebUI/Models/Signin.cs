using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCApplication.WebUI.Models
{
    public class Signin
    {
        [Required]
        [Display(Name = "Email address")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }

        public bool remember { get; set; }
    }
}