using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweakers.Models;

namespace Tweakers.Controllers
{
    public class ProductController : Controller
    {
        /// <summary>
        /// Method to automatically generate the right view for the corresponding category
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View(Models.Product.FindAllProductsInCategory(id)</returns>
        public ActionResult GenerateProducts(int id)
        {
            return View(Product.FindAllProductsInCategory(id));
        }

        #region ProductCategories
        /// <summary>
        /// All ActionResults for the ProductCategories
        /// </summary>
        public ActionResult ProductCat2()
        {
            return GenerateProducts(2);
        }

        public ActionResult ProductCat3()
        {
            return GenerateProducts(3);
        }

        public ActionResult ProductCat4()
        {
            return GenerateProducts(4);
        }

        public ActionResult ProductCat5()
        {
            return GenerateProducts(5);
        }

        public ActionResult ProductCat6()
        {
            return GenerateProducts(6);
        }

        public ActionResult ProductCat8()
        {
            return GenerateProducts(8);
        }

        public ActionResult ProductCat9()
        {
            return GenerateProducts(9);
        }

        public ActionResult ProductCat10()
        {
            return GenerateProducts(10);
        }

        public ActionResult ProductCat11()
        {
            return GenerateProducts(11);
        }

        public ActionResult ProductCat13()
        {
            return GenerateProducts(13);
        }

        public ActionResult ProductCat15()
        {
            return GenerateProducts(15);
        }

        public ActionResult ProductCat16()
        {
            return GenerateProducts(16);
        }

        public ActionResult ProductCat17()
        {
            return GenerateProducts(17);
        }

        public ActionResult ProductCat18()
        {
            return GenerateProducts(18);
        }

        public ActionResult ProductCat19()
        {
            return GenerateProducts(19);
        }
        #endregion

        #region Products

        public ActionResult Product1(int id)
        {
            Product product = Dictionaries.Products[id];
            return View(product);
        }
        #endregion
    }
}