using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visual.Models
{
    public class EncabezadoViewModel
    {
        public int no_Compra { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> pend { get; set; }
        public int id_Cliente { get; set; }
    }
}