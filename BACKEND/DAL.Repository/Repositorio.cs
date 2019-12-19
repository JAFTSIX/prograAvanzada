using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repositorio<T> : IRepositorio<T>, IDisposable where T : class
    {

        private readonly DbContext _context;

        public void Dispose()
        {
            return;
        }

        public Repositorio(DbContext Contexto)
        {
            _context = Contexto;
        }

        public void Agregar(T entidad)
        {
            if(_context.Entry<T>(entidad).State != System.Data.Entity.EntityState.Detached)
            {
                _context.Entry<T>(entidad).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                _context.Set<T>().Add(entidad);
            }
            
        }



        public IQueryable<T> AsQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        //public IEnumerable<T> Buscar(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        //{
        //    return _context.Set<T>().Where(predicado);
        //}

        public void Eliminar(T entidad)
        {
            if(_context.Entry(entidad).State == System.Data.Entity.EntityState.Detached)
            {
                _context.Set<T>().Attach(entidad);
                _context.Entry<T>(entidad).State = System.Data.Entity.EntityState.Deleted;
            }
        }

        public void Guardar()
        {
            _context.SaveChanges();
        }

        public void Modificar(T entidad)
        {
            if(_context.Entry(entidad).State == System.Data.Entity.EntityState.Detached)
            {
                _context.Set<T>().Attach(entidad);
                _context.Entry<T>(entidad).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _context.Entry<T>(entidad).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public T TraerId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> TraerTodo()
        {
            return _context.Set<T>();
        }

        public IEnumerable<T> TraerIndex()
        {
            return _context.Set<T>().SqlQuery("select top 3 * from tb_Receta");
        }

        public T TraerUno(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _context.Set<T>().Where(predicado).FirstOrDefault();
        }
    }
}
