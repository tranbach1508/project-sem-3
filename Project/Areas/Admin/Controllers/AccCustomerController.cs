using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class AccCustomerController : Controller
    {
        public Repository<AccCustomer> rp = new Repository<AccCustomer>();
        public ActionResult Index()
        {
            if (Session["admin"] == "")
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View("~/Areas/Admin/Views/AccCustomer/Index.cshtml");
            }
            
        }

        [HttpPost]
        public ActionResult Insert(AccCustomer cus)
        {
            try
            {
                if (rp.Add(cus))
                {
                    ViewBag.Message = "AccCustomer added successfully";
                }
                return View("~/Areas/Admin/Views/AccCustomer/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "AccCustomer add error";
                return View("~/Areas/Admin/Views/AccCustomer/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Edit(AccCustomer cus)
        {
            try
            {
                if (rp.Edit(cus))
                {
                    ViewBag.Message = "AccCustomer edited successfully";
                }
                return View("~/Areas/Admin/Views/AccCustomer/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "AccCustomer edit error";
                return View("~/Areas/Admin/Views/AccCustomer/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "AccCustomer delete successfully";
                }
                return View("~/Areas/Admin/Views/AccCustomer/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "AccCustomer delete error";
                return View("~/Areas/Admin/Views/AccCustomer/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}