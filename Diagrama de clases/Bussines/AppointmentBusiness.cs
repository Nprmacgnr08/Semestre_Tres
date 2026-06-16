using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Bussines
{
    internal class AppointmentBusiness
    {

        private Appointment _appointment;

        public AppointmentBusiness(Appointment appointment)
        {
            _appointment = appointment;
        }

        #region Methods
        public int AddAppointment()
        {
            // Validar que la cita tenga paciente asignado
            if (_appointment.PatientId == null)
            {
                throw new Exception("La cita debe estar asociada a un paciente válido.");
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
            if (_appointment.PatientId == null)
            {
                throw new Exception("La cita debe estar asociada a un paciente válido.");
            }

            return _appointment.UpdateAppointment();
        }

        public int DeleteAppointment()
        {
            return _appointment.DeleteAppointment();
        }
        public DataTable ListAll()
        {
            return _appointment.Listar();
        }

        public DataTable SearchByPatientName(string nombre)
        {
            return _appointment.BuscarPorNombre(nombre);
        }
        #endregion

    }
}
