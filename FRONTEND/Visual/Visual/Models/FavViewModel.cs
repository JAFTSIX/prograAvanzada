using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visual.Models
{
    public class FavViewModel
    {
        public int pkFavoritos { get; set; }
        public int fkReceta { get; set; }
        public int id_Cliente { get; set; }
    }
}