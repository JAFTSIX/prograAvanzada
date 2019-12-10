using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace APIVintage.Controllers
{
    public class DireccionController : ApiController
    {
        public IEnumerable<ent.Direccion> GetAll()
        {
            return new BS.Direccion().TraerTodo();
        }

        public ent.Direccion GetOneById(int id)
        {
            return new BS.Direccion().TraerId(id);
        }

        public void Insert(ent.Direccion t)
        {
            new BS.Direccion().Agregar(t);
        }

        public void Delete(ent.Direccion t)
        {
            new BS.Direccion().Eliminar(t);
        }

        public void Update(ent.Direccion t)
        {
            new BS.Direccion().Modificar(t);
        }
    }
}
