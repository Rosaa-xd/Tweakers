using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tweakers.Controller
{
    public class UserListController : System.Web.Mvc.Controller
    {
        // GET: UserList
        public ActionResult Index()
        {
            return View();
        }
    }
}