using Dapper;
using Repository.ConfiguracionDB;
using Repository.Personas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Producto
{
    public class ProductoRepository : IProducto
    {
        IDbConnection connection;

        public ProductoRepository (string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }
        public bool add(ProductoModel producto)
        {
            try
            {
                connection.Execute("INSERT INTO producto(descripcion, cantidad_minima, cantidad_stock, precio_compra, precio_venta, categoria, marca, estado)" +
                    $"Values(@descripcion, @cantidad_minima, @cantidad_stock, @precio_compra, @precio_venta, @categoria, @marca, @estado)", producto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM producto WHERE id_producto = {id}");
            return true;
        }

        public IEnumerable<ProductoModel> Get(int id)
        {
            string sql = "SELECT * FROM producto ";
            try
            {
                if (id != 0)
                {
                    sql += $" WHERE id_producto = {id}";
                }
                return connection.Query<ProductoModel>(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ProductoModel> GetAll()
        {
            return connection.Query<ProductoModel>("SELECT * FROM producto");
        }

        public bool update(ProductoModel producto)
        {
            try 
            {
                connection.Execute("UPDATE producto SET" +
                    "descripcion = @descripcion, " +
                    "cantidad_minima = @cantidad_minima, " +
                    "cantidad_stock = @cantidad_stock, " +
                    "precio_compra = @precio_compra, " +
                    "precio_venta = @precio_venta, " +
                    "categoria = @categoria, " +
                    "marca = @marca, " +
                    "estado = @estado" +
                    $"WHERE id_producto = @id_producto",producto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
    }
}
