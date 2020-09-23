using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDAL.DataModels;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public ShopContext db = new ShopContext();
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
    }
}