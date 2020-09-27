using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class FaqController : Controller
    {
        public Repository<Faq> rp = new Repository<Faq>();
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/Faq/Index.cshtml");
        }

        [HttpPost]
        public ActionResult Insert(Faq faq)
        {
            try
            {
                if (rp.Add(faq))
                {
                    ViewBag.Message = "Faq added successfully";
                }
                return View("~/Areas/Admin/Views/Faq/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Faq add error";
                return View("~/Areas/Admin/Views/Faq/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Edit(Faq faq)
        {
            try
            {
                if (rp.Edit(faq))
                {
                    ViewBag.Message = "Faq edited successfully";
                }
                return View("~/Areas/Admin/Views/Faq/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Faq edit error";
                return View("~/Areas/Admin/Views/Faq/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Faq delete successfully";
                }
                return View("~/Areas/Admin/Views/Faq/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Faq delete error";
                return View("~/Areas/Admin/Views/Faq/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}