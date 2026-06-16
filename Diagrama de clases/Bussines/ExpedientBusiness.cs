using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Bussines
{
    internal class ExpedientBusiness
    {
        private Expedient _expedient;

        public ExpedientBusiness(Expedient expedient)
        {
            _expedient = expedient;
        }

        #region Métodos


        // Guardar expediente
        public int AddExpedient()
        {
            if (_expedient == null)
                throw new Exception("Objeto expediente inválido.");

            if (_expedient.GetPatientId() <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");

            if (_expedient.GetTreatmentId() <= 0)
                throw new Exception("Debe seleccionar un tratamiento válido.");

            if (string.IsNullOrWhiteSpace(_expedient.IdentityCard))
                throw new Exception("La cédula es obligatoria.");

            if (string.IsNullOrWhiteSpace(_expedient.BloodType))
                throw new Exception("Debe especificar el tipo de sangre.");
            // Validar duplicado por cédula usando el método de la entidad
            if (_expedient.IsDuplicateExpedient(_expedient.IdentityCard))
                throw new Exception($"Ya existe un expediente con la cédula {_expedient.IdentityCard}.");

            return _expedient.InsertExpedient();
        }

        // Actualizar expediente
        public int UpdateExpedient()
        {
            if (_expedient == null || _expedient.ExpedientId <= 0)
                throw new Exception("Id de expediente inválido para actualizar.");

            if (_expedient.GetPatientId() <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");

            return _expedient.UpdateExpedient();
        }

        // Eliminar expediente
        public int DeleteExpedient()
        {
            if (_expedient == null || _expedient.ExpedientId <= 0)
                throw new Exception("Id de expediente inválido para eliminar.");

            return _expedient.DeleteExpedient();
        }

        // Buscar por nombre de paciente
        public DataTable SearchByPatientName(string nombre)
        {
            return _expedient.BuscarPorPaciente(nombre);
        }

        // Listar todos los expedientes
        public DataTable ListAll()
        {
            return _expedient.Listar();
        }
        #endregion
    }
}
