using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Objeto
{
    public class Encabezado
    {
        public int no_Compra { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> pend { get; set; }
        public int id_Cliente { get; set; }
    }
}
