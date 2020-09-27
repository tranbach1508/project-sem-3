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
        public ActionResult Index()
        {
            return View("~/Areas/Admin/Views/Category/Index.cshtml");
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
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }

        public Category GetById(string id)
        {
            return rp.Get(id);
        }
    }
}