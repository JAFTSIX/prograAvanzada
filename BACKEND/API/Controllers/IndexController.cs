using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = DO.Objeto;

namespace API.Controllers
{
    [Route("api/index")]
    public class IndexController : ApiController
    {

        [Route("api/index/inicio")]
        [HttpGet]
        public IEnumerable<ent.Receta> inicio()
        {


            return new BS.Receta().TraerIndex() ;
        }
    }
}
