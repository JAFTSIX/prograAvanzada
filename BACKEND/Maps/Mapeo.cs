using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ent = DO.Objeto;
using dato = BDVintageModel;//Algun tonto no le puso el namespace bien cuando creó un nuevo context... (DAL.Entidades)


namespace Maps
{
    public class Mapeo
    {
        public static void CrearMapas()
        {
            try
            {
                Mapper.Initialize(Mapa =>
                {
                    Mapa.CreateMap<ent.Articulo, dato.tb_Articulo>();
                    Mapa.CreateMap<dato.tb_Articulo, ent.Articulo>();

                    Mapa.CreateMap<ent.Cliente, dato.tb_Cliente>();
                    Mapa.CreateMap<dato.tb_Cliente, ent.Cliente>();

                    Mapa.CreateMap<ent.Direccion, dato.tb_Direccion>();
                    Mapa.CreateMap<dato.tb_Direccion, ent.Direccion>();

                    Mapa.CreateMap<ent.Encabezado, dato.tb_Encabezado>();
                    Mapa.CreateMap<dato.tb_Encabezado, ent.Encabezado>();

                    Mapa.CreateMap<ent.Favoritos, dato.tb_Favoritos>();
                    Mapa.CreateMap<dato.tb_Favoritos, ent.Favoritos>();

                    Mapa.CreateMap<ent.Historial, dato.tb_Historial>();
                    Mapa.CreateMap<dato.tb_Historial, ent.Historial>();

                    Mapa.CreateMap<ent.LineaPedido, dato.tb_LineaPedido>();
                    Mapa.CreateMap<dato.tb_LineaPedido, ent.LineaPedido>();

                    Mapa.CreateMap<ent.Receta, dato.tb_Receta>();
                    Mapa.CreateMap<dato.tb_Receta, ent.Receta>();

                   

                });
            }
            catch(Exception)
            {

            }
        }
    }
}
