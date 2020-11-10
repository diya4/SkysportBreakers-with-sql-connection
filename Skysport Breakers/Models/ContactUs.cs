using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Skysport_Breakers.Models
{
    public class ContactUs
    {
        [Required (ErrorMessage = "Enter Name")]
        [Display(Name = "Name : ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email : ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Message")]
        [Display(Name = "Message : ")]
        public string Message { get; set; }
    }
}
