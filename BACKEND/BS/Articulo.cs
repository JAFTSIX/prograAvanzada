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
    public class Articulo:ICRUD<DO.Objeto.Articulo>
    {
        public void Agregar(DO.Objeto.Articulo t)
        {
            var _ent = Mapper.Map<DO.Objeto.Articulo, tb_Articulo>(t);
            new DAL.Articulo().Agregar(_ent);
        }

   

        public void Eliminar(DO.Objeto.Articulo t)
        {
            var _ent = Mapper.Map<DO.Objeto.Articulo, tb_Articulo>(t);
            new DAL.Articulo().Eliminar(_ent);
        }

        public void Modificar(DO.Objeto.Articulo t)
        {
            var _ent = Mapper.Map<DO.Objeto.Articulo, tb_Articulo>(t);
            new DAL.Articulo().Modificar(_ent);
        }

        public DO.Objeto.Articulo TraerId(int id)
        {
            var consulta = new DAL.Articulo().TraerId(id);
            var Result = Mapper.Map<tb_Articulo, DO.Objeto.Articulo>(consulta);
            return Result;
        }

        public IEnumerable<DO.Objeto.Articulo> TraerTodo()
        {
            var consulta = new DAL.Articulo().TraerTodo();
            var Result = Mapper.Map<IEnumerable<tb_Articulo>, IEnumerable<DO.Objeto.Articulo>>(consulta);
            return Result;
        }
    }
}
