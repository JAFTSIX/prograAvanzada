using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {

        private readonly DbContext _context;



        public Repositorio(DbContext context)
        {
            _context = context;
        }
        public IQueryable<T> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> TraerTodo()
        {
            return _context.Set<T>();
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public T TraerUno(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public T TraerId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Agregar(T entidad)
        {
            throw new NotImplementedException();
        }

        public void Modificar(T entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(T entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        
    }
}
