using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Skysport_Breakers.Models
{
    public class JbRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
