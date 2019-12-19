using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{

    [Route("api/encabezado")]
    public class EncabezadoController : ApiController
    {

        [Route("api/encabezado/GetAll")]
        [HttpGet]
        public IEnumerable<ent.Encabezado> GetAll()
        {
            return new BS.Encabezado().TraerTodo();
        }

        [Route("api/encabezado/GetOneById/5")]
        [HttpGet]
        public ent.Encabezado GetOneById(int id)
        {
            return new BS.Encabezado().TraerId(id);
        }

        [Route("api/encabezado/Insert")]
        [HttpPost]
        public void Insert(ent.Encabezado t)
        {
            new BS.Encabezado().Agregar(t);
        }

        [Route("api/encabezado/Delete")]
        [HttpPost]
        public void Delete(ent.Encabezado t)
        {
            new BS.Encabezado().Eliminar(t);
        }

        [Route("api/encabezado/Update")]
        [HttpPost]
        public void Update(ent.Encabezado t)
        {
            new BS.Encabezado().Modificar(t);
        }
    }
}
