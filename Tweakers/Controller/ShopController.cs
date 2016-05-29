using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tweakers.Controller
{
    public class ShopController : System.Web.Mvc.Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
    }
}