using Repository.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ProductoService : IProducto
    {
        private ProductoRepository productoRepository;
        public ProductoService(string connectionString)
        {
            productoRepository = new ProductoRepository(connectionString);
        }
        public bool add(ProductoModel producto)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool update(ProductoModel producto)
        {
            throw new NotImplementedException();
        }

        private bool validarDatos(ProductoModel producto)
        {

        }
    }
}
