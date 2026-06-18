using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Bussines
{
    public class PaymentBusiness
    {
        private Payment _payment;

        public PaymentBusiness()
        {
            _payment = new Payment();
        }

        public PaymentBusiness(Payment payment)
        {
            _payment = payment;
        }

        #region Métodos
        // Agregar pago
        public int AddPayment()
        {
            if (_payment == null)
                throw new Exception("Objeto pago inválido.");

            if (_payment.GetPatientId() <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");

            if (_payment.GetTreatmentId() <= 0)
                throw new Exception("Debe seleccionar un tratamiento válido.");

            if (_payment.Amount <= 0)
                throw new Exception("El monto debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(_payment.Currency))
                throw new Exception("Debe especificar la moneda.");

            if (string.IsNullOrWhiteSpace(_payment.PaymentMethod))
                throw new Exception("Debe especificar el método de pago.");

            
            return _payment.InsertPayment();
        }

        // Actualizar pago
        public int UpdatePayment()
        {
            if (_payment == null || _payment.PaymentId <= 0)
                throw new Exception("Id de pago inválido para actualizar.");

            if (_payment.Amount <= 0)
                throw new Exception("El monto debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(_payment.Currency))
                throw new Exception("Debe especificar la moneda.");

            if (string.IsNullOrWhiteSpace(_payment.PaymentMethod))
                throw new Exception("Debe especificar el método de pago.");

            return _payment.UpdatePayment();
        }

        // Eliminar pago
        public int DeletePayment()
        {
            if (_payment == null || _payment.PaymentId <= 0)
                throw new Exception("Id de pago inválido para eliminar.");

            return _payment.DeletePayment();
        }

        // Buscar pagos por paciente
        public DataTable SearchByPatientName(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return _payment.Listar();
            }
            return _payment.BuscarPorPaciente(nombre);
        }

        public DataTable SearchById(int idPago)
        {
            if (idPago <= 0)
                throw new Exception("ID de pago inválido.");

            return _payment.BuscarPorId(idPago);
        }

        // Listar todos los pagos
        public DataTable ListAll()
        {
            try
            {
                return _payment.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar pagos: " + ex.Message);
            }
        }
        #endregion
    }
}
