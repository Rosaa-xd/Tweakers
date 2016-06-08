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
        private bool isGenerated;
        public ActionResult PriceWatch()
        {
            if (!isGenerated)
            {
                isGenerated = true;
                List<Category> categories = Category.ReturnAllParentCategories();
                return View(categories);
            }
            return View();
        }

        public ActionResult Cat1()
        {
            List<Category> categories = Category.ReturnAllSubCategories(1);

            if (categories != null)
            {
                return View(categories);
            }
            return RedirectToAction("Product", "Product");
        }

        public ActionResult Cat2()
        {
            List<Category> categories = Category.ReturnAllSubCategories(2);
            return View(categories);
        }

        public ActionResult Cat3()
        {
            List<Category> categories = Category.ReturnAllSubCategories(3);
            return View(categories);
        }

        public ActionResult Cat4()
        {
            List<Category> categories = Category.ReturnAllSubCategories(4);
            return View(categories);
        }

        public ActionResult Cat5()
        {
            List<Category> categories = Category.ReturnAllSubCategories(5);
            return View(categories);
        }

        public ActionResult Cat6()
        {
            List<Category> categories = Category.ReturnAllSubCategories(6);
            return View(categories);
        }

        public ActionResult Cat7()
        {
            List<Category> categories = Category.ReturnAllSubCategories(7);
            return View(categories);
        }

        public ActionResult Cat8()
        {
            List<Category> categories = Category.ReturnAllSubCategories(8);
            return View(categories);
        }

        public ActionResult Cat9()
        {
            List<Category> categories = Category.ReturnAllSubCategories(9);
            return View(categories);
        }

        public ActionResult Cat10()
        {
            List<Category> categories = Category.ReturnAllSubCategories(10);
            return View(categories);
        }

        public ActionResult Cat11()
        {
            List<Category> categories = Category.ReturnAllSubCategories(11);
            return View(categories);
        }

        public ActionResult Cat12()
        {
            List<Category> categories = Category.ReturnAllSubCategories(12);
            return View(categories);
        }

        public ActionResult Cat13()
        {
            List<Category> categories = Category.ReturnAllSubCategories(13);
            return View(categories);
        }

        public ActionResult Cat14()
        {
            List<Category> categories = Category.ReturnAllSubCategories(14);
            return View(categories);
        }

        public ActionResult Cat15()
        {
            List<Category> categories = Category.ReturnAllSubCategories(15);
            return View(categories);
        }

        public ActionResult Cat16()
        {
            List<Category> categories = Category.ReturnAllSubCategories(16);
            return View(categories);
        }

        public ActionResult Cat17()
        {
            List<Category> categories = Category.ReturnAllSubCategories(17);
            return View(categories);
        }

        public ActionResult Cat18()
        {
            List<Category> categories = Category.ReturnAllSubCategories(18);
            return View(categories);
        }

        public ActionResult Cat19()
        {
            List<Category> categories = Category.ReturnAllSubCategories(19);
            return View(categories);
        }
    }
}