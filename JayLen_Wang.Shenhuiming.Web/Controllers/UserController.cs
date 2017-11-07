using JayLen_Wang.Shenhuiming.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayLen_Wang.Shenhuiming.Web.Controllers
{
    [UserAuthorize(false)]
    public class UserController : ControllerBase
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string loginName,string password)
        {
            return SuccessJsonResult();
        }


        public ActionResult Logout()
        {
            HttpContext.ClearAuth();
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string loginName,string Name,string password)
        {
            return SuccessJsonResult();
        }
    }
}