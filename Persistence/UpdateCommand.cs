using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semestre_Tres.Persistence
{
    internal class UpdateCommand: DatabaseConnection
    {

        public UpdateCommand() : base() { }
        public UpdateCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un UPDATE y devuelve el número de filas afectadas.
        /// </summary>
        public int ExecuteUpdate(string query, SqlParameter[]? parameters = null)
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
                throw new Exception($"Error SQL al ejecutar UPDATE: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
