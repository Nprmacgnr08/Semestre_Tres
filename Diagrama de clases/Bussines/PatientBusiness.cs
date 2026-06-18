using Semestre_Tres.Clases;
using System.Data;
using System.Drawing;

namespace Semestre_Tres.Bussines
{
    internal class PatientBusiness
    {
        private Patient _patient;

        public PatientBusiness()
        {
            _patient = new Patient();
        }
        public PatientBusiness(Patient patient)
        {
            _patient = patient;
        }

        #region Métodos
        // Agregar paciente
        public int AddPatient()
        {
            if (_patient == null)
                throw new Exception("Objeto paciente inválido.");

            if (string.IsNullOrWhiteSpace(_patient.Name))
                throw new Exception("El nombre del paciente es obligatorio.");

            if (string.IsNullOrWhiteSpace(_patient.IdCard))
                throw new Exception("La cédula es obligatoria.");

            // Validar duplicado por cédula
            if (_patient.IsDuplicatePatient(_patient.IdCard))
                throw new Exception($"Ya existe un paciente con la cédula {_patient.IdCard}.");

            return _patient.InsertPatient();
        }

        // Actualizar paciente
        public int UpdatePatient()
        {
            if (_patient == null || _patient.PatientId <= 0)
                throw new Exception("Id de paciente inválido para actualizar.");

            if (string.IsNullOrWhiteSpace(_patient.Name))
                throw new Exception("El nombre del paciente es obligatorio.");

            if (string.IsNullOrWhiteSpace(_patient.IdCard))
                throw new Exception("La cédula es obligatoria.");

            // Validar duplicado por cédula (excepto el mismo paciente)
            if (_patient.IsDuplicatePatient(_patient.IdCard))
            {
                // Si ya existe, verificar si es el mismo paciente
                // Para esto necesitarías un método que verifique si la cédula pertenece a otro paciente
                // O podrías modificar IsDuplicatePatient para que reciba un PatientId opcional
                throw new Exception($"Ya existe otro paciente con la cédula {_patient.IdCard}.");
            }

            return _patient.UpdatePatient();
        }

        // Eliminar paciente
        public int DeletePatient()
        {
            if (_patient == null || _patient.PatientId <= 0)
                throw new Exception("Id de paciente inválido para eliminar.");

            return _patient.DeletePatient();
        }

        // Buscar por cédula
        public DataTable SearchByCedula(string cedula)
        {
            return _patient.BuscarPorCedula(cedula);
        }

        // Listar todos los pacientes
        public List<Patient>? ReadPatient()
        {
            try
            {
                return _patient.ListPatient();
            }
            catch (Exception ex)
            {
                throw new Exception("Intento fallido al leer pacientes.", ex);
            } //end try-catch

        }
        #endregion

    }
}
