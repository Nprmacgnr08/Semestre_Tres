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
    public partial class FormVerExpediente : Form
    {
        private int _idExpediente;
        public FormVerExpediente(int idExpediente)
        {
            InitializeComponent();
            _idExpediente = idExpediente;
        }
        private void FormVerExpediente_Load(object sender, EventArgs e)
        {
            CargarExpediente();
        }
        private void CargarExpediente()
        {
            try
            {
                // Crear objeto expediente con el ID recibido
                Expedient expediente = new Expedient { ExpedientId = _idExpediente };
                ExpedientBusiness business = new ExpedientBusiness(expediente);

                // Obtener todos los expedientes y filtrar por ID
                DataTable dt = business.ListAll();
                DataRow[] rows = dt.Select($"ExpedientId = {_idExpediente}");

                if (rows.Length == 0)
                {
                    MessageBox.Show("No se encontró el expediente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow row = rows[0];

                // 🔹 Información general del paciente
                LblExpedient.Text = "EXP" + row["ExpedientId"].ToString().PadLeft(3, '0');
                LblNombre.Text = row["Paciente"].ToString();
                LblCedula.Text = row["IdentityCard"].ToString();

                // 🔹 Datos clínicos
                LblAlergias.Text = string.IsNullOrWhiteSpace(row["Allergies"].ToString()) ? "Ninguna" : row["Allergies"].ToString();
                label9.Text = row["ClinicalHistory"].ToString();
                label10.Text = row["BloodType"].ToString();

                // 🔹 Historial clínico
                LblHistorial.Text = row["MedicalNotes"].ToString();

                // 🔹 Notas médicas
                LblNotas.Text = row["MedicalNotes"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el expediente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
