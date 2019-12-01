using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO.Interface;
using ent = DO.Objeto;
using dato = BDVintageModel;
using dal = DAL;
using AutoMapper;
using System.Linq.Expressions;

namespace BS
{
   public  class Cliente : ICRUD<ent.Cliente>
    {
        public void Agregar(ent.Cliente t)
        {
            var _ent = Mapper.Map<ent.Cliente, dato.tb_Cliente>(t);
            new dal.Cliente().Agregar(_ent);
        }

        //public ent.Cliente Buscar(Expression<Func<ent.Cliente, bool>> T)
        //{
        //    throw new NotImplementedException();
        //}

        public void Eliminar(ent.Cliente t)
        {
            var _ent = Mapper.Map<ent.Cliente, dato.tb_Cliente>(t);
            new dal.Cliente().Eliminar(_ent);
        }

        public void Modificar(ent.Cliente t)
        {
            var _ent = Mapper.Map<ent.Cliente, dato.tb_Cliente>(t);
            new dal.Cliente().Modificar(_ent);
        }

        public ent.Cliente TraerId(int id)
        {
            var consulta = new dal.Cliente().TraerId(id);
            var Result = Mapper.Map<dato.tb_Cliente, ent.Cliente>(consulta);
            return Result;
        }

        public IEnumerable<ent.Cliente> TraerTodo()
        {
            var consulta = new dal.Cliente().TraerTodo();
            var Result = Mapper.Map<IEnumerable<dato.tb_Cliente>, IEnumerable<ent.Cliente>>(consulta);
            return Result;
        }
    }
}
