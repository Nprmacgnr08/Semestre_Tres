using Microsoft.Data.SqlClient;
using Semestre_Tres.Bussines;
using Semestre_Tres.Persistence;
using System.Data;

namespace Semestre_Tres.Clases
{
    public class Payment
    {
        private Patient? _patient;
        private Treatment? _treatment;
        private int _patientId;
        private int _treatmentId;

        #region Propiedades (campos del formulario)
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        #endregion

        #region Propiedades de navegación (asociaciones)
        public Patient Paciente
        {
            get
            {
                if (_patient == null && _patientId > 0)
                {
                    // Usar PatientBusiness en lugar de GetPatientById
                    _patient = ObtenerPacientePorId(_patientId);
                }
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
                {
                    //  Usar TreatmentBusiness en lugar de GetTreatmentById
                    _treatment = ObtenerTratamientoPorId(_treatmentId);
                }
                return _treatment!;
            }
            set
            {
                _treatment = value;
                if (value != null) _treatmentId = value.TreatmentId;
            }
        }
        #endregion

        #region Constructores
        // Constructor vacío
        public Payment()
        {
            PaymentId = 0;
            Amount = 0;
            Currency = string.Empty;
            PaymentMethod = string.Empty;
            PaymentDate = DateTime.Now;
        }

        // Constructor con parámetros básicos
        public Payment(int patientId, int treatmentId, decimal amount, string currency, string paymentMethod)
        {
            _patientId = patientId;
            _treatmentId = treatmentId;
            Amount = amount;
            Currency = currency;
            PaymentMethod = paymentMethod;
            PaymentDate = DateTime.Now;
        }

        // Constructor completo (para mapear la base de datos)
        public Payment(int paymentId, int patientId, int treatmentId, decimal amount, string currency, string paymentMethod, DateTime paymentDate)
        {
            PaymentId = paymentId;
            _patientId = patientId;
            _treatmentId = treatmentId;
            Amount = amount;
            Currency = currency;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
        }
        #endregion

        #region Métodos auxiliares para obtener objetos por ID

        /// <summary>
        /// Obtiene un paciente por su ID usando PatientBusiness
        /// </summary>
        private Patient ObtenerPacientePorId(int patientId)
        {
            try
            {
                //  Usar PatientBusiness para obtener el paciente
                PatientBusiness business = new PatientBusiness();
                List<Patient> pacientes = business.ReadPatient();
                return pacientes.FirstOrDefault(p => p.PatientId == patientId)!;
            }
            catch
            {
                return new Patient { PatientId = patientId, Name = "Paciente no encontrado" };
            }
        }

        /// <summary>
        /// Obtiene un tratamiento por su ID usando TreatmentBusiness
        /// </summary>
        private Treatment ObtenerTratamientoPorId(int treatmentId)
        {
            try
            {
                //  Usar TreatmentBusiness para obtener el tratamiento
                // Si no tienes TreatmentBusiness, puedes usar esta alternativa
                return new Treatment { TreatmentId = treatmentId, Name = "Tratamiento no encontrado" };
            }
            catch
            {
                return new Treatment { TreatmentId = treatmentId, Name = "Tratamiento no encontrado" };
            }
        }
        #endregion


        #region Métodos de persistencia
        // Insertar pago
        public int InsertPayment()
        {
            if (_patientId <= 0) throw new Exception("Debe seleccionar un paciente válido.");
            if (_treatmentId <= 0) throw new Exception("Debe seleccionar un tratamiento válido.");
            if (Amount <= 0) throw new Exception("El monto debe ser mayor que cero.");
            if (string.IsNullOrWhiteSpace(Currency)) throw new Exception("Debe seleccionar una moneda.");
            if (string.IsNullOrWhiteSpace(PaymentMethod)) throw new Exception("Debe seleccionar un método de pago.");

            using InsertCommand insert = new InsertCommand();
            string sql = @"INSERT INTO Payment (IdPatient, IdTreatment, Amount, Currency, PaymentMethod, PaymentDate)
                           VALUES (@IdPatient, @IdTreatment, @Amount, @Currency, @PaymentMethod, @PaymentDate)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPatient", SqlDbType.Int) { Value = _patientId },
                new SqlParameter("@IdTreatment", SqlDbType.Int) { Value = _treatmentId },
                new SqlParameter("@Amount", SqlDbType.Decimal) { Value = Amount },
                new SqlParameter("@Currency", SqlDbType.VarChar, 10) { Value = Currency },
                new SqlParameter("@PaymentMethod", SqlDbType.VarChar, 50) { Value = PaymentMethod },
                new SqlParameter("@PaymentDate", SqlDbType.DateTime) { Value = PaymentDate }
            };

            return insert.ExecuteInsert(sql, parameters);
        }

        // Actualizar pago
        public int UpdatePayment()
        {
            using UpdateCommand update = new UpdateCommand();
            string sql = @"UPDATE Payment
                           SET IdPatient=@IdPatient, IdTreatment=@IdTreatment, Amount=@Amount,
                               Currency=@Currency, PaymentMethod=@PaymentMethod, PaymentDate=@PaymentDate
                           WHERE PaymentId=@PaymentId";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPatient", SqlDbType.Int) { Value = _patientId },
                new SqlParameter("@IdTreatment", SqlDbType.Int) { Value = _treatmentId },
                new SqlParameter("@Amount", SqlDbType.Decimal) { Value = Amount },
                new SqlParameter("@Currency", SqlDbType.VarChar, 10) { Value = Currency },
                new SqlParameter("@PaymentMethod", SqlDbType.VarChar, 50) { Value = PaymentMethod },
                new SqlParameter("@PaymentDate", SqlDbType.DateTime) { Value = PaymentDate },
                new SqlParameter("@PaymentId", SqlDbType.Int) { Value = PaymentId }
            };

            return update.ExecuteUpdate(sql, parameters);
        }

        // Eliminar pago
        public int DeletePayment()
        {
            using DeleteCommand delete = new DeleteCommand();
            string sql = "DELETE FROM Payment WHERE PaymentId=@PaymentId";
            SqlParameter[] parameters = { new SqlParameter("@PaymentId", SqlDbType.Int) { Value = PaymentId } };

            return delete.ExecuteDelete(sql, parameters);
        }

        public DataTable BuscarPorPaciente(string nombre)
        {
            string sql = @"SELECT p.PaymentId, p.Amount, p.Currency, p.PaymentMethod, p.PaymentDate,
                                  pa.Name AS Paciente, t.Name AS Tratamiento
                           FROM Payment p
                           INNER JOIN Patient pa ON p.IdPatient = pa.PatientId
                           INNER JOIN Treatment t ON p.IdTreatment = t.TreatmentId
                           WHERE pa.Name LIKE '%' + @Nombre + '%'
                           ORDER BY p.PaymentDate DESC";

            SqlParameter[] parameters = { new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = nombre } };

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                dt.Load(reader);
            }
            return dt;
        }
        public DataTable BuscarPorId(int idPago)
        {
            string sql = @"SELECT p.PaymentId, p.IdPatient, p.IdTreatment, p.Amount, p.Currency,
                                  p.PaymentMethod, p.PaymentDate,
                                  pa.Name AS Paciente, t.Name AS Tratamiento
                           FROM Payment p
                           INNER JOIN Patient pa ON p.IdPatient = pa.PatientId
                           INNER JOIN Treatment t ON p.IdTreatment = t.TreatmentId
                           WHERE p.PaymentId = @IdPago";

            SqlParameter[] parameters = { new SqlParameter("@IdPago", SqlDbType.Int) { Value = idPago } };

            using SelectQuery select = new SelectQuery();
            DataTable dt = new DataTable();
            using (SqlDataReader reader = select.ExecuteSelect(sql, parameters))
            {
                dt.Load(reader);
            }
            return dt;
        }

        // Listar todos los pagos
        public DataTable Listar()
        {
            string sql = @"SELECT p.PaymentId, p.Amount, p.Currency, p.PaymentMethod, p.PaymentDate,
                      pa.Name AS Paciente, t.Name AS Tratamiento
               FROM Payment p
               INNER JOIN Patient pa ON p.IdPatient = pa.PatientId
               INNER JOIN Treatment t ON p.IdTreatment = t.TreatmentId
               ORDER BY p.PaymentDate DESC";

            SelectQuery select = new SelectQuery(); // sin using
            DataTable dt = new DataTable();

            using (SqlDataReader reader = select.ExecuteSelect(sql, Array.Empty<SqlParameter>()))
            {
                dt.Load(reader);
            }

            select.Close(); // cerrar manualmente después
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