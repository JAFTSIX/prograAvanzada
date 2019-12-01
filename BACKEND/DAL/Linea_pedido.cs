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
    class Linea_pedido
    {
        private readonly Repositorio<tb_LineaPedido> _repositorio = new Repositorio<tb_LineaPedido>(new ConexionVintage());
        public void Agregar(tb_LineaPedido entidad)
        {
            _repositorio.Agregar(entidad);
            _repositorio.Guardar();
        }


        public void Eliminar(tb_LineaPedido entidad)
        {
            _repositorio.Eliminar(entidad);
            _repositorio.Guardar();
        }

        public void Guardar()
        {
            _repositorio.Guardar();
        }

        public void Modificar(tb_LineaPedido entidad)
        {
            _repositorio.Modificar(entidad);
            _repositorio.Guardar();
        }

        public tb_LineaPedido TraerId(int Id)
        {
            return _repositorio.TraerId(Id);
        }

        public IEnumerable<tb_LineaPedido> TraerTodo()
        {
            return _repositorio.TraerTodo().ToList();
        }

    }
}
