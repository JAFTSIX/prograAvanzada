//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDVintageModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Favoritos
    {
        public int pkFavoritos { get; set; }
        public int fkReceta { get; set; }
        public int id_Cliente { get; set; }
    
        public virtual tb_Cliente tb_Cliente { get; set; }
        public virtual tb_Receta tb_Receta { get; set; }
    }
}