using Semestre_Tres.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestre_Tres.Bussines
{
    internal class TreatmentBusiness
    {
        private Treatment _treatment;

        public TreatmentBusiness(Treatment treatment)
        {
            _treatment = treatment;
        }

        #region Métodos
        // Agregar tratamiento
        public int AddTreatment()
        {
            if (_treatment == null)
                throw new Exception("Objeto tratamiento inválido.");

            if (string.IsNullOrWhiteSpace(_treatment.Name))
                throw new Exception("El nombre del tratamiento es obligatorio.");

            if (string.IsNullOrWhiteSpace(_treatment.Description))
                throw new Exception("La descripción del tratamiento es obligatoria.");

            if (string.IsNullOrWhiteSpace(_treatment.Duration))
                throw new Exception("La duración del tratamiento es obligatoria.");

            if (_treatment.Cost <= 0)
                throw new Exception("El costo debe ser mayor que cero.");

            // Validar duplicado por nombre
            if (_treatment.IsDuplicateTreatment(_treatment.Name))
                throw new Exception($"Ya existe un tratamiento con el nombre '{_treatment.Name}'.");

            return _treatment.InsertTreatment();
        }

        // Actualizar tratamiento
        public int UpdateTreatment()
        {
            if (_treatment == null || _treatment.TreatmentId <= 0)
                throw new Exception("Id de tratamiento inválido para actualizar.");

            if (string.IsNullOrWhiteSpace(_treatment.Name))
                throw new Exception("El nombre del tratamiento es obligatorio.");

            if (string.IsNullOrWhiteSpace(_treatment.Description))
                throw new Exception("La descripción del tratamiento es obligatoria.");

            if (string.IsNullOrWhiteSpace(_treatment.Duration))
                throw new Exception("La duración del tratamiento es obligatoria.");

            if (_treatment.Cost <= 0)
                throw new Exception("El costo debe ser mayor que cero.");

            return _treatment.UpdateTreatment();
        }

        // Eliminar tratamiento
        public int DeleteTreatment()
        {
            if (_treatment == null || _treatment.TreatmentId <= 0)
                throw new Exception("Id de tratamiento inválido para eliminar.");

            return _treatment.DeleteTreatment();
        }

        // Buscar tratamientos por nombre
        public DataTable SearchByName(string nombre)
        {
            return _treatment.BuscarPorNombre(nombre);
        }

        // Listar todos los tratamientos
        public DataTable ListAll()
        {
            return _treatment.Listar();
        }
        #endregion
    }
}
