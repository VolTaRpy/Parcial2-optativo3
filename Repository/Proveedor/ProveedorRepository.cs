using Dapper;
using Repository.ConfiguracionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Proveedor
{
    public class ProveedorRepository : IProveedorRepository
    {
        IDbConnection connection; 

        public ProveedorRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(ProveedorModel proveedorModel)
        {
            try
            {
                connection.Execute("INSERT INTO proveedor ( razonsocial, documento, direccion, mail, celular, estado)" +
                    $"Values(@razonsocial, @documento, @direccion, @mail, @celular, @estado)", proveedorModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ProveedorModel> GetAll() 
        {
            return connection.Query<ProveedorModel>("SELECT * FROM proveedor");
        }

        public bool delete(int id) 
        {
            connection.Execute($"DELETE FROM proveedor WHERE id_proveedor = {id}");
            return true;
        }

        public bool update(ProveedorModel proveedorModel) 
        {
            try
            {
                connection.Execute("UPDATE proveedor SET " +
                    "razonsocial = @razonsocial," +
                    "documento = @documento," +
                    "direccion = @direccion," +
                    "mail = @mail," +
                    "celular = @celular," +
                    "estado = @estado" +
                    $"where id_proveedor = @id_proveedor", proveedorModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ProveedorModel> get(int id)
        {
            string sql = "SELECT * FROM proveedor ";
            try
            {
                if (id != 0)
                {
                    sql += $" WHERE id_proveedor = {id}";
                }
                return connection.Query<ProveedorModel>(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
