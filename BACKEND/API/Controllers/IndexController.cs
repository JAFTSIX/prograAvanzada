using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ent = DO.Objeto;

namespace API.Controllers
{

    [Route("api/operations")]
    public class IndexController : ApiController
    {

        [Route("api/operations/index")]
        [HttpGet]
        public IEnumerable<ent.Receta> index()
        {


            return new BS.Receta().TraerIndex();
        }


        [Route("api/operations/compra")]    
        [HttpPost]
        public void comprar(ent.Pedido pedido)
        {


            new BS.compras().comprar(pedido);
        }



        [Route("api/operations/login")]
        [HttpPost]
        public void login(ent.Cliente cliente)
        {


            //new BS.compras().comprar(pedido);
        }

    }
}
