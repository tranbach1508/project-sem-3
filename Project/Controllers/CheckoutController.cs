using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Controllers
{
    public class CheckoutController : Controller
    {
        Repository<Order> od = new Repository<Order>();
        Repository<OrderDetail> odd = new Repository<OrderDetail>();
        // GET: Checkout
        public ActionResult Index()
        {
            ViewBag.Cart = (List<Cart>)Session["cart"];
            ViewBag.Customer = Session["customer"];
            return View("~/Views/Theme/Checkout.cshtml");
        }

        public JsonResult Order(Order order)
        {
            List<Cart> cart = (List<Cart>)Session["cart"];
            var result = false;
            if (od.Add(order)){
                foreach(var item in cart)
                {
                    if (odd.Add(new OrderDetail { Id="B0001",Quantity= item.Quantity,ProductId = item.Product.Id,OrderId = order.Id})){
                        result = true;
                    }else
                    {
                        result = false;
                    }
                }
                return Json("Order successfull", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Order not successfull", JsonRequestBehavior.AllowGet);
            }
        }
    }
}