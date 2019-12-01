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
    public class Favoritos : ICRUD<DO.Objeto.Favoritos>
    {
        public void Agregar(DO.Objeto.Favoritos t)
        {
            var _ent = Mapper.Map<DO.Objeto.Favoritos, tb_Favoritos>(t);
            new DAL.Favoritos().Agregar(_ent);
        }

        public void Eliminar(DO.Objeto.Favoritos t)
        {
            var _ent = Mapper.Map<DO.Objeto.Favoritos, tb_Favoritos>(t);
            new DAL.Favoritos().Eliminar(_ent);
        }

        public void Modificar(DO.Objeto.Favoritos t)
        {
            var _ent = Mapper.Map<DO.Objeto.Favoritos, tb_Favoritos>(t);
            new DAL.Favoritos().Modificar(_ent);
        }

        public DO.Objeto.Favoritos TraerId(int id)
        {
            var consulta = new DAL.Favoritos().TraerId(id);
            var Result = Mapper.Map< tb_Favoritos, DO.Objeto.Favoritos>(consulta);
            return Result;
        }

        public IEnumerable<DO.Objeto.Favoritos> TraerTodo()
        {
            var consulta = new DAL.Favoritos().TraerTodo();
            var Result = Mapper.Map<IEnumerable<tb_Favoritos>, IEnumerable<DO.Objeto.Favoritos>>(consulta);
            return Result;
        }
    }
}
