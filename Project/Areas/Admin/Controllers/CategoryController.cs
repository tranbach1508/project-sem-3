using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public Repository<Category> rp = new Repository<Category>();
        public Repository<Subcategory> sub = new Repository<Subcategory>();
        public Repository<Product> pro = new Repository<Product>();
        public ActionResult Index()
        {
            if (Session["admin"] == "")
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View("~/Areas/Admin/Views/Category/Index.cshtml");
            }
            
        }

        [HttpPost]
        public string Insert(Category cat)
        {
            try
            {
                if (rp.Add(cat))
                {
                    return "Category added successfully";
                }
                else
                {
                    return "Category add error";
                }
            }
            catch
            {
                return "Category add error";
            }
        }

        [HttpPost]
        public string Edit(Category cat)
        {
            try
            {
                if (rp.Edit(cat))
                {
                    return "Category edited successfully";
                }
                else
                {
                    return "Category edit error";
                }
            }
            catch
            {
                return "Category edit error";
            }
        }

        [HttpPost]
        public string Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    return "Category deleted successfully";
                }
                else
                {
                    return "Category delete error";
                }
            }
            catch
            {
                return "Category delete error";
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            var categories = rp.Get()
                .Select(c => new Category
                {
                Id = c.Id,
                Name = c.Name,
                Subcategories = sub.Get(e => e.CategoryId == c.Id)
                .Select(s =>new Subcategory { 
                    Id = s.Id,
                    Name = s.Name
                }).ToList(),
                Products = pro.Get(e => e.CategoryId == c.Id)
                .Select(p => new Product {
                    Id = p.Id,
                    Name = p.Name,
                    Image = p.Image,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    Description = p.Description,
                    CategoryId = p.CategoryId,
                    AuthorId = p.AuthorId,
                    PublisherId = p.PublisherId,
                    SubcategoryId = p.SubcategoryId,
                }).ToList()
                }).ToList();
            return Json(categories, JsonRequestBehavior.AllowGet);
        }

        public Category GetById(string id)
        {
            return rp.Get(id);
        }
    }
}