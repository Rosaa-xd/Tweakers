using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweakers.Models;

namespace Tweakers.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            if (ValidLogin(name, password))
            {
                ModelState.AddModelError("", "Je bent ingelogd");
                return View();
            }
            ModelState.AddModelError("", "Je bent niet ingelogd");
            return View();
        }
        

        public bool ValidLogin(string name, string password)
        {
            User user = new User().LogIn(name, password);

            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}