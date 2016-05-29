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
            return View("User");
        }

        public bool Login(string name, string password)
        {
            User user = Models.User.LogIn(name, password);

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}