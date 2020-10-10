using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Admin/Home
        public ActionResult Index()
        {
            if (Session["admin"] == null)
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View("~/Areas/Admin/Views/Product/Index.cshtml");
            }
        }
    }
}