using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{

    [Route("api/cliente")]
    public class ClienteController : ApiController
    {

        [Route("api/cliente/GetAll")]
        [HttpGet]
        public IEnumerable<ent.Cliente> GetAll()
        {
            return new BS.Cliente().TraerTodo();
        }

        [Route("api/cliente/GetOneById/5")]
        [HttpGet]
        public ent.Cliente GetOneById(int id)
        {
            return new BS.Cliente().TraerId(id);
        }

        [Route("api/cliente/Insert")]
        [HttpPost]
        public void Insert(ent.Cliente t)
        {
            new BS.Cliente().Agregar(t);
        }

        [Route("api/cliente/Delete")]
        [HttpPost]
        public void Delete(ent.Cliente t)
        {
            new BS.Cliente().Eliminar(t);
        }

        [Route("api/cliente/Update")]
        [HttpPost]
        public void Update(ent.Cliente t)
        {
            new BS.Cliente().Modificar(t);
        }
    }
}
