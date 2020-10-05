using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Areas.Admin.Controllers
{
    public class OrderDetailController : Controller
    {
        // GET: Admin/OrderDetail
        public ActionResult Index()
        {
            if (Session["admin"] == "")
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View();
            }
            
        }
    }
}