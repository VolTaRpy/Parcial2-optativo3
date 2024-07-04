using Repository.DetallePedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class DetallePedidoService : IDetallePedido
    {
        private DetallePedidoRepository detallePedidoRepository;
        public DetallePedidoService(string connectionString) 
        {
            detallePedidoRepository = new DetallePedidoRepository(connectionString);
        }

        public bool add(DetallePedidoModel detallePedido)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetallePedidoModel> get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetallePedidoModel> getAll()
        {
            throw new NotImplementedException();
        }

        public bool update(DetallePedidoModel detallePedido)
        {
            throw new NotImplementedException();
        }
    }
}
