﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Theme/Home.cshtml");
        }

        public ActionResult Collection()
        {
            return View("~/Views/Theme/Collection.cshtml");
        }

        public ActionResult Cart()
        {
            return View("~/Views/Theme/Cart.cshtml");
        }

        public ActionResult Checkout()
        {
            return View("~/Views/Theme/Checkout.cshtml");
        }

        public ActionResult LoginRegister()
        {
            return View("~/Views/Theme/LoginRegister.cshtml");
        }

        public ActionResult Faq()
        {
            return View("~/Views/Theme/Faq.cshtml");
        }

        public ActionResult Contact()
        {
            return View("~/Views/Theme/Contact.cshtml");
        }
    }
}