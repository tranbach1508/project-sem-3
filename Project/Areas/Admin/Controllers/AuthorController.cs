using System.Web.Mvc;
using WebDAL.DataModels;
using WebBLL.Repositories;

namespace Project.Areas.Admin.Controllers
{
    public class AuthorController : Controller
    {
        public Repository<Author> rp = new Repository<Author>();
        public ActionResult Index()
        {
            if (Session["admin"] == "")
            {
                return View("~/Views/Theme/LoginAdmin.cshtml");
            }
            else
            {
                return View("~/Areas/Admin/Views/Author/Index.cshtml");
            }
            
        }

        [HttpPost]
        public ActionResult Insert(Author auth)
        {
            try
            {
                if (rp.Add(auth))
                {
                    ViewBag.Message = "Author added successfully";
                }
                return View("~/Areas/Admin/Views/Author/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Author add error";
                return View("~/Areas/Admin/Views/Author/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Edit(Author auth)
        {
            try
            {
                if (rp.Edit(auth))
                {
                    ViewBag.Message = "Author edited successfully";
                }
                return View("~/Areas/Admin/Views/Author/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Author edit error";
                return View("~/Areas/Admin/Views/Author/Index.cshtml");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                if (rp.Remove(id))
                {
                    ViewBag.Message = "Author delete successfully";
                }
                return View("~/Areas/Admin/Views/Author/Index.cshtml", rp.Get());
            }
            catch
            {
                ViewBag.Message = "Author delete error";
                return View("~/Areas/Admin/Views/Author/Index.cshtml");
            }
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(rp.Get(), JsonRequestBehavior.AllowGet);
        }

        public Author GetById(string id)
        {
            return rp.Get(id);
        }
    }
}