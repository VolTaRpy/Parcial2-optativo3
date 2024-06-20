using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Producto
{
    public class ProductoModel
    {
        public int id_producto { get; set; }
        public string descripcion { get; set; }
        public int cantidad_minima { get; set; }//int
        public int cantidad_stock { get; set; }//int
        public int precio_compra { get; set; }//int
        public int precio_venta { get; set; }//int
        public string categoria { get; set; }
        public string marca { get; set; }
        public string estado { get; set; }
    }
}
