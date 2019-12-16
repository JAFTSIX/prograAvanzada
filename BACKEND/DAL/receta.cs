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
    public class Receta
    {

        private readonly Repositorio<tb_Receta> _repositorio = new Repositorio<tb_Receta>(new ConexionVintage());
        public void Agregar(tb_Receta entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }


        public void Eliminar(tb_Receta entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }

        public void Guardar()
        {
            _repositorio.Guardar();
        }

        public void Modificar(tb_Receta entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }

        public tb_Receta TraerId(int Id)
        {
            return _repositorio.TraerId(Id);
        }

        public IEnumerable<tb_Receta> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }

        public IEnumerable<tb_Receta> TraerIndex()
        {
            return _repositorio.TraerIndex().ToList();
        }
    }
}
