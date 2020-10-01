using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        Repository<Product> pro = new Repository<Product>();
        [HttpGet]
        public ActionResult Index(string id)
        {
            ViewBag.product = pro.Get(id);
            return View("~/Views/Theme/Product.cshtml");
        }
    }
}