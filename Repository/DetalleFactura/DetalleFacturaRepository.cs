using Dapper;
using Repository.ConfiguracionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DetalleFactura
{
    public class DetalleFacturaRepository : IDetalleFactura
    {
        IDbConnection connection;

        public DetalleFacturaRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(DetalleFacturaModel detalleFactura)
        {
            try
            {
                connection.Execute("INSERT INTO detalle_factura(id_factura, id_producto, cantidad_producto, subtotal)" +
                    $"Values(@id_factura, @id_producto, @cantidad_producto, @subtotal)", detalleFactura);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM detalle_factura WHERE id_detalle_factura = {id}");
            return true;
        }

        public IEnumerable<DetalleFacturaModel> getAll()
        {
            return connection.Query<DetalleFacturaModel>("SELECT * FROM detalle_factura");
        }

        public bool update(DetalleFacturaModel detalleFactura)
        {
            try
            {
                connection.Execute("UPDATE detalle_factura SET"+
                    "id_factura = @id_factura, " +
                    "id_producto = @id_producto, " +
                    "cantidad_producto = @cantidad_producto, " +
                    "subtotal = @subtotal" +
                    "WHERE id_detalle_factura = @id_detalle_Factura", detalleFactura);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
