using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class PublisherController : Controller
    {
        public Repository<Publisher> rp = new Repository<Publisher>();
        public ActionResult Index()
        {
            if (Session["admin"] == null)
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View("~/Areas/Admin/Views/Publisher/Index.cshtml");
            }
            
        }

        [HttpPost]
        public ActionResult Insert(Publisher pub)
        {
            try
            {
                if (rp.Add(pub))
                {
                    ViewBag.Message = "Publisher added successfully";
                }
                return View("~/Areas/Admin/Views/Publisher/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Publisher add error";
                return View("~/Areas/Admin/Views/Publisher/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Edit(Publisher pub)
        {
            try
            {
                if (rp.Edit(pub))
                {
                    ViewBag.Message = "Publisher edited successfully";
                }
                return View("~/Areas/Admin/Views/Publisher/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Publisher edit error";
                return View("~/Areas/Admin/Views/Publisher/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Publisher delete successfully";
                }
                return View("~/Areas/Admin/Views/Publisher/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Publisher delete error";
                return View("~/Areas/Admin/Views/Publisher/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }

        public Publisher GetById(string id)
        {
            return rp.Get(id);
        }
    }
}