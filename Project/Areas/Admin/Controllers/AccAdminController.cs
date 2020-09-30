using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class AccAdminController : Controller
    {
        public Repository<AccAdmin> rp = new Repository<AccAdmin>();
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/AccAdmin/Index.cshtml");
        }

        [HttpPost]
        public ActionResult Insert(AccAdmin adm)
        {
            try
            {
                if (rp.Add(adm))
                {
                    ViewBag.Message = "AccAdmin added successfully";
                }
                return View("~/Areas/Admin/Views/AccAdmin/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "AccAdmin add error";
                return View("~/Areas/Admin/Views/AccAdmin/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Edit(AccAdmin adm)
        {
            try
            {
                if (rp.Edit(adm))
                {
                    ViewBag.Message = "AccAdmin edited successfully";
                }
                return View("~/Areas/Admin/Views/AccAdmin/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "AccAdmin edit error";
                return View("~/Areas/Admin/Views/AccAdmin/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "AccAdmin delete successfully";
                }
                return View("~/Areas/Admin/Views/AccAdmin/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "AccAdmin delete error";
                return View("~/Areas/Admin/Views/AccAdmin/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}