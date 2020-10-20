using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Skysport_Breakers.Models
{
    public class JBRegistration
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Name" )]
        [Display (Name = "Enter Name :")]
        public string PName { get; set; }


        [Required(ErrorMessage = "Enter Your Email")]
        [Display(Name = "Enter Email :")]
        public string PEmail { get; set; }


        [Required(ErrorMessage = "Enter Your Address")]
        [Display(Name = "Enter Address :")]
        public string PAddress { get; set; }


        [Required(ErrorMessage = "Enter Your Phone Number")]
        [Display(Name = "Enter Phone Number :")]
        public string PPhoneNumber { get; set; }


        [Required(ErrorMessage = "Enter Your Home Number")]
        [Display(Name = "Enter Home Number :")]
        public string PHomeNumber { get; set; }


        [Required(ErrorMessage = "Enter Your Child's  Name")]
        [Display(Name = "Enter Child's Name :")]
        public string CName { get; set; }


        [Required(ErrorMessage = "Enter Your Child's  Age")]
        [Display(Name = "Enter Child's Age :")]
        public string CAge { get; set; }


        [Required(ErrorMessage = "Enter Your Child's Date Of Birth")]
        [Display(Name = "Enter Child's DOB :")]
        public string CDOB { get; set; }


        [Required(ErrorMessage = "Enter Your Child's  Gender")]
        [Display(Name = "Please Select Child's Gender :")]
        public char CGender { get; set; }


        [Required(ErrorMessage = "Enter Skill level")]
        [Display(Name = "Enter Skill Level :")]
        public string SkillLevel { get; set; }
    }
}
