using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Interface
{
    public interface ICRUD<T>
    {
        void Agregar(T t);
        IEnumerable<T> TraerTodo();
        void Eliminar(T t);
        void Modificar(T t);

        T TraerId(int id);
    }
}
