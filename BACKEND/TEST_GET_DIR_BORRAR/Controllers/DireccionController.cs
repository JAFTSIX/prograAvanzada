using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TEST_GET_DIR_BORRAR.Controllers
{
    [Route("api/Dir")]
    public class DireccionController : ApiController
    {
        [Route("api/Dir/All")]
        
        public IEnumerable<BDVintageModel.tb_Direccion> GetAll()
        {


            return new DAL.Direccion().TraerTodo();
        }



    }
}
