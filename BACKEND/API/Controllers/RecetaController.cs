using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{
    [Route("api/recetas")]
    public class RecetaController : ApiController
    {

        [Route("api/recetas/GetAll")]
        [HttpGet]
        public IEnumerable<ent.Receta> GetAll()
        {
            return new BS.Receta().TraerTodo();
        }

        [Route("api/recetas/GetOneById/5")]
        [HttpGet]
        public ent.Receta GetOneById(int id)
        {
            return new BS.Receta().TraerId(id);
        }

        [Route("api/recetas/Insert")]
        [HttpPost]
        public void Insert(ent.Receta t)
        {
            new BS.Receta().Agregar(t);
        }

        [Route("api/recetas/Delete")]
        [HttpPost]
        public void Delete(ent.Receta t)
        {
            new BS.Receta().Eliminar(t);
        }

        [Route("api/recetas/Update")]
        [HttpPost]
        public void Update(ent.Receta t)
        {
            new BS.Receta().Modificar(t);
        }
    }
}
