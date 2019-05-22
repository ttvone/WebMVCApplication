using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVCApplication.WebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Signin()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult Signout()
        {
            return View();
        }
    }
}