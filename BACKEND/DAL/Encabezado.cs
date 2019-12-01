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
    class Encabezado
    {
        private readonly Repositorio<tb_Encabezado> _repositorio = new Repositorio<tb_Encabezado>(new ConexionVintage());
        public void Agregar(tb_Encabezado entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }


        public void Eliminar(tb_Encabezado entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }

        public void Guardar()
        {
            _repositorio.Guardar();
        }

        public void Modificar(tb_Encabezado entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }

        public tb_Encabezado TraerId(int Id)
        {
            return _repositorio.TraerId(Id);
        }

        public IEnumerable<tb_Encabezado> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }
    }
}
