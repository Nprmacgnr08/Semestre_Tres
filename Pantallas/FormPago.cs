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
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }
        private void FormPago_Load(object sender, EventArgs e)
        {
            CargarPagos();
            ActualizarTotales();
        }
        private void CargarPagos()
        {
            Payment pago = new Payment();
            PaymentBusiness business = new PaymentBusiness(pago);
            DataTable dt = business.ListAll();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["PaymentId"].Visible = false;
            dataGridView1.Columns["Paciente"].HeaderText = "Paciente";
            dataGridView1.Columns["Tratamiento"].HeaderText = "Tratamiento";
            dataGridView1.Columns["Amount"].HeaderText = "Monto";
            dataGridView1.Columns["Currency"].HeaderText = "Moneda";
            dataGridView1.Columns["PaymentMethod"].HeaderText = "Método";
            dataGridView1.Columns["PaymentDate"].HeaderText = "Fecha";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nombre = txtbuscar.Text.Trim();
            Payment pago = new Payment();
            PaymentBusiness business = new PaymentBusiness(pago);
            DataTable dt = business.SearchByPatientName(nombre);
            dataGridView1.DataSource = dt;
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {

            FormPago frm = new FormPago();
             FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(frm);
        }
        private void ActualizarTotales()
        {
            Payment pago = new Payment();
            PaymentBusiness business = new PaymentBusiness(pago);
            DataTable dt = business.ListAll();

            decimal totalCordobas = 0, totalDolares = 0;
            int totalTarjetas = 0, totalTransacciones = dt.Rows.Count;

            foreach (DataRow row in dt.Rows)
            {
                string moneda = row["Currency"].ToString();
                string metodo = row["PaymentMethod"].ToString();
                decimal monto = Convert.ToDecimal(row["Amount"]);

                if (moneda == "Córdobas") totalCordobas += monto;
                if (moneda == "Dólares") totalDolares += monto;
                if (metodo == "Tarjeta") totalTarjetas++;
            }

            lblCordobas.Text = $"{totalCordobas:N2} C$";
            lbldolares.Text = $"{totalDolares:N2} USD";
            LblTarjeta.Text = $"{totalTarjetas}";
            LblTransacciones.Text = $"{totalTransacciones}";
        }
    }
}
