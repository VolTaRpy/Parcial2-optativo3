using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DetallePedido
{
    public class DetallePedidoModel
    {
        public int id_detalle_pedido { get; set; }
        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int cantidad_producto { get; set; }
        public int subtotal { get; set; }
    }
}
