using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class FeedbackController : Controller
    {
        ShopContext db = new ShopContext();
        CategoryController cc = new CategoryController();
        public Repository<Feedback> rp = new Repository<Feedback>();
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/Feedback/Index.cshtml");
        }

        [HttpPost]
        public JsonResult Insert(Feedback fb)
        {
            try
            {
                if (rp.Add(fb))
                {
                    return Json("Feedback added successful", JsonRequestBehavior.AllowGet);
                }
                return Json(fb, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("Feedback add error", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Edit(Feedback fb)
        {
            try
            {
                if (rp.Edit(fb))
                {
                    ViewBag.Message = "Feedback edited successfully";
                }
                return View("~/Areas/Admin/Views/Feedback/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Feedback edit error";
                return View("~/Areas/Admin/Views/Feedback/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Feedback delete successfully";
                }
                return View("~/Areas/Admin/Views/Feedback/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Feedback delete error";
                return View("~/Areas/Admin/Views/Feedback/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            var feedbacks = rp.Get()
                    .Select(e => new Feedback
                    {
                        Id = e.Id,
                        Content = e.Content,
                        Product = e.Product,
                        AccCustomer = e.AccCustomer,
                    }).ToList();

            return Json(feedbacks, JsonRequestBehavior.AllowGet);
        }

        public Feedback GetById(string id)
        {
            return rp.Get(id);
        }
    }
}