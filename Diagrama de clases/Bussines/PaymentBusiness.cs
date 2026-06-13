using Semestre_Tres.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestre_Tres.Bussines
{
    internal class PaymentBusiness
    {
        private Payment _payment;

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

            // Aquí podrías agregar validación de duplicados si tu profesor lo pide
            // Ejemplo: evitar que se registre el mismo pago dos veces en la misma fecha
            // if (_payment.IsDuplicatePayment(_payment.GetPatientId(), _payment.GetTreatmentId(), _payment.PaymentDate))
            //     throw new Exception("Ya existe un pago registrado para este paciente y tratamiento en esa fecha.");

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
            return _payment.BuscarPorPaciente(nombre);
        }

        // Listar todos los pagos
        public DataTable ListAll()
        {
            return _payment.Listar();
        }
        #endregion
    }
}
