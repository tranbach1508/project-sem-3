using Newtonsoft.Json;
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
        AccCustomerController ccc = new AccCustomerController();
        ProductController pc = new ProductController();
        public Repository<Order> rp = new Repository<Order>();
        // GET: Admin/Order
        public ActionResult Index()
        {
            if (Session["admin"] == null)
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View("~/Areas/Admin/Views/Order/Index.cshtml");
            }
            
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
                    .Select(e => new
                    {
                        Id = e.Id,
                        Status = e.Status,
                        createdAt = JsonConvert.SerializeObject(e.createdAt.ToString("MM/dd/yyyy")),
                        AccCustomerId = e.AccCustomerId,
                        OrderDetails = e.OrderDetails,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Address = e.Address,
                        City = e.City,
                        Email = e.Email,
                        Phone = e.Phone,
                    }).ToList();
            return Json(orders, JsonRequestBehavior.AllowGet);
        }

    }
}