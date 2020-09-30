using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        ShopContext db = new ShopContext();
        Repository<AccAdmin> rp = new Repository<AccAdmin>();
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View("~/Views/Theme/LoginAdmin.cshtml");
        }

        [HttpPost]
        public ActionResult Check(AccAdmin acc)
        {
            if(rp.Get(i => i.Username == acc.Username && i.Password == acc.Password).Count() > 0)
            {
                return View("~/Areas/Admin/Views/Home/Index.cshtml"); ;
            }
            else {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
        }
    }
}