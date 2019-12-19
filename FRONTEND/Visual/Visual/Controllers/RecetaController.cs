using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Visual.Models;

namespace Visual.Controllers
{
    public class RecetaController : Controller
    {
        // GET: Receta
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

        // GET: Receta/Details/5
        public ActionResult Details(int? id)
        {
            RecetasViewModel receta = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44311/api/");
                //HTTP GET
                var responseTask = client.GetAsync("recetas/GetOneById/5?id="+id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<RecetasViewModel>>();
                    readTask.Wait();

                    receta = (RecetasViewModel)readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    receta = (RecetasViewModel)Enumerable.Empty<RecetasViewModel>();

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
        public ActionResult Create([Bind(Include = "pkReceta,nombre,Dfecha_publicacion,vTexto,vimgurl,vVidurl")] RecetasViewModel receta)
        {
            if (ModelState.IsValid)
            {
                db.tb_Receta.Add(tb_Receta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Receta);
        }

        // GET: Receta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Receta tb_Receta = db.tb_Receta.Find(id);
            if (tb_Receta == null)
            {
                return HttpNotFound();
            }
            return View(tb_Receta);
        }

        // POST: Receta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pkReceta,nombre,Dfecha_publicacion,vTexto,vimgurl,vVidurl")] tb_Receta tb_Receta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Receta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Receta);
        }

        // GET: Receta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Receta tb_Receta = db.tb_Receta.Find(id);
            if (tb_Receta == null)
            {
                return HttpNotFound();
            }
            return View(tb_Receta);
        }

        // POST: Receta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Receta tb_Receta = db.tb_Receta.Find(id);
            db.tb_Receta.Remove(tb_Receta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}