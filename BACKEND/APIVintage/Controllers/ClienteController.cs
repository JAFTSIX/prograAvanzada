using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace APIVintage.Controllers
{
    public class ClienteController : ApiController
    {
        public IEnumerable<ent.Cliente> GetAll()
        {
            return new BS.Cliente().TraerTodo();
        }

        public ent.Cliente GetOneById(int id)
        {
            return new BS.Cliente().TraerId(id);
        }

        public void Insert(ent.Cliente t)
        {
            new BS.Cliente().Agregar(t);
        }

        public void Delete(ent.Cliente t)
        {
            new BS.Cliente().Eliminar(t);
        }

        public void Update(ent.Cliente t)
        {
            new BS.Cliente().Modificar(t);
        }
    }
}
