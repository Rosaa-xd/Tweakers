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
        public ActionResult PriceWatch()
        {
            List<Category> categories = Category.ReturnAllParentCategories();
            return View(categories);
        }

        public ActionResult Cat1()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat2()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat3()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat4()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat5()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat6()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat7()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat8()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }

        public ActionResult Cat9()
        {
            List<Category> categories = Category.ReturnAllCategories();
            return View(categories);
        }
    }
}