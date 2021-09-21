using BlogApiChallange.Context;
using BlogApiChallange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApiChallange.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Blog Anasayfa";
            return View();
        }
        public ActionResult PaylasimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PaylasimEkle(Paylasim paylasim)
        {
            //Gelen paylaşımı veritabanına kaydet.
            db.Paylasimlar.Add(paylasim);
            db.SaveChanges();
            return View();
        }
    }
}
