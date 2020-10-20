using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Skysport_Breakers.Models;

namespace Skysport_Breakers.Controllers
{
    public class JBRegistrationController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //httpGet
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(JBRegistration JB)
        {
            string connection = @"Server=(localdb)\\mssqllocaldb;Database=(Diya)SkysportBreakers;Trusted_Connection=True;MultipleActiveResultSets=true";
            
            
            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "Insert into JBregistration(PName, PEmail, PAddress, PPhoneNumber, PHomeNumber, CName, CAge, CDOB, CGender, SkillLevel) " +
                    "values (' " + JB.PName + " ' ,  ' " + JB.PEmail + " ' , ' " + JB.PAddress + " ' ,   '" + JB.PPhoneNumber + "' , '" + JB.PHomeNumber + "' ,  " +
                    "'" + JB.CName + "' , '" + JB.CAge + "' , ' " + JB.CDOB + " ' ,   '" + JB.CGender + "' , '" + JB.SkillLevel + "' )";
                using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = "Thank you for registrating your child" + JB.CName + ". We will let get back to you as soon as possible."; 
                }
            }
            return View(JB);
        }
    }
}
