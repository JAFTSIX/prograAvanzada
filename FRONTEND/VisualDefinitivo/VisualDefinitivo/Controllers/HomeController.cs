﻿using Newtonsoft.Json.Linq;
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
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
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

        public ActionResult ProductoUnico(int? id)
        {
            ArticuloViewModel producto = null;

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

                    producto = (ArticuloViewModel)readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    producto = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(producto);
        }

        public ActionResult RecetaUnica(int? id)
        {
            RecetasViewModel receta = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("recetas/GetOneById/5?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<RecetasViewModel>();
                    readTask.Wait();

                    receta = (RecetasViewModel)readTask.Result;

                    /**/
                    if (Session["login"]=="si")
                    {

                        HistorialViewModel his=new HistorialViewModel();
                        his.fkReceta = (Int32) id;
                        his.iCliente_id = VisualDefinitivo.Models.Cliente.INSTANCIA.id_Cliente;
                        his.fecha = DateTime.Now;
                        his.pkHistorial = 1;
                        var postTask = client.PostAsJsonAsync<HistorialViewModel>("historial/Insert", his);
                        postTask.Wait();

                        var resulta = postTask.Result;
                        if (resulta.IsSuccessStatusCode)
                        {
                            
                        }
                    }

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

        public ActionResult Recetas()
        {
            IEnumerable<RecetasViewModel> recetas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
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
            IEnumerable<ArticuloViewModel> productos = null;

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

                    productos = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    productos = Enumerable.Empty<ArticuloViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(productos);
        }


        public ActionResult loguearse()
        {
            return View();
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult loguearse(ClientesViewModel cliente)
        {

            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ClientesViewModel>("operations/login", cliente);
                var lavuelta = postTask.Result.Content.ReadAsStringAsync();

                JObject jObject = JObject.Parse(lavuelta.Result);
                
                
                cliente.id_Cliente= Int32.Parse((string)jObject["id_Cliente"]);
                cliente.iEdad = Int32.Parse((string)jObject["iEdad"]);
                cliente.id_direccion = Int32.Parse((string)jObject["id_direccion"]);
                cliente.vNombre = (string)jObject["vNombre"];
                cliente.vApellido= (string)jObject["vApelldo"];
                cliente.vApelldo2= (string)jObject["vApelldo2"];
                cliente.vROL= (string)jObject["vROL"];

                /*AutoMapper.Mapper.Initialize(cfg=> {
                    cfg.CreateMap<ClientesViewModel, VisualDefinitivo.Models.Cliente>();
                    cfg.CreateMap< VisualDefinitivo.Models.Cliente,ClientesViewModel > ();
                });*/

                VisualDefinitivo.Models.Cliente.INSTANCIA = AutoMapper.Mapper.Map<ClientesViewModel, VisualDefinitivo.Models.Cliente>(cliente);

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    if (cliente.vNombre!="")
                    {
                        Session["login"] = "si";
                        return RedirectToAction("Index");
                    }
                    


                    
                }
                else { 
                    Session["login"] = "no";


                   // return RedirectToAction("Index");
                }



            }

            //ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(cliente);
        }



        public ActionResult logout() {


            Session["login"] = "no";
            VisualDefinitivo.Models.Cliente.INSTANCIA = null;

            return RedirectToAction("Index");
       }





        public ActionResult personal()
        {
            IEnumerable<Visual.Models.HistorialViewModel> historialViews=null;
            IEnumerable<Visual.Models.Historialmostrar> amigableHistorial=null;
            IEnumerable<RecetasViewModel> recetas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("operations/traertuh/5?id=" + VisualDefinitivo.Models.Cliente.INSTANCIA.id_Cliente.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<HistorialViewModel>>();
                    readTask.Wait();

                    historialViews = readTask.Result;



                    #region llamarRecetas
                    

                    var respTask = client.GetAsync("recetas/GetAll");
                    respTask.Wait();

                    var reslt = respTask.Result;
                    if (reslt.IsSuccessStatusCode)
                    {
                        var rdTask = reslt.Content.ReadAsAsync<IList<RecetasViewModel>>();
                        rdTask.Wait();

                        recetas = rdTask.Result;


                        /*Mapear aqui historial amigableHistorial*/

                        /*AutoMapper.Mapper.Initialize(cfg => {
                            cfg.CreateMap<HistorialViewModel, Historialmostrar>();
                            cfg.CreateMap<Historialmostrar, HistorialViewModel>();
                        });*/

                        amigableHistorial= AutoMapper.Mapper.Map<IEnumerable<HistorialViewModel>, IEnumerable<Historialmostrar>>(historialViews);


                        foreach (var reci in recetas)
                        {

                            foreach (var history in amigableHistorial)
                            {
                                if (reci.pkReceta==history.fkReceta)
                                {
                                    history.nombre = reci.nombre;
                                }
                                

                            }
                        }


                    }
                    else //web api sent error response 
                    {
                        //log response status here..

                        recetas = Enumerable.Empty<RecetasViewModel>();

                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                    #endregion







                }
                else //web api sent error response 
                {
                    //log response status here..

                    amigableHistorial = Enumerable.Empty<Historialmostrar>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(amigableHistorial);
        }


        public ActionResult historialCompras()
        {

            IEnumerable<Visual.Models.EncabezadoViewModel> Encabezado = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apicocina.azurewebsites.net/api/");
                //HTTP GET
                var responseTask = client.GetAsync("operations/traertue/5?id=" + VisualDefinitivo.Models.Cliente.INSTANCIA.id_Cliente.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<EncabezadoViewModel>>();
                    readTask.Wait();

                    Encabezado = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Encabezado = Enumerable.Empty<EncabezadoViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(Encabezado);
        }


    }
}