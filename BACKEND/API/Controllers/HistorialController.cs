using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{
    public class HistorialController : ApiController
    {
        public IEnumerable<ent.Historial> GetAll()
        {
            return new BS.Historial().TraerTodo();
        }

        public ent.Historial GetOneById(int id)
        {
            return new BS.Historial().TraerId(id);
        }

        public void Insert(ent.Historial t)
        {
            new BS.Historial().Agregar(t);
        }

        public void Delete(ent.Historial t)
        {
            new BS.Historial().Eliminar(t);
        }

        public void Update(ent.Historial t)
        {
            new BS.Historial().Modificar(t);
        }
    }
}
