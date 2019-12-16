using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace APIVintage.Controllers
{
    public class ArticuloController : ApiController
    {
        public IEnumerable<ent.Articulo> GetAll()
        {
            return new BS.Articulo().TraerTodo();
        }

        public ent.Articulo GetOneById(int id)
        {
            return new BS.Articulo().TraerId(id);
        }

        public void Insert(ent.Articulo t)
        {
            new BS.Articulo().Agregar(t);
        }

        public void Delete(ent.Articulo t)
        {
            new BS.Articulo().Eliminar(t);
        }

        public void Update(ent.Articulo t)
        {
            new BS.Articulo().Modificar(t);
        }
    }
}
