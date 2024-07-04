using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DetallePedido
{
    public interface IDetallePedido
    {
        bool add(DetallePedidoModel detallePedido);
        bool update(DetallePedidoModel detallePedido);
        bool delete(int id);
        IEnumerable<DetallePedidoModel> getAll();
        IEnumerable<DetallePedidoModel> get(int id);

    }
}
