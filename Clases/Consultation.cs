using Microsoft.Data.SqlClient;
using Semestre_Tres.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Semestre_Tres.Clases
{
    public class Consultation
    {
        private Patient? _patient;
        private Treatment? _treatment;
        private int _patientId;
        private int _treatmentId;

        #region Properties
        public int ConsultationId { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
        public string Observations { get; set; } = string.Empty;

        // Propiedades de navegación (asociaciones)
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
        public Consultation()
        {
            ConsultationId = 0;
            ConsultationDate = DateTime.Now;
            Diagnosis = string.Empty;
            Observations = string.Empty;
        }

        // Constructor con id de paciente y tratamiento
        public Consultation(int patientId, int treatmentId)
        {
            _patientId = patientId;
            _treatmentId = treatmentId;
            ConsultationDate = DateTime.Now;
        }

        // Constructor con parámetros completos
        public Consultation(int consultationId, DateTime date, string diagnosis, string observations)
        {
            ConsultationId = consultationId;
            ConsultationDate = date;
            Diagnosis = diagnosis;
            Observations = observations;
        }
        #endregion

        #region Métodos de persistencia (estilo profe)
        // Agregar (INSERT) -> devuelve filas afectadas (int)
        public int InsertConsultation()
        {
            using InsertCommand insert = new InsertCommand();
            string sql = @"INSERT INTO Consultation (IdPatient, IdTreatment, FechaConsulta, Diagnosis, Observations)
                           VALUES (@IdPatient, @IdTreatment, @FechaConsulta, @Diagnosis, @Observations)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPatient", SqlDbType.Int) { Value = _patientId },
                new SqlParameter("@IdTreatment", SqlDbType.Int) { Value = _treatmentId },
                new SqlParameter("@FechaConsulta", SqlDbType.DateTime) { Value = this.ConsultationDate },
                new SqlParameter("@Diagnosis", SqlDbType.VarChar, 200) { Value = this.Diagnosis },
                new SqlParameter("@Observations", SqlDbType.VarChar, 500) { Value = this.Observations }
            };

            return insert.ExecuteInsert(sql, parameters);
        }

        // Eliminar (DELETE) -> devuelve filas afectadas (int)
        public int DeleteConsultation()
        {
            using DeleteCommand delete = new DeleteCommand();
            string sql = "DELETE FROM Consultation WHERE ConsultationId = @ConsultationId";
            SqlParameter[] parameters = {
                new SqlParameter("@ConsultationId", SqlDbType.Int) { Value = this.ConsultationId }
            };

            return delete.ExecuteDelete(sql, parameters);
        }

        // Buscar por nombre de paciente (JOIN) -> devuelve DataTable
        public DataTable BuscarPorPaciente(string nombre)
        {
            string sql = @"SELECT c.ConsultationId, c.FechaConsulta, c.Diagnosis, c.Observations,
                                  p.PatientId, p.Name AS Paciente, t.TreatmentId, t.Name AS Tratamiento
                           FROM Consultation c
                           INNER JOIN Patient p ON c.IdPatient = p.PatientId
                           INNER JOIN Treatment t ON c.IdTreatment = t.TreatmentId
                           WHERE p.Name LIKE '%' + @Nombre + '%'";

            SqlParameter[] parameters = {
                new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = nombre }
            };

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                dt.Load(reader);
            }
            return dt;
        }

        // Listar todas las consultas -> devuelve DataTable
        public DataTable Listar()
        {
            string sql = @"SELECT c.ConsultationId, c.FechaConsulta, c.Diagnosis, c.Observations,
                                  p.Name AS Paciente, t.Name AS Tratamiento
                           FROM Consultation c
                           INNER JOIN Patient p ON c.IdPatient = p.PatientId
                           INNER JOIN Treatment t ON c.IdTreatment = t.TreatmentId
                           ORDER BY c.FechaConsulta DESC";

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, Array.Empty<SqlParameter>()))
            {
                dt.Load(reader);
            }
            return dt;
        }
        #endregion

        #region Métodos auxiliares para ComboBoxes (estilo profe)
        // Devuelven DataTable listos para bindear a ComboBox (ValueMember = Id, DisplayMember = Name)
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

        // Permiten asignar por id (útil cuando el formulario pasa solo el Id del ComboBox)
        public void SetPatientById(int patientId)
        {
            _patientId = patientId;
            _patient = null; // se cargará bajo demanda si se necesita
        }

        public void SetTreatmentById(int treatmentId)
        {
            _treatmentId = treatmentId;
            _treatment = null;
        }
        #endregion

        public int GetPatientId() => _patientId;
        public int GetTreatmentId() => _treatmentId;


    }
}