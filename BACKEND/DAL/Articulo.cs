using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDVintageModel;
using DAL.Modelo;
using DAL.Repository;

namespace DAL
{
    class Articulo
    {

        private readonly Repositorio<tb_Articulo> _repositorio = new Repositorio<tb_Articulo>(new ConexionVintage());
        public void Agregar(tb_Articulo entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }


        public void Eliminar(tb_Articulo entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }

        public void Guardar()
        {
            _repositorio.Guardar();
        }

        public void Modificar(tb_Articulo entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }

        public tb_Articulo TraerId(int Id)
        {
            return _repositorio.TraerId(Id);
        }

        public IEnumerable<tb_Articulo> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }

    }
}
