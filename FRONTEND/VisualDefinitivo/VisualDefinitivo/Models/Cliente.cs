using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VisualDefinitivo.Models
{
    public class Cliente
    {


        private static Cliente Instancia = null;

        public static Cliente INSTANCIA
        {
            get
            {
                if (Instancia == null)
                {
                    return new Cliente();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        public int id_Cliente { get; set; }
        public string vNombre { get; set; }
        public string vApellido { get; set; }
        public string vApelldo2 { get; set; }
        public string vContra { get; set; }
        public Nullable<int> iEdad { get; set; }
        public int id_direccion { get; set; }
        public string vROL { get; set; }
        public string vCorreo { get; set; }
    }
}