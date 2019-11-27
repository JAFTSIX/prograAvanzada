using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BDVintageModel;
using DAL.Modelo;
using DAL.Repository;


namespace DAL
{
    public class Direccion : IRepositorio<tb_Direccion>
    {
        private readonly Repositorio<tb_Direccion> _repository = new Repositorio<tb_Direccion>(new ConexionVintage());
        public void Agregar(tb_Direccion entidad)
        {
            throw new NotImplementedException();
        }

        public IQueryable<tb_Direccion> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tb_Direccion> Buscar(Expression<Func<tb_Direccion, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(tb_Direccion entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Modificar(tb_Direccion entidad)
        {
            throw new NotImplementedException();
        }

        public tb_Direccion TraerId(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tb_Direccion> TraerTodo()
        {
            return _repository.TraerTodo().ToList();
        }

        public tb_Direccion TraerUno(Expression<Func<tb_Direccion, bool>> predicado)
        {
            throw new NotImplementedException();
        }
    }
}
