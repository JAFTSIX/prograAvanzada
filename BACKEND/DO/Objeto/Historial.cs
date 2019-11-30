using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Objeto
{
    public class Historial
    {
        public int pkHistorial { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int iCliente_id { get; set; }
        public int fkReceta { get; set; }
    }
}
