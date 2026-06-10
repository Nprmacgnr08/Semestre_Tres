using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semestre_Tres.Persistence
{
    internal class DeleteCommand: DatabaseConnection
    {
        public DeleteCommand() : base() { }
        public DeleteCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un DELETE y devuelve el número de filas afectadas.
        /// </summary>
        public int ExecuteDelete(string query, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                return _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL al ejecutar DELETE: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
