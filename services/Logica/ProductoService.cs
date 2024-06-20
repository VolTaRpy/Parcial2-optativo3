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
            return validarDatos(producto) ? productoRepository.add(producto) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }

        public bool delete(int id)
        {
            return id > 0 ? productoRepository.delete(id) : false;
        }

        public IEnumerable<ProductoModel> Get(int id)
        {
            return productoRepository.Get(id);
        }

        public IEnumerable<ProductoModel> GetAll()
        {
            return productoRepository.GetAll();
        }

        public bool update(ProductoModel producto)
        {
            return validarDatos(producto) ? productoRepository.update(producto) : throw new Exception("Error en la validacion de datos, favor corroborar");
        }

        private bool validarDatos(ProductoModel producto)
        {
            int num;


            if (producto == null)
                return false;
            if (string.IsNullOrEmpty(producto.descripcion))
                return false;
            if (string.IsNullOrEmpty(producto.cantidad_minima))
                return false;
            if (!int.TryParse(producto.cantidad_minima, out num) || num<1)
                return false;
            if (string.IsNullOrEmpty(producto.cantidad_stock))
                return false;
            if (string.IsNullOrEmpty(producto.precio_compra))
                return false;
            if (!int.TryParse(producto.precio_compra, out num) || num <= 0)
                return false;
            if (string.IsNullOrEmpty(producto.precio_venta))
                return false;
            if (!int.TryParse(producto.precio_venta, out num) || num <= 0)
                return false;
            if (string.IsNullOrEmpty(producto.categoria))
                return false;
            if (string.IsNullOrEmpty(producto.marca))
                return false;
            if (string.IsNullOrEmpty(producto.estado))
                return false;

            return true;
        }
    }
}
