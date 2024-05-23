using Dapper;
using Repository.ConfiguracionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Factura
{
    public class FacturaRepository : IFacturaRepository
    {
        IDbConnection connection;

        public FacturaRepository(string connectionString)
        {
            connection =  new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(FacturaModel facturaModel)
        {
            try
            {
                connection.Execute("INSERT INTO factura(id_cliente, id_sucursal, numero_factura, fecha_hora, total, total_iva5,total_iva10, total_iva, total_letras, sucursal)" +
                   $"Values(@id_cliente, @id_sucursal, @numero_factura, @fecha_hora, @total, @total_iva5,@total_iva10, @total_iva, @total_letras, @sucursal)", facturaModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM factura where id_factura = {id}");
            return true;
        }

        public IEnumerable<FacturaModel> GetAll()
        {
            return connection.Query<FacturaModel>("SELECT * FROM factura");
        }

        public bool update(FacturaModel facturaModel)
        {
            try
            {
                connection.Execute("UPDATE factura SET " +
                    "id_cliente = @id_cliente," +
                    "id_sucursal = @id_sucursal," +
                    "numero_factura = @numero_factura," +
                    "fecha_hora = @fecha_hora," +
                    "total = @total," +
                    "total_iva5 = @total_iva5," +
                    "total_iva10 = @total_iva10," +
                    "total_iva = @total_iva," +
                    "total_letras = @total_letras," +
                    "sucursal = @sucursal" +
                    $"where id_factura = @id_factura", facturaModel); 
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
