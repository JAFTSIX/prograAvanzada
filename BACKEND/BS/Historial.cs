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
    public class Historial: ICRUD<DO.Objeto.Historial>
    {
        public void Agregar(DO.Objeto.Historial t)
        {
            var _ent = Mapper.Map<DO.Objeto.Historial, tb_Historial>(t);
            new DAL.Historial().Agregar(_ent);
        }

        public void Eliminar(DO.Objeto.Historial t)
        {
            var _ent = Mapper.Map<DO.Objeto.Historial, tb_Historial>(t);
            new DAL.Historial().Eliminar(_ent);
        }

        public void Modificar(DO.Objeto.Historial t)
        {
            var _ent = Mapper.Map<DO.Objeto.Historial, tb_Historial>(t);
            new DAL.Historial().Modificar(_ent);
        }

        public DO.Objeto.Historial TraerId(int id)
        {
            var consulta = new DAL.Historial().TraerId(id);
            var Result = Mapper.Map<tb_Historial, DO.Objeto.Historial>(consulta);
            return Result;
        }

        public IEnumerable<DO.Objeto.Historial> TraerTodo()
        {
            var consulta = new DAL.Historial().TraerTodo();
            var Result = Mapper.Map<IEnumerable<tb_Historial>, IEnumerable<DO.Objeto.Historial>>(consulta);
            return Result;
        }
    }
}
