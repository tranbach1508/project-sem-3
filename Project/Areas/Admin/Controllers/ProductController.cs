using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
            ShopContext db = new ShopContext();
            CategoryController cc = new CategoryController();
            AuthorController ac = new AuthorController();
            PublisherController pc = new PublisherController();
            SubCategoryController sc = new SubCategoryController();
            public Repository<Product> rp = new Repository<Product>();
            public ActionResult Index()
            {
                return View("~/Areas/Admin/Views/Product/Index.cshtml");
            }

            [HttpPost]
            public JsonResult Insert(Product pro)
            {
                try
                {
                    if (rp.Add(pro))
                    {
                        return Json("Product added successful", JsonRequestBehavior.AllowGet);
                    }
                    return Json("Product add error", JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    return Json("Product add error", JsonRequestBehavior.AllowGet);
                }
            }

            [HttpPost]
            public ActionResult Edit(Product pro)
            {
                try
                {
                    if (rp.Edit(pro))
                    {
                        ViewBag.Message = "Product edited successfully";
                    }
                    return View("~/Areas/Admin/Views/Product/Index.cshtml", rp.Get());
                }
                catch
                {
                    ViewBag.Message = "Product edit error";
                    return View("~/Areas/Admin/Views/Product/Index.cshtml");
                }
            }

            [HttpPost]
            public ActionResult Delete(string id)
            {
                try
                {
                    if (rp.Remove(id))
                    {
                        ViewBag.Message = "Product delete successfully";
                    }
                    return View("~/Areas/Admin/Views/Product/Index.cshtml", rp.Get());
                }
                catch
                {
                    ViewBag.Message = "Product delete error";
                    return View("~/Areas/Admin/Views/Product/Index.cshtml");
                }
            }
            [HttpGet]
            public JsonResult Get()
            {
                var products = rp.Get()
                        .Select(e => new Product
                        {
                            Id = e.Id,
                            Name = e.Name,
                            Image = e.Image,
                            Price= e.Price,
                            Quantity = e.Quantity,
                            CategoryId = e.CategoryId,
                            AuthorId = e.AuthorId,
                            PublisherId = e.PublisherId,
                            SubcategoryId = e.SubcategoryId,
                            Category = cc.GetById(e.CategoryId),
                            Author = ac.GetById(e.AuthorId),
                            Publisher = pc.GetById(e.PublisherId),
                            Subcategory = sc.GetById(e.SubcategoryId)
                        }).ToList();

                return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}