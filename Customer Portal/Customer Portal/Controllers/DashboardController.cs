using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_Portal.Controllers
{
    //Can use just [Authorize] to make sure a user is logged in.  If authorizing
    // a specific role, use [Authorize(Roles="role")]
    //[Authorize]
    public class DashboardController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }

    }
}
