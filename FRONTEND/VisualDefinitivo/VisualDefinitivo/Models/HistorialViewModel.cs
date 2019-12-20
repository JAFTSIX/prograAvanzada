using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visual.Models
{
    public class HistorialViewModel
    {
        public int pkHistorial { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int iCliente_id { get; set; }
        public int fkReceta { get; set; }
      
    }


    public class Historialmostrar
    {
        public int pkHistorial { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int iCliente_id { get; set; }
        public int fkReceta { get; set; }

        public string nombre { get; set; }
    }
}