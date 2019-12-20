using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visual.Models
{
    public class RecetasViewModel
    {
        public int pkReceta { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> Dfecha_publicacion { get; set; }
        public string vTexto { get; set; }
        public string vimgurl { get; set; }
        public string vVidurl { get; set; }
    }
}