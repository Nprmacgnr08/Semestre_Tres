using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Bussines
{
    internal class ConsultationBusiness
    {
        private Consultation _consultation;

        public ConsultationBusiness(Consultation consultation)
        {
            _consultation = consultation;
        }

        #region Métodos
        // Agregar consulta
        public int AddConsultation()
        {
            // Validar paciente y tratamiento
            if (_consultation.GetPatientId() <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");

            if (_consultation.GetTreatmentId() <= 0)
                throw new Exception("Debe seleccionar un tratamiento válido.");

            // Validar diagnóstico obligatorio
            if (string.IsNullOrWhiteSpace(_consultation.Diagnosis))
                throw new Exception("El diagnóstico es obligatorio.");

            return _consultation.InsertConsultation();
        }



        // Eliminar consulta
        public int DeleteConsultation()
        {
            if (_consultation.ConsultationId <= 0)
                throw new Exception("Id de consulta inválido para eliminar.");

            return _consultation.DeleteConsultation();
        }

        // Buscar por nombre de paciente
        public DataTable SearchByPatientName(string nombre)
        {
            return _consultation.BuscarPorPaciente(nombre);
        }

        // Listar todas las consultas
        public DataTable ListAll()
        {
            return _consultation.Listar();
        }
        #endregion


    }
}
