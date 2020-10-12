using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Skysport_Breakers.Models;

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

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
