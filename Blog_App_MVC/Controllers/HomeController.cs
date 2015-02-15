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

        public ActionResult DeletePost(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index");
            if (db.posts.Any(x => x.ID == id))
            {
                Post post = db.posts.Where(x => x.ID == id).FirstOrDefault();
                db.posts.Remove(post);
            }
            return RedirectToAction("Index");
        }

        public ActionResult AddPost()
        {
            return View(new Post());
        }

        [HttpPost]
        public ActionResult AddPost(Post model)
        {
            model.ID = db.posts.Select(x => x.ID).LastOrDefault() + 1;
            db.posts.Add(model);
            return RedirectToAction("Index");
        }
    }
}