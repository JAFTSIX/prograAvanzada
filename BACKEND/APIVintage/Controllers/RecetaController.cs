using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace APIVintage.Controllers
{
    public class RecetaController : ApiController
    {
        public IEnumerable<ent.Receta> GetAll()
        {
            return new BS.Receta().TraerTodo();
        }

        public ent.Receta GetOneById(int id)
        {
            return new BS.Receta().TraerId(id);
        }

        public void Insert(ent.Receta t)
        {
            new BS.Receta().Agregar(t);
        }

        public void Delete(ent.Receta t)
        {
            new BS.Receta().Eliminar(t);
        }

        public void Update(ent.Receta t)
        {
            new BS.Receta().Modificar(t);
        }
    }
}
