﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Visual.Models;

namespace VisualDefinitivo.Controllers
{
    public class CarritoController : Controller
    {
        // GET: Carrito
        public ActionResult AgregarCarrito(ArticuloViewModel articulo, int cant)
        {
            if (Session["carrito"] == null)
            {
                List<Carrito> compra = new List<Carrito>();
                compra.Add(new Carrito(articulo, cant));
                Session["carrito"] = compra;
            }
            else
            {
                List<Carrito> compra = (List<Carrito>)Session["carrito"];
                compra.Add(new Carrito(articulo, cant));
                Session["carrito"] = compra;
            }
            return View();
        }
    }
}