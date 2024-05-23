using Dapper;
using Repository.ConfiguracionDB;
using Repository.Personas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sucursal
{
    public class SucursalRepository : ISucursalRepository
    {
        IDbConnection connection;

        public SucursalRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(SucursalModel sucursalModel)
        {
            try
            {
                connection.Execute("INSERT INTO sucursal(descripcion, direccion, telefono, whatsapp, mail, estado)" +
                    $"Values(@descripcion, @direccion, @telefono, @whatsapp, @mail, @estado)", sucursalModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM sucursal WHERE id_sucursal = {id}");
            return true;
        }

        public IEnumerable<SucursalModel> GetAll()
        {
            return connection.Query<SucursalModel>("SELECT * FROM sucursal");
        }

        public bool update(SucursalModel sucursalModel)
        {
            try
            {
                connection.Execute("UPDATE sucursal SET" +
                    "descripcion = @descripcion," +
                    "direccion = @direccion," +
                    "telefono = @telefono," +
                    "whatsapp = @whatsapp," +
                    "mail = @mail" +
                    "estado = @estado" +
                    $"WHERE id_sucursal = @id_sucursal", sucursalModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
