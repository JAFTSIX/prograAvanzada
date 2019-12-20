using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Visual.Models;


namespace VisualDefinitivo.Controllers
{
    public class HistorialMantController : Controller
    {

        public ActionResult Index()
        {
            IEnumerable<HistorialViewModel> recetas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("historial/GetAll");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<HistorialViewModel>>();
                    readTask.Wait();

                    recetas = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    recetas = Enumerable.Empty<HistorialViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(recetas);
        }

        // GET: Receta/Details/5
        public ActionResult Details(int? id)
        {
            HistorialViewModel receta = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                
                var responseTask = client.GetAsync("historial/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<HistorialViewModel>();
                    readTask.Wait();

                    receta = (HistorialViewModel)readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    receta = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(receta);
        }

    

      
    }
}