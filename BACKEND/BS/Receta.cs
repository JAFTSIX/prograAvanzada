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
    class Receta: ICRUD<DO.Objeto.Receta>
    {

        public void Agregar(DO.Objeto.Receta t)
        {
            var _ent = Mapper.Map<DO.Objeto.Receta, tb_Receta>(t);
            new DAL.Receta().Agregar(_ent);
        }

        public void Eliminar(DO.Objeto.Receta t)
        {
            var _ent = Mapper.Map<DO.Objeto.Receta, tb_Receta>(t);
            new DAL.Receta().Eliminar(_ent);
        }

        public void Modificar(DO.Objeto.Receta t)
        {
            var _ent = Mapper.Map<DO.Objeto.Receta, tb_Receta>(t);
            new DAL.Receta().Modificar(_ent);
        }

        public DO.Objeto.Receta TraerId(int id)
        {
            var consulta = new DAL.Receta().TraerId(id);
            var Result = Mapper.Map<tb_Receta, DO.Objeto.Receta>(consulta);
            return Result;
        }

        public IEnumerable<DO.Objeto.Receta> TraerTodo()
        {
            var consulta = new DAL.Receta().TraerTodo();
            var Result = Mapper.Map<IEnumerable<tb_Receta>, IEnumerable<DO.Objeto.Receta>>(consulta);
            return Result;
        }


    }
}
