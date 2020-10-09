﻿using Project.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        CategoryController cc = new CategoryController();
        Repository<Product> pro = new Repository<Product>();
        public ActionResult Index()
        {
            ViewBag.products = pro.Get().ToList();
            ViewBag.category = "All";
            return View("~/Views/Theme/Home.cshtml");
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

        public JsonResult GetCategories()
        {
            return cc.Get();
        }
    }
}