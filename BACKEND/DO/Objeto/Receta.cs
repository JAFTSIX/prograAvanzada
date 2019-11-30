using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Objeto
{
    public class Receta
    {
        public int pkReceta { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> Dfecha_publicacion { get; set; }
        public string vTexto { get; set; }
        public string vimgurl { get; set; }
        public string vVidurl { get; set; }
    }
}
