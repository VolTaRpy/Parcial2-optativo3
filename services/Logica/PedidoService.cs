using Repository.Pedido_Compra;
using Repository.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class PedidoService : IPedido
    {
        private PedidoRepository pedidoRepository;
        public PedidoService(string connectionString)
        {
            pedidoRepository = new PedidoRepository(connectionString);
        }

        public bool add(PedidoModel pedido)
        {
            return validarDatos(pedido) ? pedidoRepository.add(pedido) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }

        public bool delete(int id)
        {
            return id > 0 ? pedidoRepository.delete(id) : false;
        }

        public IEnumerable<PedidoModel> Get(int id)
        {
            return pedidoRepository.Get(id);
        }

        public IEnumerable<PedidoModel> GetAll()
        {
            return pedidoRepository.GetAll();
        }

        public bool update(PedidoModel pedido)
        {
            return validarDatos(pedido) ? pedidoRepository.update(pedido) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }
        private bool validarDatos(PedidoModel pedido)
        {
            int num;
            if (pedido == null)
                return false;
            if (!int.TryParse(Convert.ToString(pedido.total), out num) )
                return false;
            return true;
        }
    }
}
