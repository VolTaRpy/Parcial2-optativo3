using Repository.Factura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Producto
{
    public interface IProducto
    {
        bool add(ProductoModel producto);
        bool update(ProductoModel producto);
        bool delete(int id);
        IEnumerable<ProductoModel> GetAll();
        IEnumerable<ProductoModel> Get(int id);
    }
}
