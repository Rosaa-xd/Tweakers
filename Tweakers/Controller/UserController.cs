using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tweakers.Controller
{
    public class UserController : System.Web.Mvc.Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}