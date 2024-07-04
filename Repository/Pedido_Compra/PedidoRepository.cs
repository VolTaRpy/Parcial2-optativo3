using Dapper;
using Repository.ConfiguracionDB;
using Repository.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Pedido_Compra
{
    public class PedidoRepository : IPedido
    {
        IDbConnection connection;

        public PedidoRepository(string connectionString)
        {
            connection =  new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(PedidoModel pedidoModel)
        {
            try
            {
                connection.Execute("INSERT INTO pedido (id_proveedor, id_sucursal, fecha_hora, total)" +
                   $"Values(@id_proveedor, @id_sucursal, @fecha_hora, @total)", pedidoModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM pedido where id_pedido = {id}");
            return true;
        }

        public IEnumerable<PedidoModel> Get(int id)
        {
            string sql = "SELECT * FROM pedido ";
            try
            {
                if (id != 0)
                {
                    sql += $" WHERE id_pedido = {id}";
                }
                return connection.Query<PedidoModel>(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<PedidoModel> GetAll()
        {
            return connection.Query<PedidoModel>("SELECT * FROM pedido");
        }

        public bool update(PedidoModel pedidoModel)
        {
            try
            {
                connection.Execute("UPDATE pedido SET " +
                    "id_proveedor = @id_proveedor," +
                    "id_sucursal = @id_sucursal," +
                    "fecha_hora = @fecha_hora," +
                    "total = @total," +
                    $"where id_pedido = @id_pedido", pedidoModel); 
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
