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
    class Historial
    {
        private readonly Repositorio<tb_Historial> _repositorio = new Repositorio<tb_Historial>(new ConexionVintage());
        public void Agregar(tb_Historial entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }


        public void Eliminar(tb_Historial entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }

        public void Guardar()
        {
            _repositorio.Guardar();
        }

        public void Modificar(tb_Historial entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }

        public tb_Historial TraerId(int Id)
        {
            return _repositorio.TraerId(Id);
        }

        public IEnumerable<tb_Historial> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }


    }
}
