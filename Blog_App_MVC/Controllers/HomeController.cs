using Blog_App_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_App_MVC.Controllers
{
    public class HomeController : Controller
    {
        private Db db = Db.Instance;
        public ActionResult Index()
        {
            return View(db.posts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index");
            {
                Post model = db.posts.Where(x => x.ID == id).FirstOrDefault();

                return View(model);
            }

        }
    }
}