using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ConfiguracionDB
{
    internal class ConnectionDB
    {
        private string connectionString;
        
        public ConnectionDB(string _connectionString)
        {
            this.connectionString = _connectionString;
        }

        public NpgsqlConnection OpenConnection()
        {
            try
            {
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
