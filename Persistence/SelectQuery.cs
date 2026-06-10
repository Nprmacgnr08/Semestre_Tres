using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semestre_Tres.Persistence
{
    public class SelectQuery : DatabaseConnection
    {
        //heredar constructores de la clase base
        public SelectQuery() : base() { }

        public SelectQuery(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta una consulta SELECT con parámetros opcionales y devuelve los resultados en un DataTable.
        /// </summary>
        /// <param name="query">Consulta SQL Parametrizada</param>
        /// <param name="parameters">Parámetros SQL (previene inyección de SQL)</param>
        /// <returns>SqlDataReader  con los resultados</returns>
        public SqlDataReader ExecuteSelect(string query, SqlParameter[] parameters = null)
        {
            DataTable result = new DataTable();

            try

            {
                OpenConnection();

                _command = new SqlCommand(query, _connection)
                {
                    CommandType = CommandType.Text,
                };

                //Validar si se encuentran parametros para agregar a la consulta
                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                return _command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                CloseConnection(); // Asegurar que la conexión se cierre en caso de error
                throw new Exception($"Error al intentar obtener resultados", ex);
            }


        }// end of ExecuteSelect

        public bool IsDuplicate(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                return Convert.ToBoolean(_command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception(
                    $"Error al ejecutar consulta escalar. {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        } // end of IsDuplicate 
    }
}