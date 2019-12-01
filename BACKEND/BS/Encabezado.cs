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
    public class Encabezado: ICRUD<DO.Objeto.Encabezado>
    {
        public void Agregar(DO.Objeto.Encabezado t)
        {
            var _ent = Mapper.Map<DO.Objeto.Encabezado, tb_Encabezado>(t);
            new DAL.Encabezado().Agregar(_ent);
        }

        public void Eliminar(DO.Objeto.Encabezado t)
        {
            var _ent = Mapper.Map<DO.Objeto.Encabezado, tb_Encabezado>(t);
            new DAL.Encabezado().Eliminar(_ent);
        }

        public void Modificar(DO.Objeto.Encabezado t)
        {
            var _ent = Mapper.Map<DO.Objeto.Encabezado, tb_Encabezado>(t);
            new DAL.Encabezado().Modificar(_ent);
        }

        public DO.Objeto.Encabezado TraerId(int id)
        {
            var consulta = new DAL.Encabezado().TraerId(id);
            var Result = Mapper.Map<tb_Encabezado, DO.Objeto.Encabezado>(consulta);
            return Result;
        }

        public IEnumerable<DO.Objeto.Encabezado> TraerTodo()
        {
            var consulta = new DAL.Encabezado().TraerTodo();
            var Result = Mapper.Map<IEnumerable<tb_Encabezado>, IEnumerable<DO.Objeto.Encabezado>>(consulta);
            return Result;
        }

    }
}
