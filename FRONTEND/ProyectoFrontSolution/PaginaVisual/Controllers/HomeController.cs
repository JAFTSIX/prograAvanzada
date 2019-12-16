using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaVisual.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult blog()
        {
            ViewBag.Message = "Your blog page.";

            return View();
        }

        public ActionResult gallery()
        {
            ViewBag.Message = "Your gallery page.";

            return View();
        }

        public ActionResult service()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }

        public ActionResult single()
        {
            ViewBag.Message = "Your single page.";

            return View();
        }
    }
}