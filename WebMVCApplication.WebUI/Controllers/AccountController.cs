using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCApplication.Domain.Abstracts;
using WebMVCApplication.Domain.Entities;
using WebMVCApplication.WebUI.Models;

namespace WebMVCApplication.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository userRepository;
        public AccountController(IUserRepository userRepositoryParam)
        {
            userRepository = userRepositoryParam;
        }

        public ActionResult Signin()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Signup model)
        {
            return Json(model);
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult Signout()
        {
            return View();
        }
    }
}