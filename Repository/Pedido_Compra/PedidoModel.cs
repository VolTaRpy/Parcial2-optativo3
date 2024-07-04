using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Pedido_Compra
{
    public class PedidoModel
    {
        public int id_pedido { get; set; }
        public int id_proveedor { get; set; }
        public int id_sucursal { get; set; }
        public DateTime fecha_hora { get; set; }
        public int total { get; set; }   
    }
}
