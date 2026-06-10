using Microsoft.Data.SqlClient;
using Semestre_Tres.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Semestre_Tres.Clases
{
    public class Treatment
    {
        #region Propiedades
        public int TreatmentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        #endregion

        #region Constructores
        // Constructor vacío
        public Treatment()
        {
            TreatmentId = 0;
            Name = string.Empty;
            Description = string.Empty;
            Duration = string.Empty;
            Cost = 0;
        }

        // Constructor con parámetros básicos
        public Treatment(string name, string description, string duration, decimal cost)
        {
            Name = name;
            Description = description;
            Duration = duration;
            Cost = cost;
        }

        // Constructor completo (para mapear la base de datos)
        public Treatment(int treatmentId, string name, string description, string duration, decimal cost)
        {
            TreatmentId = treatmentId;
            Name = name;
            Description = description;
            Duration = duration;
            Cost = cost;
        }
        #endregion

        #region Métodos de persistencia
        // Insertar tratamiento
        public int InsertTreatment()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("El nombre del tratamiento es obligatorio.");

            if (string.IsNullOrWhiteSpace(Description))
                throw new Exception("La descripción es obligatoria.");

            if (string.IsNullOrWhiteSpace(Duration))
                throw new Exception("La duración es obligatoria.");

            if (Cost <= 0)
                throw new Exception("El costo debe ser mayor que cero.");

            // Validar duplicado
            if (IsDuplicateTreatment(Name))
                throw new Exception($"Ya existe un tratamiento con el nombre '{Name}'.");

            using InsertCommand insert = new InsertCommand();
            string sql = @"INSERT INTO Treatment (Name, Description, Duration, Cost)
                           VALUES (@Name, @Description, @Duration, @Cost)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", SqlDbType.VarChar, 100) { Value = Name },
                new SqlParameter("@Description", SqlDbType.VarChar, 250) { Value = Description },
                new SqlParameter("@Duration", SqlDbType.VarChar, 50) { Value = Duration },
                new SqlParameter("@Cost", SqlDbType.Decimal) { Value = Cost }
            };

            return insert.ExecuteInsert(sql, parameters);
        }

        // Actualizar tratamiento
        public int UpdateTreatment()
        {
            if (TreatmentId <= 0)
                throw new Exception("Id de tratamiento inválido para actualizar.");

            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("El nombre del tratamiento es obligatorio.");

            if (string.IsNullOrWhiteSpace(Description))
                throw new Exception("La descripción es obligatoria.");

            if (string.IsNullOrWhiteSpace(Duration))
                throw new Exception("La duración es obligatoria.");

            if (Cost <= 0)
                throw new Exception("El costo debe ser mayor que cero.");

            using UpdateCommand update = new UpdateCommand();
            string sql = @"UPDATE Treatment
                           SET Name=@Name, Description=@Description, Duration=@Duration, Cost=@Cost
                           WHERE TreatmentId=@TreatmentId";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", SqlDbType.VarChar, 100) { Value = Name },
                new SqlParameter("@Description", SqlDbType.VarChar, 250) { Value = Description },
                new SqlParameter("@Duration", SqlDbType.VarChar, 50) { Value = Duration },
                new SqlParameter("@Cost", SqlDbType.Decimal) { Value = Cost },
                new SqlParameter("@TreatmentId", SqlDbType.Int) { Value = TreatmentId }
            };

            return update.ExecuteUpdate(sql, parameters);
        }

        // Eliminar tratamiento
        public int DeleteTreatment()
        {
            if (TreatmentId <= 0)
                throw new Exception("Id de tratamiento inválido para eliminar.");

            using DeleteCommand delete = new DeleteCommand();
            string sql = "DELETE FROM Treatment WHERE TreatmentId=@TreatmentId";
            SqlParameter[] parameters = { new SqlParameter("@TreatmentId", SqlDbType.Int) { Value = TreatmentId } };

            return delete.ExecuteDelete(sql, parameters);
        }

        // Buscar por nombre
        public DataTable BuscarPorNombre(string nombre)
        {
            string sql = @"SELECT TreatmentId, Name, Description, Duration, Cost
                           FROM Treatment
                           WHERE Name LIKE '%' + @Nombre + '%'";

            SqlParameter[] parameters = { new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = nombre } };

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                dt.Load(reader);
            }
            return dt;
        }

        // Listar todos los tratamientos
        public DataTable Listar()
        {
            string sql = @"SELECT TreatmentId, Name, Description, Duration, Cost
                           FROM Treatment
                           ORDER BY Name ASC";

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, Array.Empty<SqlParameter>()))
            {
                dt.Load(reader);
            }
            return dt;
        }

        // Obtener tratamiento por id
        public Treatment GetTreatmentById(int id)
        {
            string sql = @"SELECT TreatmentId, Name, Description, Duration, Cost
                           FROM Treatment
                           WHERE TreatmentId=@TreatmentId";

            SqlParameter[] parameters = { new SqlParameter("@TreatmentId", SqlDbType.Int) { Value = id } };

            using SelectQuery select = new SelectQuery();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                if (reader.Read())
                {
                    return new Treatment(
                        Convert.ToInt32(reader["TreatmentId"]),
                        reader["Name"].ToString()!,
                        reader["Description"].ToString()!,
                        reader["Duration"].ToString()!,
                        Convert.ToDecimal(reader["Cost"])
                    );
                }
            }
            return new Treatment();
        }
        #endregion

        #region Validación de duplicados
        public bool IsDuplicateTreatment(string nombre)
        {
            string sql = @"SELECT CASE
                                 WHEN EXISTS(
                                      SELECT 1
                                      FROM Treatment
                                      WHERE Name = @Nombre)
                                      THEN 1 ELSE 0 END";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parametros = {
                new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = nombre }
            };

            return select.IsDuplicate(sql, parametros);
        }
        #endregion


    }
}