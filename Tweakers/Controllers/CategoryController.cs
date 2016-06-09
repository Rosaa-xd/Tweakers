using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Tweakers.Models;

namespace Tweakers.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult PriceWatch()
        {
            return View(Category.ReturnAllParentCategories());
        }

        private ViewResult SubCategory(int id)
        {
            if (Category.ReturnAllSubCategories(id).Count != 0)
            {
                return View(Category.ReturnAllSubCategories(id));
            }
            return null;
        }

        public ActionResult Cat1()
        {
            if (SubCategory(1) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(1);
        }

        public ActionResult Cat2()
        {
            if (SubCategory(2) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(2);
        }

        public ActionResult Cat3()
        {
            if(SubCategory(3) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(3);
        }

        public ActionResult Cat4()
        {
            if (SubCategory(4) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(4);
        }

        public ActionResult Cat5()
        {
            if (SubCategory(5) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(5);
        }

        public ActionResult Cat6()
        {
            if (SubCategory(6) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(6);
        }

        public ActionResult Cat7()
        {
            if (SubCategory(7) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(7);
        }

        public ActionResult Cat8()
        {
            if (SubCategory(8) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(8);
        }

        public ActionResult Cat9()
        {
            if (SubCategory(9) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(9);
        }

        public ActionResult Cat10()
        {
            if (SubCategory(10) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(10);
        }

        public ActionResult Cat11()
        {
            if (SubCategory(11) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(11);
        }

        public ActionResult Cat12()
        {
            if (SubCategory(12) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(12);
        }

        public ActionResult Cat13()
        {
            if (SubCategory(13) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(13);
        }

        public ActionResult Cat14()
        {
            if (SubCategory(14) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(14);
        }

        public ActionResult Cat15()
        {
            if (SubCategory(15) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(15);
        }

        public ActionResult Cat16()
        {
            if (SubCategory(16) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(16);
        }

        public ActionResult Cat17()
        {
            if (SubCategory(17) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(17);
        }

        public ActionResult Cat18()
        {
            if (SubCategory(18) == null)
            {
                return RedirectToAction("Product", "Product");
            }
            return SubCategory(18);
        }

        public ActionResult Cat19()
        {
            if (Category.ReturnAllSubCategories(1).Count != 0)
            {
                return View(Category.ReturnAllSubCategories(19));
            }
            return RedirectToAction("Product", "Product");
        }
    }
}