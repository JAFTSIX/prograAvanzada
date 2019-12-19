using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{
    [Route("api/historial")]
    public class HistorialController : ApiController
    {
        [Route("api/historial/GetAll")]
        [HttpGet]
        public IEnumerable<ent.Historial> GetAll()
        {
            return new BS.Historial().TraerTodo();
        }


        [Route("api/historial/GetOneById/5")]
        [HttpGet]
        public ent.Historial GetOneById(int id)
        {
            return new BS.Historial().TraerId(id);
        }

        [Route("api/historial/Insert")]
        [HttpPost]
        public void Insert(ent.Historial t)
        {
            new BS.Historial().Agregar(t);
        }

        [Route("api/historial/Delete")]
        [HttpPost]
        public void Delete(ent.Historial t)
        {
            new BS.Historial().Eliminar(t);
        }

        [Route("api/historial/Update")]
        [HttpPost]
        public void Update(ent.Historial t)
        {
            new BS.Historial().Modificar(t);
        }
    }
}
