using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Controllers
{
    public class CollectionController : Controller
    {
        Repository<Product> pro = new Repository<Product>();
        public ActionResult Index()
        {
            return View("~/Views/Theme/Collection.cshtml",pro.Get());
        }
        [HttpGet]
        public ActionResult GetByCategory(string id)
        {
            ViewBag.products = pro.Get(e => e.CategoryId == id).ToList();
            return View("~/Views/Theme/Collection.cshtml");
        }
    }
}