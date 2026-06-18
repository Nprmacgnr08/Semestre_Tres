using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Bussines
{
    internal class AppointmentBusiness
    {

        private Appointment _appointment;

        public AppointmentBusiness()
        {
            _appointment = new Appointment();
        }
        public AppointmentBusiness(Appointment appointment)
        {
            _appointment = appointment;
        }
        
        #region Methods
        public int AddAppointment()
        {
            // Validar que la cita tenga paciente asignado
            if (_appointment.Patient == null || _appointment.Patient.PatientId <= 0)
            {
                throw new Exception("La cita debe estar asociada a un paciente válido.");
            }

            // Validar que tenga hora
            if (string.IsNullOrWhiteSpace(_appointment.Time))
            {
                throw new Exception("Debe seleccionar una hora para la cita.");
            }

            // Validar que tenga motivo
            if (string.IsNullOrWhiteSpace(_appointment.Reason))
            {
                throw new Exception("Debe ingresar el motivo de la cita.");
            }

            // Validar duplicados por fecha/hora
            if (_appointment.IsDuplicateAppointment(_appointment.Date, _appointment.Time))
            {
                throw new Exception($"Ya existe una cita en la fecha {_appointment.Date.ToShortDateString()} a las {_appointment.Time}.");
            }

            // Si pasa las validaciones, insertar
            return _appointment.InsertAppointment();
        }

        public int UpdateAppointment()
        {
            // Validar que la cita tenga paciente asignado
            if (_appointment.Patient == null || _appointment.Patient.PatientId <= 0)
            {
                throw new Exception("La cita debe estar asociada a un paciente válido.");
            }

            if (_appointment.AppointmentId <= 0)
            {
                throw new Exception("ID de cita inválido para actualizar.");
            }

            return _appointment.UpdateAppointment();
        }

        public int DeleteAppointment()
        {
            if (_appointment.AppointmentId <= 0)
            {
                throw new Exception("ID de cita inválido para eliminar.");
            }
            return _appointment.DeleteAppointment();
        }
        public DataTable ListAll()
        {
            try
            {
                return _appointment.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar citas: " + ex.Message);
            }
        }
        public DataTable SearchById(int idCita)
        {
            if (idCita <= 0)
            {
                throw new Exception("ID de cita inválido.");
            }
            return _appointment.BuscarPorId(idCita);
        }
        public DataTable SearchByPatientName(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return _appointment.Listar();
            }
            return _appointment.BuscarPorNombre(nombre);
        }
        public DataTable SearchByDate(string fechaTexto)
        {
            if (string.IsNullOrWhiteSpace(fechaTexto))
            {
                return _appointment.Listar();
            }
            return _appointment.BuscarPorFecha(fechaTexto);
        }
        #endregion

    }
}
