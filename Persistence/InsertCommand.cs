using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestre_Tres.Persistence
{
    public class InsertCommand : DatabaseConnection
    {
        public InsertCommand() : base() { }
        public InsertCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un INSERT y devuelve el número de filas afectadas.
        /// </summary>
        /// <param name="query">Sentencia INSERT parametrizada.</param>
        /// <param name="parameters">Parámetros SQL.</param>
        /// <returns>Número de filas insertadas (generalmente 1).</returns>
        public int ExecuteInsert(string query, SqlParameter[]? parameters = null)
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
                throw new Exception($"Error SQL al ejecutar INSERT: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

    }//end class
}
