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
                return View("~/Areas/Admin/Views/Category/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Category add error";
                return View("~/Areas/Admin/Views/Category/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Edit(Category cat)
        {
            try
            {
                if (rp.Edit(cat))
                {
                    ViewBag.Message = "Category edited successfully";
                }
                return View("~/Areas/Admin/Views/Category/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Category edit error";
                return View("~/Areas/Admin/Views/Category/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Category delete successfully";
                }
                return View("~/Areas/Admin/Views/Category/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Category delete error";
                return View("~/Areas/Admin/Views/Category/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}