using Dapper;
using Repository.ConfiguracionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Personas
{
    public class PersonaRepository : IPersonaRepository
    {
        IDbConnection connection; 

        public PersonaRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(PersonaModel personaModel)
        {
            try
            {
                connection.Execute("INSERT INTO cliente(id_banco, nombre, apellido, documento, direccion, mail, celular, estado)"+
                    $"Values(@id_banco, @nombre, @apellido, @documento, @direccion, @mail, @celular, @estado)", personaModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<PersonaModel> GetAll() 
        {
            return connection.Query<PersonaModel>("SELECT * FROM cliente");
        }

        public bool delete(int id) 
        {
            connection.Execute($"DELETE FROM cliente WHERE id_cliente = {id}");
            return true;
        }

        public bool update(PersonaModel personaModel) 
        {
            try
            {
                connection.Execute("UPDATE cliente SET " +
                    "id_banco = @id_banco," +
                    "nombre = @nombre," +
                    "apellido = @apellido," +
                    "documento = @documento," +
                    "direccion = @direccion," +
                    "mail = @mail," +
                    "celular = @celular," +
                    "estado = @estado" +
                    $"where id_cliente = @id_cliente", personaModel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<PersonaModel> get(int id)
        {
            string sql = "SELECT * FROM cliente ";
            try
            {
                if (id != 0)
                {
                    sql += $" WHERE id_cliente = {id}";
                }
                return connection.Query<PersonaModel>(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
