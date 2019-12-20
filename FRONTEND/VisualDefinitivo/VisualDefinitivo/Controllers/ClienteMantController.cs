using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Visual.Models;
using System.Net.Http;

namespace VisualDefinitivo.Controllers
{
    public class ClienteMantController : Controller
    {

        public ActionResult Index()
        {
            IEnumerable<ClientesViewModel> recetas = null;

             
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("cliente/GetAll");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ClientesViewModel>>();
                    readTask.Wait();

                    recetas = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    recetas = Enumerable.Empty<ClientesViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(recetas);
        }

        // GET: Receta/Details/5
        public ActionResult Details(int? id)
        {
            ClientesViewModel receta = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("cliente/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ClientesViewModel>();
                    readTask.Wait();

                    receta = (ClientesViewModel)readTask.Result;
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
        public ActionResult Create(ClientesViewModel receta)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ClientesViewModel>("cliente/Insert", receta);
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
            ClientesViewModel receta = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("cliente/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ClientesViewModel>();
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
        public ActionResult Edit(ClientesViewModel receta)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<ClientesViewModel>("cliente/Update", receta);
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
            ClientesViewModel receta = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("cliente/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ClientesViewModel>();
                    readTask.Wait();

                    receta = readTask.Result;
                }
            }
            return View(receta);
        }


        // POST: Receta/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClientesViewModel receta)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ClientesViewModel>("cliente/Delete", receta);
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
    }
}