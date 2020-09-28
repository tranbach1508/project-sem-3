using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        ShopContext db = new ShopContext();
        CategoryController cc = new CategoryController();
        public Repository<Subcategory> rp = new Repository<Subcategory>();
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/Subcategory/Index.cshtml");
        }

        [HttpPost]
        public JsonResult Insert(Subcategory sub)
        {
            try
            {
                if (rp.Add(sub))
                {
                    return Json("Subcategory added successful", JsonRequestBehavior.AllowGet);
                }
                return Json(sub, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("Subcategory add error", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Edit(Subcategory sub)
        {
            try
            {
                if (rp.Edit(sub))
                {
                    ViewBag.Message = "Subcategory edited successfully";
                }
                return View("~/Areas/Admin/Views/Subcategory/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Subcategory edit error";
                return View("~/Areas/Admin/Views/Subcategory/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Subcategory delete successfully";
                }
                return View("~/Areas/Admin/Views/Subcategory/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Subcategory delete error";
                return View("~/Areas/Admin/Views/Subcategory/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            var subcategories = rp.Get()
                    .Select(e => new Subcategory
                                {
                                    Id = e.Id,
                                    Name = e.Name,
                                    Products = e.Products,
                                    CategoryId = e.CategoryId,
                                    Category = cc.GetById(e.CategoryId)
                                }).ToList();

            return Json(subcategories, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(string id)
        {
            var subcategories = rp.Get()
                    .Select(e => new Subcategory
                                {
                                    Id = e.Id,
                                    Name = e.Name,
                                    Products = e.Products,
                                    CategoryId = e.CategoryId,
                                    Category = cc.GetById(e.CategoryId)
                                }).ToList();

            return Json(subcategories, JsonRequestBehavior.AllowGet);
        }
    }
}