﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tweakers.Controller
{
    public class ProductController : System.Web.Mvc.Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}