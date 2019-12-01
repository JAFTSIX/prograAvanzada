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
    public class Linea_pedido:ICRUD<DO.Objeto.LineaPedido>
    {
        public void Agregar(DO.Objeto.LineaPedido t)
        {
            var _ent = Mapper.Map<DO.Objeto.LineaPedido, tb_LineaPedido>(t);
            new DAL.Linea_pedido().Agregar(_ent);
        }

        public void Eliminar(DO.Objeto.LineaPedido t)
        {
            var _ent = Mapper.Map<DO.Objeto.LineaPedido, tb_LineaPedido>(t);
            new DAL.Linea_pedido().Eliminar(_ent);
        }

        public void Modificar(DO.Objeto.LineaPedido t)
        {
            var _ent = Mapper.Map<DO.Objeto.LineaPedido, tb_LineaPedido>(t);
            new DAL.Linea_pedido().Modificar(_ent);
        }

        public DO.Objeto.LineaPedido TraerId(int id)
        {
            var consulta = new DAL.Linea_pedido().TraerId(id);
            var Result = Mapper.Map<tb_LineaPedido, DO.Objeto.LineaPedido>(consulta);
            return Result;
        }

        public IEnumerable<DO.Objeto.LineaPedido> TraerTodo()
        {
            var consulta = new DAL.Linea_pedido().TraerTodo();
            var Result = Mapper.Map<IEnumerable<tb_LineaPedido>, IEnumerable<DO.Objeto.LineaPedido>>(consulta);
            return Result;
        }
    }
}
