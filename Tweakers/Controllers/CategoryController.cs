using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweakers.Models;

namespace Tweakers.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PriceWatch()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }
    }
}