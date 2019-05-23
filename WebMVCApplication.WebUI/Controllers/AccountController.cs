using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMVCApplication.Domain.Abstracts;
using WebMVCApplication.Domain.Entities;
using WebMVCApplication.WebUI.Infrastructures;
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

        [HttpPost]
        public ActionResult Signin(Signin model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userLogin = new User { UserEmail = model.email, UserPassword = model.password };
                    userRepository.Signin(userLogin);
                    FormsAuthentication.SetAuthCookie(userLogin.UserEmail, model.remember);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Exception", ex.GetInnerException().Message);
                    return View(model);
                }
            }

            return View(model);
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Signup model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    userRepository.Signup(new User
                    {
                        UserEmail = model.email,
                        UserPassword = model.password
                    });
                    return RedirectToAction("Signin");
                }
                catch (Exception ex)
                {
                    return View("_Error", ex);
                }
            }

            return View(model);
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public RedirectToRouteResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Signin");
        }
    }
}