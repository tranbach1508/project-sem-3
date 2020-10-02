using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class AboutusController : Controller
    {
        // GET: Aboutus
        public ActionResult Index()
        {
            return View("~/Views/Theme/Aboutus.cshtml");
        }
    }
}