using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Skysport_Breakers.Models
{
    public class JBRegistration
    {
        //stores data 
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Name" )]
        [Display (Name = " Name :")]
        public string PName { get; set; }


        [Required(ErrorMessage = "Enter Your Email")]
        [Display(Name = " Email :")]
        public string PEmail { get; set; }


        [Required(ErrorMessage = "Enter Your Address")]
        [Display(Name = " Address :")]
        public string PAddress { get; set; }


        [Required(ErrorMessage = "Enter Your Phone Number")]
        [Display(Name = " Phone Number :")]
        public string PPhoneNumber { get; set; }


        [Required(ErrorMessage = "Enter Your Home Number")]
        [Display(Name = " Home Number :")]
        public string PHomeNumber { get; set; }


        [Required(ErrorMessage = "Enter Your Child's  Name")]
        [Display(Name = " Child's Name :")]
        public string CName { get; set; }


        [Required(ErrorMessage = "Enter Your Child's  Age")]
        [Display(Name = " Child's Age :")]
        public string CAge { get; set; }


        [Required(ErrorMessage = "Enter Your Child's Date Of Birth")]
        [Display(Name = " Child's DOB :")]
        public string CDOB { get; set; }


        [Required(ErrorMessage = "Enter Your Child's  Gender")]
        [Display(Name = "  Child's Gender :")]
        public string CGender { get; set; }


        [Required(ErrorMessage = "Enter Skill level")]
        [Display(Name = " Skill Level :")]
        public string SkillLevel { get; set; }
    }
}
