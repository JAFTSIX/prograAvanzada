using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{
    [Route("api/favoritos")]
    public class FavoritosController : ApiController
    {
        [Route("api/favoritos/GetAll")]
        [HttpGet]
        public IEnumerable<ent.Favoritos> GetAll()
        {
            return new BS.Favoritos().TraerTodo();
        }

        [Route("api/favoritos/GetOneById/5")]
        [HttpGet]
        public ent.Favoritos GetOneById(int id)
        {
            return new BS.Favoritos().TraerId(id);
        }


        [Route("api/favoritos/Insert")]
        [HttpPost]
        public void Insert(ent.Favoritos t)
        {
            new BS.Favoritos().Agregar(t);
        }

        [Route("api/favoritos/Delete")]
        [HttpPost]
        public void Delete(ent.Favoritos t)
        {
            new BS.Favoritos().Eliminar(t);
        }

        [Route("api/favoritos/Update")]
        [HttpPost]
        public void Update(ent.Favoritos t)
        {
            new BS.Favoritos().Modificar(t);
        }
    }
}
