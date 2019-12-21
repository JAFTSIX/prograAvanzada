using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualDefinitivo.Models;
using Visual.Models;
namespace VisualDefinitivo.Controllers
{
    public class mapeador
    {
        public static void CrearMapas()
        {
            AutoMapper.Mapper.Initialize(cfg => {
                cfg.CreateMap<HistorialViewModel, Historialmostrar>();
                cfg.CreateMap<Historialmostrar, HistorialViewModel>();
                cfg.CreateMap<ClientesViewModel, VisualDefinitivo.Models.Cliente>();
                cfg.CreateMap<VisualDefinitivo.Models.Cliente, ClientesViewModel>();
                //cfg.CreateMap<Carrito, LineaViewModel>();
                //cfg.CreateMap<LineaViewModel, Carrito>();
            });

        }
    }
}