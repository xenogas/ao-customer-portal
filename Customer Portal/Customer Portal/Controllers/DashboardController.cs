using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_Portal.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
        //
        // Main view of the dashbaord.  This will differ based on the user's role.
        // Will be using an ActionFilte to switch between view based on role:
        // http://www.asp.net/mvc/tutorials/older-versions/controllers-and-routing/understanding-action-filters-cs

        public ActionResult Index()
        {
            return View();
        }

    }
}
