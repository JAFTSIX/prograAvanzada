using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Visual.Models;

namespace VisualDefinitivo.Controllers
{
    public class ProductoMantController : Controller
    {

        public ActionResult Index()
        {
            IEnumerable<ArticuloViewModel> recetas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("articulo/GetAll");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ArticuloViewModel>>();
                    readTask.Wait();

                    recetas = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    recetas = Enumerable.Empty<ArticuloViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(recetas);
        }

        // GET: Receta/Details/5
        public ActionResult Details(int? id)
        {
            ArticuloViewModel receta = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("articulo/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ArticuloViewModel>();
                    readTask.Wait();

                    receta = (ArticuloViewModel)readTask.Result;
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

        // GET: Receta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticuloViewModel receta)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ArticuloViewModel>("articulo/Insert", receta);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(receta);
        }

        // GET: Receta/Edit/5
        public ActionResult Edit(int? id)
        {
            ArticuloViewModel receta = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET  api/articulo/GetOneById/5?id={id}
                var responseTask = client.GetAsync("articulo/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ArticuloViewModel>();
                    readTask.Wait();

                    receta = readTask.Result;
                }
            }
            return View(receta);
        }

        // POST: Receta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticuloViewModel receta)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<ArticuloViewModel>("articulo/Update", receta);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(receta);
        }

        // GET: Receta/Delete
        public ActionResult Delete(int? id)
        {
            ArticuloViewModel receta = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("articulo/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ArticuloViewModel>();
                    readTask.Wait();

                    receta = readTask.Result;
                }
            }
            return View(receta);
        }


        // POST: Receta/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ArticuloViewModel receta)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ArticuloViewModel>("articulo/Delete", receta);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(receta);
        }
        // POST: Receta/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tb_Receta tb_Receta = db.tb_Receta.Find(id);
        //    db.tb_Receta.Remove(tb_Receta);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}