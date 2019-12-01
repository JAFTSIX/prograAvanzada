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
    public class Direccion:ICRUD<DO.Objeto.Direccion>
    {
        public void Agregar(DO.Objeto.Direccion t)
        {
            var _ent = Mapper.Map<DO.Objeto.Direccion, tb_Direccion>(t);
            new DAL.Direccion().Agregar(_ent);
        }

        public void Eliminar(DO.Objeto.Direccion t)
        {
            var _ent = Mapper.Map<DO.Objeto.Direccion, tb_Direccion>(t);
            new DAL.Direccion().Eliminar(_ent);
        }

        public void Modificar(DO.Objeto.Direccion t)
        {
            var _ent = Mapper.Map<DO.Objeto.Direccion, tb_Direccion>(t);
            new DAL.Direccion().Modificar(_ent);
        }

        public DO.Objeto.Direccion TraerId(int id)
        {
            var consulta = new DAL.Direccion().TraerId(id);
            var Result = Mapper.Map<tb_Direccion, DO.Objeto.Direccion>(consulta);
            return Result;
        }

        public IEnumerable<DO.Objeto.Direccion> TraerTodo()
        {
            var consulta = new DAL.Direccion().TraerTodo();
            var Result = Mapper.Map<IEnumerable<tb_Direccion>, IEnumerable<DO.Objeto.Direccion>>(consulta);
            return Result;
        }
    }
}
