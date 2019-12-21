using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Visual.Models;

namespace VisualDefinitivo.Models
{
    public class RegisterViewModel
    {

        public ClientesViewModel modelo { get; set; }
        public List<SelectListItem> paises_items{ get; set; }
}
}