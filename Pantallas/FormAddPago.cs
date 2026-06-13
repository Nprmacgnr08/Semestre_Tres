using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestre_Tres.Pantallas
{
    public partial class FormAddPago : Form
    {
        public int IdPago { get; set; } = 0;
        private const decimal TASA_DOLAR = 36.81m;
        public FormAddPago()
        {
            InitializeComponent();
        }
        private void FormAddPago_Load(object sender, EventArgs e)
        {
            Patient p = new Patient();
            cmbpaciente.DataSource = p.Listar();
            cmbpaciente.DisplayMember = "Name";
            cmbpaciente.ValueMember = "PatientId";

            // 🔹 Cargar tratamientos
            Treatment t = new Treatment();
            cmbtratamiento.DataSource = t.Listar();
            cmbtratamiento.DisplayMember = "TreatmentName";
            cmbtratamiento.ValueMember = "TreatmentId";

            // 🔹 Cargar métodos y monedas
            cmbmetodo.Items.AddRange(new[] { "Efectivo", "Tarjeta", "Transacción" });
            cmbmoneda.Items.AddRange(new[] { "Córdobas", "Dólares" });

            cmbmoneda.SelectedIndex = 0; // Por defecto Córdobas
        }

        private void cmbtratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtratamiento.SelectedValue != null)
            {
                Treatment t = new Treatment();
                DataTable dt = t.BuscarPorId(Convert.ToInt32(cmbtratamiento.SelectedValue));

                if (dt.Rows.Count > 0)
                {
                    TxtMonto.Text = dt.Rows[0]["Cost"].ToString();
                }
            }
        }

        private void cmbmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(TxtMonto.Text, out decimal monto))
            {
                if (cmbmoneda.Text == "Dólares")
                    TxtMonto.Text = (monto / TASA_DOLAR).ToString("N2");
                else
                    TxtMonto.Text = (monto * TASA_DOLAR).ToString("N2");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Payment pago = new Payment
            {
                Amount = Convert.ToDecimal(TxtMonto.Text),
                Currency = cmbmoneda.Text,
                PaymentMethod = cmbmetodo.Text,
                PaymentDate = DateTime.Now
            };
            pago.SetPatientById(Convert.ToInt32(cmbpaciente.SelectedValue));
            pago.SetTreatmentById(Convert.ToInt32(cmbtratamiento.SelectedValue));

            PaymentBusiness business = new PaymentBusiness(pago);

            try
            {
                int result = business.AddPayment();
                MessageBox.Show(result > 0 ? "Pago registrado correctamente." : "Error al registrar pago.");

                FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                menu?.AbrirFormulario(new FormPago());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
