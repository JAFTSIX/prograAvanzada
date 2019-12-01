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
   public class Favoritos

    {

        private readonly Repositorio<tb_Favoritos> _repositorio = new Repositorio<tb_Favoritos>(new ConexionVintage());
        public void Agregar(tb_Favoritos entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }


        public void Eliminar(tb_Favoritos entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }

        public void Guardar()
        {
            _repositorio.Guardar();
        }

        public void Modificar(tb_Favoritos entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }

        public tb_Favoritos TraerId(int Id)
        {
            return _repositorio.TraerId(Id);
        }

        public IEnumerable<tb_Favoritos> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }

    }
}
