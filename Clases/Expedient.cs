using Microsoft.Data.SqlClient;
using Semestre_Tres.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Semestre_Tres.Clases
{
    public class Expedient
    {
        private Patient? _patient;
        private Treatment? _treatment;
        private int _patientId;
        private int _treatmentId;

        #region Propiedades (campos del formulario)
        public int ExpedientId { get; set; }
        public string IdentityCard { get; set; } = string.Empty;   // Cédula
        public string BloodType { get; set; } = string.Empty;     // Tipo de sangre
        public string Allergies { get; set; } = string.Empty;     // Alergias
        public string ClinicalHistory { get; set; } = string.Empty; // Historial clínico
        public string MedicalNotes { get; set; } = string.Empty;  // Notas médicas
        public DateTime OpenDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = string.Empty;
        #endregion
        #region Propiedades de navegación (asociaciones)
        public Patient Paciente
        {
            get
            {
                if (_patient == null && _patientId > 0)
                    _patient = new Patient().GetPatientById(_patientId);
                return _patient!;
            }
            set
            {
                _patient = value;
                if (value != null) _patientId = value.PatientId;
            }
        }

        public Treatment Tratamiento
        {
            get
            {
                if (_treatment == null && _treatmentId > 0)
                    _treatment = new Treatment().GetTreatmentById(_treatmentId);
                return _treatment!;
            }
            set
            {
                _treatment = value;
                if (value != null) _treatmentId = value.TreatmentId;
            }
        }
        #endregion
        #region Constructors
        // Constructor vacío
        public Expedient()
        {
            ExpedientId = 0;
            OpenDate = DateTime.Now;
            IdentityCard = string.Empty;
            BloodType = string.Empty;
            Allergies = string.Empty;
            ClinicalHistory = string.Empty;
            MedicalNotes = string.Empty;
            Status = string.Empty;
        }

        // Constructor con id de paciente y tratamiento
        public Expedient(int patientId, int treatmentId)
        {
            _patientId = patientId;
            _treatmentId = treatmentId;
            OpenDate = DateTime.Now;
        }

        // Constructor con parámetros completos
        public Expedient(int expedientId, string identityCard, string bloodType, string allergies,
                         string clinicalHistory, string medicalNotes, DateTime openDate, string status)
        {
            ExpedientId = expedientId;
            IdentityCard = identityCard;
            BloodType = bloodType;
            Allergies = allergies;
            ClinicalHistory = clinicalHistory;
            MedicalNotes = medicalNotes;
            OpenDate = openDate;
            Status = status;
        }
        #endregion
        #region Methods
        public bool IsDuplicateExpedient(string cedula)
        {
            // Verificar si existe un expediente con la misma cédula
            string sql = @"SELECT CASE
                         WHEN EXISTS(
                              SELECT 1
                              FROM Expedient 
                              WHERE IdentityCard = @Cedula)
                              THEN 1 ELSE 0 END";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parametros = {
        new SqlParameter("@Cedula", SqlDbType.VarChar, 50) { Value = cedula }
    };

            return select.IsDuplicate(sql, parametros);
        }
        // Insertar expediente

        public int InsertExpedient()
        {
            if (_patientId <= 0) throw new Exception("Debe seleccionar un paciente válido.");

            using InsertCommand insert = new InsertCommand();
            string sql = @"INSERT INTO Expedient
                           (IdPatient, IdentityCard, BloodType, Allergies, IdTreatment, ClinicalHistory, MedicalNotes, OpenDate, Status)
                           VALUES (@IdPatient, @IdentityCard, @BloodType, @Allergies, @IdTreatment, @ClinicalHistory, @MedicalNotes, @OpenDate, @Status)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPatient", SqlDbType.Int) { Value = _patientId },
                new SqlParameter("@IdentityCard", SqlDbType.VarChar, 50) { Value = this.IdentityCard },
                new SqlParameter("@BloodType", SqlDbType.VarChar, 10) { Value = this.BloodType },
                new SqlParameter("@Allergies", SqlDbType.VarChar, 250) { Value = this.Allergies },
                new SqlParameter("@IdTreatment", SqlDbType.Int) { Value = _treatmentId },
                new SqlParameter("@ClinicalHistory", SqlDbType.VarChar, 1000) { Value = this.ClinicalHistory },
                new SqlParameter("@MedicalNotes", SqlDbType.VarChar, 2000) { Value = this.MedicalNotes },
                new SqlParameter("@OpenDate", SqlDbType.DateTime) { Value = this.OpenDate },
                new SqlParameter("@Status", SqlDbType.VarChar, 50) { Value = this.Status }
            };

            return insert.ExecuteInsert(sql, parameters);
        }

        // Actualizar expediente
        public int UpdateExpedient()
        {
            using UpdateCommand update = new UpdateCommand();
            string sql = @"UPDATE Expedient
                           SET IdPatient=@IdPatient, IdentityCard=@IdentityCard, BloodType=@BloodType,
                               Allergies=@Allergies, IdTreatment=@IdTreatment, ClinicalHistory=@ClinicalHistory,
                               MedicalNotes=@MedicalNotes, OpenDate=@OpenDate, Status=@Status
                           WHERE ExpedientId=@ExpedientId";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPatient", SqlDbType.Int) { Value = _patientId },
                new SqlParameter("@IdentityCard", SqlDbType.VarChar, 50) { Value = this.IdentityCard },
                new SqlParameter("@BloodType", SqlDbType.VarChar, 10) { Value = this.BloodType },
                new SqlParameter("@Allergies", SqlDbType.VarChar, 250) { Value = this.Allergies },
                new SqlParameter("@IdTreatment", SqlDbType.Int) { Value = _treatmentId },
                new SqlParameter("@ClinicalHistory", SqlDbType.VarChar, 1000) { Value = this.ClinicalHistory },
                new SqlParameter("@MedicalNotes", SqlDbType.VarChar, 2000) { Value = this.MedicalNotes },
                new SqlParameter("@OpenDate", SqlDbType.DateTime) { Value = this.OpenDate },
                new SqlParameter("@Status", SqlDbType.VarChar, 50) { Value = this.Status },
                new SqlParameter("@ExpedientId", SqlDbType.Int) { Value = this.ExpedientId }
            };

            return update.ExecuteUpdate(sql, parameters);
        }

        // Eliminar expediente
        public int DeleteExpedient()
        {
            using DeleteCommand delete = new DeleteCommand();
            string sql = "DELETE FROM Expedient WHERE ExpedientId=@ExpedientId";
            SqlParameter[] parameters = { new SqlParameter("@ExpedientId", SqlDbType.Int) { Value = this.ExpedientId } };

            return delete.ExecuteDelete(sql, parameters);
        }

        // Buscar por nombre de paciente
        public DataTable BuscarPorPaciente(string nombre)
        {
            string sql = @"SELECT e.ExpedientId, e.IdentityCard, e.BloodType, e.Allergies,
                                  e.ClinicalHistory, e.MedicalNotes, e.OpenDate, e.Status,
                                  p.Name AS Paciente, t.Name AS Tratamiento
                           FROM Expedient e
                           INNER JOIN Patient p ON e.IdPatient = p.PatientId
                           LEFT JOIN Treatment t ON e.IdTreatment = t.TreatmentId
                           WHERE p.Name LIKE '%' + @Nombre + '%'";

            SqlParameter[] parameters = { new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = nombre } };

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                dt.Load(reader);
            }
            return dt;
        }
        public static DataTable ListarPacientes()
        {
            string sql = "SELECT PatientId, Name FROM Patient ORDER BY Name";
            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, Array.Empty<SqlParameter>()))
            {
                dt.Load(reader);
            }
            return dt;
        }

        public static DataTable ListarTratamientos()
        {
            string sql = "SELECT TreatmentId, Name FROM Treatment ORDER BY Name";
            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, Array.Empty<SqlParameter>()))
            {
                dt.Load(reader);
            }
            return dt;
        }

        // Listar todos los expedientes
        public DataTable Listar()
        {
            string sql = @"SELECT e.ExpedientId, e.IdentityCard, e.BloodType, e.Allergies,
                                  e.ClinicalHistory, e.MedicalNotes, e.OpenDate, e.Status,
                                  p.Name AS Paciente, t.Name AS Tratamiento
                           FROM Expedient e
                           INNER JOIN Patient p ON e.IdPatient = p.PatientId
                           LEFT JOIN Treatment t ON e.IdTreatment = t.TreatmentId
                           ORDER BY e.OpenDate DESC";

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, Array.Empty<SqlParameter>()))
            {
                dt.Load(reader);
            }
            return dt;
        }
        #endregion

        #region Auxiliares
        public void SetPatientById(int patientId) { _patientId = patientId; _patient = null; }
        public void SetTreatmentById(int treatmentId) { _treatmentId = treatmentId; _treatment = null; }
        public int GetPatientId() => _patientId;
        public int GetTreatmentId() => _treatmentId;
        #endregion
    }

}