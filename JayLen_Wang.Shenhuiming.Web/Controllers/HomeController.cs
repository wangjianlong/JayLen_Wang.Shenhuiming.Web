using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayLen_Wang.Shenhuiming.Web.Controllers
{
    public class HomeController : ControllerBase
    {
        // GET: Home
        public ActionResult Index()
        {
            if (!Identity.IsAuthenticated)
            {
                return Redirect("/user/login");
            }
            return View();
        }
    }
}