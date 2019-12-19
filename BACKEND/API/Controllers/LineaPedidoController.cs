using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{

    [Route("api/linea")]
    public class LineaPedidoController : ApiController
    {
        [Route("api/linea/GetAll")]
        [HttpGet]
        public IEnumerable<ent.LineaPedido> GetAll()
        {
            return new BS.Linea_pedido().TraerTodo();
        }


        [Route("api/linea/GetOneById/5")]
        [HttpGet]
        public ent.LineaPedido GetOneById(int id)
        {
            return new BS.Linea_pedido().TraerId(id);
        }

        [Route("api/linea/Insert")]
        [HttpPost]
        public void Insert(ent.LineaPedido t)
        {
            new BS.Linea_pedido().Agregar(t);
        }


        [Route("api/linea/Delete")]
        [HttpPost]
        public void Delete(ent.LineaPedido t)
        {
            new BS.Linea_pedido().Eliminar(t);
        }

        [Route("api/linea/Update")]
        [HttpPost]
        public void Update(ent.LineaPedido t)
        {
            new BS.Linea_pedido().Modificar(t);
        }
    }
}
