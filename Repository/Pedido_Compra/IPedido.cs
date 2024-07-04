using Repository.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Pedido_Compra
{
    public interface IPedido
    {
        bool add(PedidoModel pedidoModel);
        bool update(PedidoModel pedidoModel);
        bool delete(int id);
        IEnumerable<PedidoModel> GetAll();
        IEnumerable<PedidoModel> Get(int id);
    }
}
