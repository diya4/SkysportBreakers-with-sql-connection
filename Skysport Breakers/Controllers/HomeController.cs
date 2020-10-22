using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Skysport_Breakers.Models;

using Microsoft.Data.SqlClient;
using Microsoft.Data;


namespace Skysport_Breakers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactPage()
        {
            return View();
        }

        public IActionResult TeamPage()
        {
            return View();
        }

        public IActionResult Coaches()
        {
            return View();
        }

        public IActionResult Stats()
        {
            return View();
        }

        public IActionResult Videos()
        {
            return View();
        }

        public IActionResult MemberBenifits()
        {
            return View();
        }

        public IActionResult Membership()
        {
            return View();
        }

        public IActionResult MemberUseful()
        {
            return View();
        }

        public IActionResult TermsAndConditions()
        {
            return View();
        }

        public IActionResult Questions()
        {
            return View();
        }

        public IActionResult JBhome()
        {
            return View();
        }

        public IActionResult tickets()
        {
            return View();
        }

        public IActionResult merchHP()
        {
            return View();
        }

        public IActionResult Academy()
        {
            return View();
        }

        public IActionResult JBregistration() 
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
            string connection = "Server=(localdb)\\mssqllocaldb;Database=(Diya)SkysportBreakers;Trusted_Connection=True;MultipleActiveResultSets=true";


            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "Insert into [dbo].[JBregistration](PName, PEmail, PAddress, PPhoneNumber, PHomeNumber, CName, CAge, CDOB, CGender, SkillLevel) " +
                    "values (' " + JB.PName + " ' ,  ' " + JB.PEmail + " ' , ' " + JB.PAddress + " ' ,   '" + JB.PPhoneNumber + "' , '" + JB.PHomeNumber + "' ,  " +
                    "'" + JB.CName + "' , '" + JB.CAge + "' , ' " + JB.CDOB + " ' ,   '" + JB.CGender + "' , '" + JB.SkillLevel + "' )";
                using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                    ViewData["Message"] = "Thank you for registrating your child" + JB.CName + ". We will let get back to you as soon as possible.";
                    return View();
                }
            }
        }

        public IActionResult JBMembership()
        {
            return View();
        }

        public IActionResult JBCamp()
        {
            return View();
        }

        public IActionResult JBSkills()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
