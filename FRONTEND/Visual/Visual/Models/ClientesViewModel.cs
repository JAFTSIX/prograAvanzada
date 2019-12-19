using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visual.Models
{
    public class ClientesViewModel
    {
        public int id_Cliente { get; set; }
        public string vNombre { get; set; }
        public string vApellido { get; set; }
        public string vApelldo2 { get; set; }
        public string vContra { get; set; }
        public Nullable<int> iEdad { get; set; }
        public int id_direccion { get; set; }
        public string vROL { get; set; }
        public string vCorreo { get; set; }
    }
}