using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace APIVintage.Controllers
{
    public class EncabezadoController : ApiController
    {
        public IEnumerable<ent.Encabezado> GetAll()
        {
            return new BS.Encabezado().TraerTodo();
        }

        public ent.Encabezado GetOneById(int id)
        {
            return new BS.Encabezado().TraerId(id);
        }

        public void Insert(ent.Encabezado t)
        {
            new BS.Encabezado().Agregar(t);
        }

        public void Delete(ent.Encabezado t)
        {
            new BS.Encabezado().Eliminar(t);
        }

        public void Update(ent.Encabezado t)
        {
            new BS.Encabezado().Modificar(t);
        }
    }
}
