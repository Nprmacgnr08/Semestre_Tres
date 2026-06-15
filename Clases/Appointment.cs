using Microsoft.Data.SqlClient;
using Semestre_Tres.Persistence;
using System.Data;


namespace Semestre_Tres.Clases
{
    internal class Appointment
    {
        // Encapsular atributo de navegación para la propiedad Patient
        private Patient? _patient;
        private int _patientId; // Guardamos el ID oculto, con el que se maneja en la base de datos

        #region Properties
        /* -- ---------------------------------------------------------------- -- */
        /*      Definición de propiedades para la clase Appointment.             */
        /* -- ---------------------------------------------------------------- -- */
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;


        // Establecer la propiedad de navegación para el paciente asociado a esta cita.
        public Patient PatientId
        {
            get
            {
                // Cuando se pide la propiedad y no se ha cargado de la base de datos, se carga automáticamente
                if (_patient == null && _patientId > 0)
                {
                    _patient = new Patient();
                    // Aquí deberías implementar en Patient un método GetPatientById que devuelva el objeto desde la BD
                    _patient = _patient.GetPatientById(_patientId);
                }
                return _patient!;

            }//end-get

            set
            {
                _patient = value;
                if (value != null)
                {
                    _patientId = value.PatientId;
                }
            }
        }//end-Patient
        #endregion

        #region Constructors
        /* -- ---------------------------------------------------------------- -- */
        /*      Constructores de la clase Appointment.                           */
        /* -- ---------------------------------------------------------------- -- */

        public Appointment()
        {
            AppointmentId = 0;
            Date = DateTime.MinValue;
            Time = string.Empty;
            Reason = string.Empty;
            Status = string.Empty;
        }

        // Constructor para mapear con la base de datos
        public Appointment(int patientId)
        {
            _patientId = patientId;
        }

        // Constructor con parámetros
        public Appointment(int appointmentId, DateTime date, string time, string reason, string status)
        {
            AppointmentId = appointmentId;
            Date = date;
            Time = time;
            Reason = reason;
            Status = status;
        }
        #endregion

        #region Methods
        /* -- ---------------------------------------------------------------- -- */
        /*              Métodos de operación en la base de datos.                 */
        /* -- ---------------------------------------------------------------- -- */

        public bool IsDuplicateAppointment(DateTime date, string time)
        {
            // Verificar si existe una cita en la misma fecha y hora
            string sql = @"SELECT CASE
                                 WHEN EXISTS(
                                      SELECT 1
                                      FROM Appointment 
                                      WHERE Date = @Date AND Time = @Time)
                                      THEN 1 ELSE 0 END";
            using SelectQuery select = new SelectQuery();
            SqlParameter[] parametros = {
                new SqlParameter("@Date", SqlDbType.DateTime) { Value = date },
                new SqlParameter("@Time", SqlDbType.VarChar, 10) { Value = time }
            };
            return select.IsDuplicate(sql, parametros);
        }

        public int InsertAppointment()
        {
            int rows = 0;
            try
            {
                using InsertCommand insert = new InsertCommand();

                string sql = @"INSERT INTO Appointment (IdPatient, Date, Time, Reason, Status)
                               VALUES (@IdPatient, @Date, @Time, @Reason, @Status)";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@IdPatient", SqlDbType.Int) { Value = this.PatientId.PatientId },
                    new SqlParameter("@Date", SqlDbType.DateTime) { Value = this.Date },
                    new SqlParameter("@Time", SqlDbType.VarChar, 10) { Value = this.Time },
                    new SqlParameter("@Reason", SqlDbType.VarChar, 100) { Value = this.Reason },
                    new SqlParameter("@Status", SqlDbType.VarChar, 20) { Value = this.Status }
                };

                rows = insert.ExecuteInsert(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la cita.", ex);
            }

            return rows;
        }
        public int UpdateAppointment()
        {
            using UpdateCommand update = new UpdateCommand();
            string sql = @"UPDATE Appointment 
                           SET IdPatient=@IdPatient, Date=@Date, Time=@Time, Reason=@Reason, Status=@Status 
                           WHERE AppointmentId=@AppointmentId";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPatient", SqlDbType.Int) { Value = this.PatientId.PatientId },
                new SqlParameter("@Date", SqlDbType.DateTime) { Value = this.Date },
                new SqlParameter("@Time", SqlDbType.VarChar, 10) { Value = this.Time },
                new SqlParameter("@Reason", SqlDbType.VarChar, 100) { Value = this.Reason },
                new SqlParameter("@Status", SqlDbType.VarChar, 20) { Value = this.Status },
                new SqlParameter("@AppointmentId", SqlDbType.Int) { Value = this.AppointmentId }
            };

            return update.ExecuteUpdate(sql, parameters);
        }
        public int DeleteAppointment()
        {
            using DeleteCommand delete = new DeleteCommand();
            string sql = "DELETE FROM Appointment WHERE AppointmentId=@AppointmentId";
            SqlParameter[] parameters = { new SqlParameter("@AppointmentId", AppointmentId) };

            return delete.ExecuteDelete(sql, parameters);
        }
        public DataTable BuscarPorNombre(string nombre)
        {
            string sql = @"SELECT a.AppointmentId, a.Date, a.Time, a.Reason, a.Status, 
                                  p.Name AS Paciente
                           FROM Appointment a
                           INNER JOIN Patient p ON a.IdPatient = p.PatientId
                           WHERE p.Name LIKE '%' + @Nombre + '%'";

            SqlParameter[] parameters = { new SqlParameter("@Nombre", nombre) };

            using SelectQuery select = new SelectQuery();
            DataTable result = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                result.Load(reader);
            }
            return result;
        }
        public DataTable BuscarPorId(int idCita)
        {
            string sql = @"SELECT a.AppointmentId, a.Date, a.Time, a.Reason, a.Status, a.IdPatient, p.Name AS Paciente
                   FROM Appointment a
                   INNER JOIN Patient p ON a.IdPatient = p.PatientId
                   WHERE a.AppointmentId = @IdCita";

            SqlParameter[] parameters = { new SqlParameter("@IdCita", idCita) };

            using SelectQuery select = new SelectQuery();
            DataTable result = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                result.Load(reader);
            }
            return result;
        }
        public DataTable BuscarPorFecha(string fechaTexto)
        {
            if (!DateTime.TryParse(fechaTexto, out DateTime fecha))
            {
                throw new Exception("La fecha ingresada no es válida.");
            }

            string sql = @"SELECT AppointmentId, Date, Time, Reason, Status, IdPatient
                   FROM Appointment
                   WHERE CAST(Date AS DATE) = CAST(@Fecha AS DATE)";

            SqlParameter[] parameters = { new SqlParameter("@Fecha", SqlDbType.DateTime) { Value = fecha } };

            using SelectQuery select = new SelectQuery();
            DataTable result = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                result.Load(reader);
            }
            return result;
        }

        // Listar todas las citas
        public DataTable Listar()
        {
            string sql = @"SELECT a.AppointmentId, a.Date, a.Time, a.Reason, a.Status, p.Name AS Paciente
                           FROM Appointment a
                           INNER JOIN Patient p ON a.IdPatient = p.PatientId
                           ORDER BY a.Date DESC";

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
        // Asignar paciente por id (útil para ComboBox)
        public void SetPatientById(int patientId)
        {
            _patientId = patientId;
            _patient = null;
        }

        // Obtener el id oculto (si lo necesitas)
        public int GetPatientId() => _patientId;
        #endregion
    }//end class




}
