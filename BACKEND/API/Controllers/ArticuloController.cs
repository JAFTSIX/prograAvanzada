using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{
    [Route("api/articulo")]
    public class ArticuloController : ApiController
    {

        [Route("api/articulo/GetAll")]
        [HttpGet]
        public IEnumerable<ent.Articulo> GetAll()
        {
            return new BS.Articulo().TraerTodo();
        }


        [Route("api/articulo/GetOneById/5")]
        [HttpGet]

        public ent.Articulo GetOneById(int id)
        {
            return new BS.Articulo().TraerId(id);
        }

        [Route("api/articulo/Insert")]
        [HttpPost]
        public void Insert(ent.Articulo t)
        {
            new BS.Articulo().Agregar(t);
        }


        [Route("api/articulo/Delete")]
        [HttpPost]
        public void Delete(ent.Articulo t)
        {
            new BS.Articulo().Eliminar(t);
        }

        [Route("api/articulo/Update")]
        [HttpPost]
        public void Update(ent.Articulo t)
        {
            new BS.Articulo().Modificar(t);
        }
    }
}
