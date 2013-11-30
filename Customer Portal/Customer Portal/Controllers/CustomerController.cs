using Customer_Portal.Models;
using Customer_Portal.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Customer_Portal.Controllers
{
    //Can use just [Authorize] to make sure a user is logged in.  If authorizing
    // a specific role, use [Authorize(Roles="role")]
    //[Authorize]
    public class CustomerController : Controller
    {
		AOCustomerDb _db = new AOCustomerDb();

        //
        // GET: /Customer/

        public ActionResult Index()
        {
			//NOTE: In order to use the EAGER loading technique w/ LINQ, use the name of the
			// property that you wish to include the type for (ie: "Type" in the case of Order)
			// Alternatively, use a LINQ statement for the row pointing to the field you wish
			// to include (ie: r => r.Type)
			var model = _db.Orders.Include(r => r.Type).Select(r => r);

            return View(model);
        }

		public ActionResult ReviewOrder(int? id)
		{
			var model = _db.Orders.Include(r => r.Type).FirstOrDefault(r => r.Id == id);
			return View(model);
		}

		// Clean up the connectionton to the DB and anything else that's open
		protected override void Dispose(bool disposing)
		{
			if (_db != null)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}
    }
}
