using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;
using WebGrease.Css.Ast.Selectors;

namespace Project.Controllers
{
    public class CartController : Controller
    {
        Repository<Product> pro = new Repository<Product>();
        public ActionResult Index()
        {
            return View("~/Views/Theme/Cart.cshtml");
        }
        [HttpGet]
        public JsonResult AddToCart(string id, string qty)
        {

            int quantity = Convert.ToInt32(qty);
            if (Session["cart"] == null)
            {
                List<Models.Cart> cart = new List<Cart>();
                cart.Add(new Cart { Product = pro.Get(id), Quantity = quantity });
                Session["cart"] = cart;
            }
            else
            {
                List<Cart> cart = (List<Cart>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity += quantity;
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
        [HttpGet]
        public JsonResult GetCart()
        {
            if(Session["cart"] != null)
            {
                var carts = (List<Cart>)Session["cart"];
                List<Item> items = new List<Item>();
                foreach(var cart in carts)
                {
                    items.Add(new Item
                    {
                        ProductId = cart.Product.Id,
                        ProductName = cart.Product.Name,
                        ProductImage = cart.Product.Image,
                        ProductPrice = cart.Product.Price,
                        Quantity = cart.Quantity
                    });
                }
                return Json(items, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var cart = "Cart is empty";
                return Json(cart, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult UpdateCart(List<Item1> items)
        {
            List<Models.Cart> cart = new List<Cart>();
            if(items.Count() > 0)
            {
                foreach (var item in items)
                {
                    cart.Add(new Cart { Product = pro.Get(item.ProductId), Quantity = item.Quantity });
                }
                Session["cart"] = cart;
            }
            else
            {
                Session["cart"] = null;
            }
            
            return Json("Update to cart successfull", JsonRequestBehavior.AllowGet);
        }

        public class Item{
            public string ProductId { get; set; }
            public string ProductImage { get; set; }
            public double ProductPrice { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
        }

        public class Item1
        {
            public string ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }
}