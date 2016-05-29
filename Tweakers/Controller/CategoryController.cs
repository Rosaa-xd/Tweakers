using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tweakers.Controller
{
    public class CategoryController : System.Web.Mvc.Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}