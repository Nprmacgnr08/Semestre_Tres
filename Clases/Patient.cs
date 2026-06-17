using Microsoft.Data.SqlClient;
using Semestre_Tres.Persistence;
using System.Data;

namespace Semestre_Tres.Clases
{

    public class Patient
    {
        #region Properties
        private int _patientId;
        public int PatientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Gmail { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public string Address { get; set; } = string.Empty;
        public string IdCard { get; set; } = string.Empty;
//public string BloodType { get; set; } = string.Empty;
      /// <summary>
      // public string Allergies { get; set; } = string.Empty;
      /// </summary>
        #endregion

        #region Constructors
        // Constructor vacío
        public Patient()
        {
            PatientId = 0;
            Name = string.Empty;
            Lastname = string.Empty;
            Phone = string.Empty;
            Gmail = string.Empty;
            Gender = string.Empty;
            BirthDate = DateTime.MinValue;
            Address = string.Empty;
            IdCard = string.Empty;
           // BloodType = string.Empty;
            //Allergies = string.Empty;
        }

        // Constructor con id
        public Patient(int patientId)
        {
            _patientId = patientId;
        }

        // Constructor con parámetros completos
        public Patient(int patientId, string name, string lastname, string phone, string gmail,
                       string gender, DateTime birthDate, string address, string idCard)
        {
            PatientId = patientId;
            Name = name;
            Lastname = lastname;
            Phone = phone;
            Gmail = gmail;
            Gender = gender;
            BirthDate = birthDate;
            Address = address;
            IdCard = idCard;
            //BloodType = bloodType;
            //Allergies = allergies;
        }
        #endregion
        #region Methods
        public bool IsDuplicatePatient(string cedula)
        {
            // Verificar si existe un paciente con la misma cédula
            string sql = @"SELECT CASE
                         WHEN EXISTS(
                              SELECT 1
                              FROM Patient 
                              WHERE IdCard = @IdCard)
                              THEN 1 ELSE 0 END";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parametros = {
        new SqlParameter("@IdCard", SqlDbType.VarChar, 50) { Value = cedula }
    };

            return select.IsDuplicate(sql, parametros);
        }

        // Insertar paciente
        public int InsertPatient()
        {
            using InsertCommand insert = new InsertCommand();
            string sql = @"INSERT INTO Patient (Name, Lastname, Phone, Gmail, Gender, BirthDate, Address, IdCard)
                           VALUES (@Name, @Lastname, @Phone, @Gmail, @Gender, @BirthDate, @Address, @IdCard)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", SqlDbType.VarChar, 100) { Value = Name },
                new SqlParameter("@Lastname", SqlDbType.VarChar, 100) { Value = Lastname },
                new SqlParameter("@Phone", SqlDbType.VarChar, 20) { Value = Phone },
                new SqlParameter("@Gmail", SqlDbType.VarChar, 100) { Value = Gmail },
                new SqlParameter("@Gender", SqlDbType.VarChar, 10) { Value = Gender },
                new SqlParameter("@BirthDate", SqlDbType.DateTime) { Value = BirthDate },
                new SqlParameter("@Address", SqlDbType.VarChar, 200) { Value = Address },
                new SqlParameter("@IdCard", SqlDbType.VarChar, 50) { Value = IdCard },
               
            };

            return insert.ExecuteInsert(sql, parameters);
        }

        // Actualizar paciente
        public int UpdatePatient()
        {
            using UpdateCommand update = new UpdateCommand();
            string sql = @"UPDATE Patient
                           SET Name=@Name, Lastname=@Lastname, Phone=@Phone, Gmail=@Gmail, Gender=@Gender,
                               BirthDate=@BirthDate, Address=@Address, IdCard=@IdCard 
                           WHERE PatientId=@PatientId";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", SqlDbType.VarChar, 100) { Value = Name },
                new SqlParameter("@Lastname", SqlDbType.VarChar, 100) { Value = Lastname },
                new SqlParameter("@Phone", SqlDbType.VarChar, 20) { Value = Phone },
                new SqlParameter("@Gmail", SqlDbType.VarChar, 100) { Value = Gmail },
                new SqlParameter("@Gender", SqlDbType.VarChar, 10) { Value = Gender },
                new SqlParameter("@BirthDate", SqlDbType.DateTime) { Value = BirthDate },
                new SqlParameter("@Address", SqlDbType.VarChar, 200) { Value = Address },
                new SqlParameter("@IdCard", SqlDbType.VarChar, 50) { Value = IdCard },
                new SqlParameter("@PatientId", SqlDbType.Int) { Value = PatientId }
            };

            return update.ExecuteUpdate(sql, parameters);
        }

        // Eliminar paciente
        public int DeletePatient()
        {
            using DeleteCommand delete = new DeleteCommand();
            string sql = "DELETE FROM Patient WHERE PatientId=@PatientId";
            SqlParameter[] parameters = { new SqlParameter("@PatientId", SqlDbType.Int) { Value = PatientId } };

            return delete.ExecuteDelete(sql, parameters);
        }

        public DataTable BuscarPorCedula(string cedula)
        {
            string sql = @"SELECT PatientId, Name, Lastname, Phone, Gmail, Gender, BirthDate, Address, IdCard
                           FROM Patient
                           WHERE IdCard = @Cedula";

            SqlParameter[] parameters = { new SqlParameter("@Cedula", SqlDbType.VarChar, 50) { Value = cedula } };

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                dt.Load(reader);
            }
            return dt;
        }

        // Listar todos los pacientes
        public DataTable Listar()
        {
            string sql = @"SELECT PatientId, Name, Lastname, Phone, Gmail, Gender, BirthDate, Address, IdCard
                           FROM Patient
                           ORDER BY Name ASC";

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, Array.Empty<SqlParameter>()))
            {
                dt.Load(reader);
            }
            return dt;
        }

        // Obtener paciente por id
        public Patient GetPatientById(int id)
        {
            string sql = @"SELECT PatientId, Name, Lastname, Phone, Gmail, Gender, BirthDate, Address, IdCard
                           FROM Patient
                           WHERE PatientId=@PatientId";

            SqlParameter[] parameters = { new SqlParameter("@PatientId", SqlDbType.Int) { Value = id } };

            using SelectQuery select = new SelectQuery();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                if (reader.Read())
                {
                    return new Patient(
                        Convert.ToInt32(reader["PatientId"]),
                        reader["Name"].ToString()!,
                        reader["Lastname"].ToString()!,
                        reader["Phone"].ToString()!,
                        reader["Gmail"].ToString()!,
                        reader["Gender"].ToString()!,
                        Convert.ToDateTime(reader["BirthDate"]),
                        reader["Address"].ToString()!,
                        reader["IdCard"].ToString()!
                       // reader["BloodType"].ToString()!,
                        //reader["Allergies"].ToString()!
                    );
                }
            }
            return new Patient();
        }
        #endregion
    }
}