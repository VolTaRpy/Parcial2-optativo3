using Dapper;
using Repository.ConfiguracionDB;
using Repository.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DetallePedido
{
    public class DetallePedidoRepository : IDetallePedido
    {
        IDbConnection connection;

        public DetallePedidoRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(DetallePedidoModel detallePedido)
        {
            try
            {
                connection.Execute("INSERT INTO detalle_pedido(id_pedido, id_producto, cantidad_producto, subtotal)" +
                    $"Values(@id_pedido, @id_producto, @cantidad_producto, @subtotal)", detallePedido);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM detalle_pedido WHERE id_detalle_pedido = {id}");
            return true;
        }

        public IEnumerable<DetallePedidoModel> get(int id)
        {
            string sql = "SELECT * FROM detalle_pedido ";
            try
            {
                if (id != 0)
                {
                    sql += $" WHERE id_detalle_pedido = {id}";
                }
                return connection.Query<DetallePedidoModel>(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<DetallePedidoModel> getAll()
        {
            return connection.Query<DetallePedidoModel>("SELECT * FROM detalle_pedido");
        }

        public bool update(DetallePedidoModel detallePedido)
        {
            try
            {
                connection.Execute("UPDATE detalle_pedido SET"+
                    "id_pedido = @id_pedido, " +
                    "id_producto = @id_producto, " +
                    "cantidad_producto = @cantidad_producto, " +
                    "subtotal = @subtotal" +
                    "WHERE id_detalle_pedido = @id_detalle_pedido", detallePedido);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
