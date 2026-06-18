using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

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
            CargarPacientes();

            // Cargar tratamientos usando TreatmentBusiness
            CargarTratamientos();

            //Cargar métodos y monedas
            CargarMetodosYMonedas();
        }

        #region Métodos para cargar ComboBox

        private void CargarPacientes()
        {
            try
            {
                PatientBusiness business = new PatientBusiness();
                List<Patient> pacientes = business.ReadPatient();

                cmbpaciente.DataSource = null;
                cmbpaciente.DataSource = pacientes;
                cmbpaciente.DisplayMember = "Name";
                cmbpaciente.ValueMember = "PatientId";

                if (cmbpaciente.Items.Count > 0)
                    cmbpaciente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTratamientos()
        {
            try
            {
                //  Usar tu clase Treatment existente
                Treatment t = new Treatment();
                DataTable dt = t.ListarTratamiento();

                // Configurar DataSource con DataTable
                cmbtratamiento.DataSource = dt;
                cmbtratamiento.DisplayMember = "Name";  // Ajusta según el nombre de tu columna
                cmbtratamiento.ValueMember = "TreatmentId"; // Ajusta según tu PK

                if (cmbtratamiento.Items.Count > 0)
                    cmbtratamiento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tratamientos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMetodosYMonedas()
        {
            cmbmetodo.Items.Clear();
            cmbmetodo.Items.AddRange(new[] { "Efectivo", "Tarjeta de Crédito", "Tarjeta de Débito", "Transferencia Bancaria", "Cheque" });

            cmbmoneda.Items.Clear();
            cmbmoneda.Items.AddRange(new[] { "Córdobas (NIO)", "Dólares (USD)" });

            if (cmbmetodo.Items.Count > 0)
                cmbmetodo.SelectedIndex = -1;

            if (cmbmoneda.Items.Count > 0)
                cmbmoneda.SelectedIndex = 0;
        }
        private void cmbtratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbtratamiento.SelectedValue != null && cmbtratamiento.SelectedValue is DataRowView)
                {
                    DataRowView rowView = (DataRowView)cmbtratamiento.SelectedValue;
                    DataRow row = rowView.Row;

                    // Obtener el costo del tratamiento
                    if (row.Table.Columns.Contains("Cost"))
                    {
                        decimal costo = Convert.ToDecimal(row["Cost"]);
                        TxtMonto.Text = costo.ToString("N2");
                    }
                }
            }

            catch (Exception ex)
            {
                // No mostrar error para no molestar al usuario
            }
        }

        private void cmbmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtMonto.Text))
                return;

            if (!decimal.TryParse(TxtMonto.Text, out decimal monto))
                return;

            //  Solo convertir si el monto es mayor a 0
            if (monto <= 0)
                return;

            string monedaSeleccionada = cmbmoneda.SelectedItem?.ToString() ?? "";

            if (monedaSeleccionada.Contains("Dólar") || monedaSeleccionada.Contains("USD"))
            {
                //  Convertir de Córdobas a Dólares
                TxtMonto.Text = (monto / TASA_DOLAR).ToString("N2");
            }
            else if (monedaSeleccionada.Contains("Córdoba") || monedaSeleccionada.Contains("NIO"))
            {
                //  Convertir de Dólares a Córdobas
                TxtMonto.Text = (monto * TASA_DOLAR).ToString("N2");
            }
        }

        #region Validaciones y Guardar

        private bool ValidarCampos()
        {
            if (cmbpaciente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un paciente.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbpaciente.Focus();
                return false;
            }

            if (cmbtratamiento.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tratamiento.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbtratamiento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtMonto.Text))
            {
                MessageBox.Show("Ingrese el monto del pago.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMonto.Focus();
                return false;
            }

            if (!decimal.TryParse(TxtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido mayor a 0.", "Monto inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMonto.Focus();
                return false;
            }

            if (cmbmetodo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un método de pago.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbmetodo.Focus();
                return false;
            }

            if (cmbmoneda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una moneda.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbmoneda.Focus();
                return false;
            }

            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                // ✅Obtener IDs seleccionados
                int idPatient = Convert.ToInt32(cmbpaciente.SelectedValue);
                int idTreatment = Convert.ToInt32(cmbtratamiento.SelectedValue);
                decimal monto = decimal.Parse(TxtMonto.Text);

                //  Normalizar moneda para guardar en BD
                string monedaSeleccionada = cmbmoneda.SelectedItem.ToString();
                string moneda = monedaSeleccionada.Contains("Córdoba") ? "NIO" : "USD";

                Payment pago = new Payment
                {
                    Amount = monto,
                    Currency = moneda,
                    PaymentMethod = cmbmetodo.SelectedItem.ToString(),
                    PaymentDate = DateTime.Now
                };

                pago.SetPatientById(idPatient);
                pago.SetTreatmentById(idTreatment);

                PaymentBusiness business = new PaymentBusiness(pago);
                int resultado = business.AddPayment();

                if (resultado > 0)
                {
                    MessageBox.Show("Pago registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos para agregar otro pago
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el pago. Intente nuevamente.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cmbpaciente.SelectedIndex = -1;
            cmbtratamiento.SelectedIndex = -1;
            TxtMonto.Clear();
            cmbmetodo.SelectedIndex = -1;
            cmbmoneda.SelectedIndex = 0;
            TxtMonto.Focus();
        }

        #endregion

        private void picSalir_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormPago());
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormPago());
        }
    }
}


#endregion