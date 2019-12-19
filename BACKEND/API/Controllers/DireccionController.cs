using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{

    [Route("api/dir")]
    public class DireccionController : ApiController
    {
        [Route("api/dir/GetAll")]
        [HttpGet]
        public IEnumerable<ent.Direccion> GetAll()
        {
            return new BS.Direccion().TraerTodo();
        }

        [Route("api/dir/GetOneById/5")]
        [HttpGet]
        public ent.Direccion GetOneById(int id)
        {
            return new BS.Direccion().TraerId(id);
        }

        [Route("api/dir/Insert")]
        [HttpPost]
        public void Insert(ent.Direccion t)
        {
            new BS.Direccion().Agregar(t);
        }

        [Route("api/dir/Delete")]
        [HttpPost]
        public void Delete(ent.Direccion t)
        {
            new BS.Direccion().Eliminar(t);
        }

        [Route("api/dir/Update")]
        [HttpPost]
        public void Update(ent.Direccion t)
        {
            new BS.Direccion().Modificar(t);
        }
    }
}
