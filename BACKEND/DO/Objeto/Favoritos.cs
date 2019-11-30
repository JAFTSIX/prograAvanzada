using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Objeto
{
    public class Favoritos
    {
        public int pkFavoritos { get; set; }
        public int fkReceta { get; set; }
        public int id_Cliente { get; set; }
    }
}
