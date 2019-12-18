using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visual.Models
{
    public class ArticuloViewModel
    {
        public int no_articulo { get; set; }
        public string nombre { get; set; }
        public Nullable<int> existencia { get; set; }
        public Nullable<double> Precio { get; set; }
        public string Descrip { get; set; }
        public string Vurl { get; set; }
    }
}