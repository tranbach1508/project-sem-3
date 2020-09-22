using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repository;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public Repository<Category> rp = new Repository<Category>();
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/Category/Index.cshtml",rp.Get());
        }

        [HttpPost]
        public ActionResult Insert(Category cat)
        {
            try
            {
                if (rp.Add(cat))
                {
                    ViewBag.Message = "Category added successfully";
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}