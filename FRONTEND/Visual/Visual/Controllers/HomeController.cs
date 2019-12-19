using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Visual.Models;

namespace PaginaVisual.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            IEnumerable<RecetasViewModel> recetas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44311/api/");
                //HTTP GET
                var responseTask = client.GetAsync("recetas/GetAll");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<RecetasViewModel>>();
                    readTask.Wait();

                    recetas = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    recetas = Enumerable.Empty<RecetasViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(recetas);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult contact()
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

        public ActionResult Recetas()
        {
            IEnumerable<RecetasViewModel> recetas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44311/api/");
                //HTTP GET
                var responseTask = client.GetAsync("recetas/GetAll");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<RecetasViewModel>>();
                    readTask.Wait();

                    recetas = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    recetas = Enumerable.Empty<RecetasViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(recetas);
        }

        public ActionResult Productos()
        {
            ViewBag.Message = "Your single page.";

            return View();
        }
    }
}