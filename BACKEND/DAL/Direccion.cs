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
    public class Direccion  
    {
        private readonly Repositorio<tb_Direccion> _repositorio = new Repositorio<tb_Direccion>(new ConexionVintage());
        public void Agregar(tb_Direccion entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }


        public void Eliminar(tb_Direccion entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }

        public void Guardar()
        {
            _repositorio.Guardar();
        }

        public void Modificar(tb_Direccion entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }

        public tb_Direccion TraerId(int Id)
        {
            return _repositorio.TraerId(Id);
        }

        public IEnumerable<tb_Direccion> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }

       
    }
}
