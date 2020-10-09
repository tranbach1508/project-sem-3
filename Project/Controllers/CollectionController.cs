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
        Repository<Subcategory> sub = new Repository<Subcategory>();
        Repository<Category> cat = new Repository<Category>();
        public ActionResult Index()
        {
            ViewBag.products = pro.Get().ToList();
            ViewBag.category = "All";
            return View("~/Views/Theme/Collection.cshtml");
        }
        [HttpGet]
        public ActionResult GetByCategory(string id)
        {
            ViewBag.products = pro.Get(e => e.CategoryId == id).ToList();
            ViewBag.category = cat.Get(id).Name;
            return View("~/Views/Theme/Collection.cshtml");
        }
        [HttpGet]
        public ActionResult GetBySubcategory(string id)
        {
            ViewBag.products = pro.Get(e => e.SubcategoryId == id).ToList();
            ViewBag.category = sub.Get(id).Name;
            return View("~/Views/Theme/Collection.cshtml");
        }
    }
}