using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Pantallas
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }
        private void FormPago_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPagos();
                ActualizarTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Configuración del DataGridView

        private void ConfigurarDataGridView()
        {
            //  Desactivar autogeneración de columnas
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Limpiar columnas existentes
            dataGridView1.Columns.Clear();

            //  Columna PaymentId (oculta)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentId",
                DataPropertyName = "PaymentId",
                HeaderText = "ID",
                Visible = false
            });

            // Columna Paciente
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Paciente",
                DataPropertyName = "Paciente",
                HeaderText = "Paciente",
                Width = 180
            });

            // Columna Tratamiento
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tratamiento",
                DataPropertyName = "Tratamiento",
                HeaderText = "Tratamiento",
                Width = 150
            });

            // Columna Amount
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                DataPropertyName = "Amount",
                HeaderText = "Monto",
                Width = 100,
                DefaultCellStyle = { Format = "N2" }
            });

            //  Columna Currency
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Currency",
                DataPropertyName = "Currency",
                HeaderText = "Moneda",
                Width = 80
            });

            //  Columna PaymentMethod
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentMethod",
                DataPropertyName = "PaymentMethod",
                HeaderText = "Método",
                Width = 130
            });

            //  Columna PaymentDate
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentDate",
                DataPropertyName = "PaymentDate",
                HeaderText = "Fecha Pago",
                Width = 120,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });
        }

        #endregion

        private void CargarPagos()
        {

            try
            {
                PaymentBusiness business = new PaymentBusiness();
                DataTable dt = business.ListAll();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nombre = txtbuscar.Text.Trim();

            try
            {
                PaymentBusiness business = new PaymentBusiness();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    // Si está vacío, mostrar todos
                    DataTable dt = business.ListAll();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    // Buscar por nombre
                    DataTable dt = business.SearchByPatientName(nombre);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {

            FormAddPago frm = new FormAddPago();
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(frm);

            frm.FormClosed += (s, args) =>
            {
                CargarPagos();
                ActualizarTotales();
                txtbuscar.Clear();
            };
        }
        private void ActualizarTotales()
        {
            try
            {
                PaymentBusiness business = new PaymentBusiness();
                DataTable dt = business.ListAll();

                if (dt == null || dt.Rows.Count == 0)
                {
                    lblCordobas.Text = "0.00 C$";
                    lbldolares.Text = "0.00 USD";
                    LblTarjeta.Text = "0";
                    LblTransacciones.Text = "0";
                    return;
                }

                decimal totalCordobas = 0, totalDolares = 0;
                int totalTarjetas = 0, totalTransacciones = dt.Rows.Count;

                foreach (DataRow row in dt.Rows)
                {
                    string moneda = row["Currency"].ToString();
                    string metodo = row["PaymentMethod"].ToString();
                    decimal monto = Convert.ToDecimal(row["Amount"]);

                    //  Normalizar nombres de moneda
                    if (moneda.Contains("Córdoba") || moneda.Contains("cordoba") || moneda.Contains("C$") || moneda == "NIO")
                        totalCordobas += monto;
                    else if (moneda.Contains("Dólar") || moneda.Contains("dolar") || moneda.Contains("USD") || moneda == "USD")
                        totalDolares += monto;

                    //  Normalizar métodos de pago
                    if (metodo.Contains("Tarjeta") || metodo.Contains("tarjeta") || metodo.Contains("Crédito") || metodo.Contains("Débito"))
                        totalTarjetas++;
                }

                lblCordobas.Text = $"{totalCordobas:N2} C$";
                lbldolares.Text = $"{totalDolares:N2} USD";
                LblTarjeta.Text = $"{totalTarjetas}";
                LblTransacciones.Text = $"{totalTransacciones}";
            }
            catch (Exception ex)
            {
                // No mostrar error para no molestar al usuario
                lblCordobas.Text = "0.00 C$";
                lbldolares.Text = "0.00 USD";
                LblTarjeta.Text = "0";
                LblTransacciones.Text = "0";
            }
        }
    }
}
