using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO.Interface;

using BDVintageModel;

using AutoMapper;

namespace BS
{
    public class compras
    {
        public void comprar(DO.Objeto.Pedido t)
        {
            BDVintageModel.tb_Encabezado Enca = new BDVintageModel.tb_Encabezado();
            Nullable<double> total = 0;

            foreach (var item in t.linea)
            {
                item.precio_Total = item.precio_Unidad * item.unidades;
                total += item.precio_Total;
                var _ent = Mapper.Map<DO.Objeto.LineaPedido, BDVintageModel.tb_LineaPedido>(item);
                Enca.tb_LineaPedido.Add(_ent);
            }

            
            Enca.total = total;
            Enca.pend = 0;
            Enca.id_Cliente = t.id_cliente;
            
            new DAL.Encabezado().Agregar(Enca);

            


        }
    }
}
