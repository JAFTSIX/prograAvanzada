using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Modelo;
using DAL.Repository;
using dato = BDVintageModel;


namespace DAL
{
    public class Cliente  
    {
        private Repositorio<dato.tb_Cliente> _repositorio = new Repositorio<dato.tb_Cliente>(new ConexionVintage());

        public void Agregar(dato.tb_Cliente entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }

        public void Modificar(dato.tb_Cliente entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }
        public void Eliminar(dato.tb_Cliente entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }
        public IEnumerable<dato.tb_Cliente> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }
        public dato.tb_Cliente TraerId(int id)
        {
            return _repositorio.TraerId(id);
        }
    }
}
