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
    public class ProductController : Controller
    {
        Repository<WebDAL.DataModels.Product> pro = new Repository<WebDAL.DataModels.Product>();
        [HttpGet]
        public ActionResult Index(string id)
        {
            ViewBag.product = pro.Get(id);
            return View("~/Views/Theme/Product.cshtml");
        }

        [HttpGet]
        public JsonResult AddToCart(string id, string qty)
        {
            int quantity = Convert.ToInt32(qty);
            if (Session["cart"] == null)
            {
                List<Cart> cart = new List<Cart>();
                cart.Add(new Cart { Product = pro.Get(id), Quantity = quantity });
                Session["cart"] = cart;
            }
            else
            {
                List<Cart> cart = (List<Cart>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity+= quantity;
                }
                else
                {
                    cart.Add(new Cart { Product = pro.Get(id), Quantity = quantity });
                }
                Session["cart"] = cart;
            }
            return Json("Add to cart successfull", JsonRequestBehavior.AllowGet);
        }

        public JsonResult Remove(string id)
        {
            List<Cart> cart = (List<Cart>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return Json("Remove to cart successfull", JsonRequestBehavior.AllowGet);
        }

        public int isExist(string id)
        {
            List<Cart> cart = (List<Cart>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}