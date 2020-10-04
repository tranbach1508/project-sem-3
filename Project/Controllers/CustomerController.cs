using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBLL.Repositories;
using WebDAL.DataModels;

namespace Project.Controllers
{
    public class CustomerController : Controller
    {
        Repository<AccCustomer> ac = new Repository<AccCustomer>();
        // GET: Customer
        public ActionResult Index()
        {
            return View("~/Views/Theme/LoginRegister.cshtml");
        }
        [HttpPost]
        public JsonResult Register(AccCustomer cus)
        {
            if (ac.Add(cus))
            {
                return Json("Add customer successfull", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Add customer error", JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult Login(string email,string password)
        {
            if(ac.Get(e => e.Email == email && e.Password == password).Count()>0)
            {
                Session["customer"] = ac.Get(e => e.Email == email && e.Password == password).First();
                return Json("Login successfull", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Customer not exist", JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Logout()
        {
            Session["customer"] = null;
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult MyAccount()
        {
            ViewBag.Customer = Session["customer"];
            return View("~/Views/Theme/MyAccount.cshtml");
        }
    }
}