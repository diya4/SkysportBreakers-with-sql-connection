using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skysport_Breakers.Controllers
{
    public class AdministrationController : Controllers
    {
        public AdministrationController(RoleManage<IdentifyRole> roleManage)
        {
            this.roleManager = roleManage;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return view();
        }
    }
}
