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
    public partial class FormAddExpediente : Form
    {
        public FormAddExpediente()
        {
            InitializeComponent();
        }

        private void FormAddExpediente_Load(object sender, EventArgs e)
        {
            DataTable dtPacientes = Expedient.ListarPacientes();
            cmbPaciente.DataSource = dtPacientes;
            cmbPaciente.DisplayMember = "Name";
            cmbPaciente.ValueMember = "PatientId";
            cmbPaciente.SelectedIndex = -1;

            // 🔹 Cargar tratamientos
            DataTable dtTratamientos = Expedient.ListarTratamientos();
            cmbtratamientos.DataSource = dtTratamientos;
            cmbtratamientos.DisplayMember = "Name";
            cmbtratamientos.ValueMember = "TreatmentId";
            cmbtratamientos.SelectedIndex = -1;

            // 🔹 Tipo de sangre ya está cargado en el diseñador
            cmbsangretype.SelectedIndex = -1;
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedIndex != -1)
            {
                int pacienteId = Convert.ToInt32(cmbPaciente.SelectedValue);
                Patient paciente = new Patient().GetPatientById(pacienteId);
                mtbcedula.Text = paciente.IdCard; // Mostrar cédula en el MaskedTextBox
            }
            else
            {
                mtbcedula.Clear();
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (cmbPaciente.SelectedIndex == -1)
                    throw new Exception("Debe seleccionar un paciente.");

                if (cmbtratamientos.SelectedIndex == -1)
                    throw new Exception("Debe seleccionar un tratamiento.");

                if (string.IsNullOrWhiteSpace(mtbcedula.Text))
                    throw new Exception("Debe ingresar la cédula del paciente.");

                if (string.IsNullOrWhiteSpace(cmbsangretype.Text))
                    throw new Exception("Debe seleccionar el tipo de sangre.");

                if (string.IsNullOrWhiteSpace(TxtAlergias.Text))
                    throw new Exception("Debe ingresar las alergias.");

                if (string.IsNullOrWhiteSpace(txthistorial.Text))
                    throw new Exception("Debe ingresar el historial clínico.");

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    throw new Exception("Debe ingresar las notas médicas.");

                // Crear objeto expediente
                Expedient expediente = new Expedient
                {
                    IdentityCard = mtbcedula.Text.Trim(),
                    BloodType = cmbsangretype.Text.Trim(),
                    Allergies = TxtAlergias.Text.Trim(),
                    ClinicalHistory = txthistorial.Text.Trim(),
                    MedicalNotes = textBox1.Text.Trim(),
                    Status = "Activo",
                    OpenDate = DateTime.Now
                };

                expediente.SetPatientById(Convert.ToInt32(cmbPaciente.SelectedValue));
                expediente.SetTreatmentById(Convert.ToInt32(cmbtratamientos.SelectedValue));

                // Guardar usando capa de negocio
                ExpedientBusiness business = new ExpedientBusiness(expediente);
                int filas = business.AddExpedient();

                if (filas > 0)
                {
                    MessageBox.Show("Expediente creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al listado
                    FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
                    menu?.AbrirFormulario(new FormExpediente());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
            menu?.AbrirFormulario(new FormExpediente());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
            menu?.AbrirFormulario(new FormExpediente());
        }
    }
}
