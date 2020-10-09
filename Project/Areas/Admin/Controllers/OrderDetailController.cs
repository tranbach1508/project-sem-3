using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class OrderDetailController : Controller
    {
        Repository<OrderDetail> od = new Repository<OrderDetail>();
        Repository<Order> or = new Repository<Order>();
        // GET: Admin/OrderDetail
        public ActionResult Index()
        {
            if (Session["admin"] == null)
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View();
            }
            
        }

        [HttpGet]
        public ActionResult GetByOrder(string id)
        {
            ViewBag.Details = od.Get(e => e.OrderId == id);
            ViewBag.Order = or.Get(id);
            if (Session["admin"] == null)
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View("~/Areas/Admin/Views/OrderDetail/Index.cshtml");
            }
            
        }
    }
}