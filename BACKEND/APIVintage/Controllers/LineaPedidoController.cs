using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace APIVintage.Controllers
{
    public class LineaPedidoController : ApiController
    {
        public IEnumerable<ent.LineaPedido> GetAll()
        {
            return new BS.Linea_pedido().TraerTodo();
        }

        public ent.LineaPedido GetOneById(int id)
        {
            return new BS.Linea_pedido().TraerId(id);
        }

        public void Insert(ent.LineaPedido t)
        {
            new BS.Linea_pedido().Agregar(t);
        }

        public void Delete(ent.LineaPedido t)
        {
            new BS.Linea_pedido().Eliminar(t);
        }

        public void Update(ent.LineaPedido t)
        {
            new BS.LineaPedido().Modificar(t);
        }
    }
}
