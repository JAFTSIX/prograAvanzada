using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Objeto
{
    public class LineaPedido
    {
        public int no_Pedido { get; set; }
        public int no_articulo { get; set; }
        public Nullable<int> unidades { get; set; }
        public Nullable<double> precio_Unidad { get; set; }
        public Nullable<double> precio_Total { get; set; }
        public int no_Compra { get; set; }
    }
}
