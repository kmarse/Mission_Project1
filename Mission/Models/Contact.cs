using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mission.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please confirm your email")]
        public string confirmEmail { get; set; }

        [Required(ErrorMessage = "Please choose catering package")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please choose catering package")]
        public string message { get; set; }

    }
}