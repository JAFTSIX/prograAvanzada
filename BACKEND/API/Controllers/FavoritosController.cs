using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{
    public class FavoritosController : ApiController
    {
        public IEnumerable<ent.Favoritos> GetAll()
        {
            return new BS.Favoritos().TraerTodo();
        }

        public ent.Favoritos GetOneById(int id)
        {
            return new BS.Favoritos().TraerId(id);
        }

        public void Insert(ent.Favoritos t)
        {
            new BS.Favoritos().Agregar(t);
        }

        public void Delete(ent.Favoritos t)
        {
            new BS.Favoritos().Eliminar(t);
        }

        public void Update(ent.Favoritos t)
        {
            new BS.Favoritos().Modificar(t);
        }
    }
}
