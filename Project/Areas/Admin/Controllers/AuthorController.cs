﻿using System.Web.Mvc;
using WebDAL.DataModels;
using WebBLL.Repository;

namespace Project.Areas.Admin.Controllers
{
    public class AuthorController : Controller
    {
        public Repository<Author> rp = new Repository<Author>();
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/Author/Index.cshtml", rp.Get());
        }

        [HttpPost]
        public ActionResult Insert(Author cat)
        {
            try
            {
                if (rp.Add(cat))
                {
                    ViewBag.Message = "Author added successfully";
                }
                return View("~/Areas/Admin/Views/Author/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Author add error";
                return View("~/Areas/Admin/Views/Author/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Edit(Author cat)
        {
            try
            {
                if (rp.Edit(cat))
                {
                    ViewBag.Message = "Author edited successfully";
                }
                return View("~/Areas/Admin/Views/Author/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Author edit error";
                return View("~/Areas/Admin/Views/Author/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Author delete successfully";
                }
                return View("~/Areas/Admin/Views/Author/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Author delete error";
                return View("~/Areas/Admin/Views/Author/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}