using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        ShopContext db = new ShopContext();
        public Repository<Order> rp = new Repository<Order>();
        // GET: Admin/Order
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/Order/Index.cshtml");
        }
        [HttpPost]
        public JsonResult Insert(Order ord)
        {
            try
            {
                if (rp.Add(ord))
                {
                    return Json("Order added successful", JsonRequestBehavior.AllowGet);
                }
                return Json(ord, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("Order add error", JsonRequestBehavior.AllowGet);
            }
        }
         [HttpPost]
        public ActionResult Edit(Order ord)
        {
            try
            {
                if (rp.Edit(ord))
                {
                    ViewBag.Message = "Order edited successfully";
                }
                return View("~/Areas/Admin/Views/Order/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Order edit error";
                return View("~/Areas/Admin/Views/Order/Index.cshtml");
            }
        }
        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Order delete successfully";
                }
                return View("~/Areas/Admin/Views/Order/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Order delete error";
                return View("~/Areas/Admin/Views/Order/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            var orders = rp.Get()
                    .Select(e => new Order
                    {
                        Id= e.Id,
                        Status= e.Status,
                        Total= e.Total,
                        createdAt= e.createdAt,
                        AccCustomerId= e.AccCustomerId
                    }).ToList();

            return Json(orders, JsonRequestBehavior.AllowGet);
        }
        public Order GetById(string id)
        {
            return rp.Get(id);
        }

    }
}