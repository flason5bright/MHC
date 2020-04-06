using MHC.Managers;
using MHC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MHC.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            if (UserManager.Instance.Login(loginViewModel))
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "用户名/密码不正确");

            return View(loginViewModel);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}