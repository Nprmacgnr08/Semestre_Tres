using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Pantallas
{
    public partial class FormAddConsultas : Form
    {
        public FormAddConsultas()
        {
            InitializeComponent();
        }
        private void FormAddConsultas_Load(object sender, EventArgs e)
        {
            // 🔹 Cargar pacientes
            DataTable dtPacientes = Consultation.ListarPacientes();
            ComPacientes.DataSource = dtPacientes;
            ComPacientes.DisplayMember = "Name";
            ComPacientes.ValueMember = "PatientId";
            ComPacientes.SelectedIndex = -1;

            // 🔹 Cargar tratamientos
            DataTable dtTratamientos = Consultation.ListarTratamientos();
            cmbtratamiento.DataSource = dtTratamientos;
            cmbtratamiento.DisplayMember = "Name";
            cmbtratamiento.ValueMember = "TreatmentId";
            cmbtratamiento.SelectedIndex = -1;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 Validaciones básicas
                if (ComPacientes.SelectedIndex == -1)
                    throw new Exception("Debe seleccionar un paciente.");

                if (cmbtratamiento.SelectedIndex == -1)
                    throw new Exception("Debe seleccionar un tratamiento.");

                if (string.IsNullOrWhiteSpace(Txtdiagnosticos.Text))
                    throw new Exception("Debe ingresar un diagnóstico.");

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    throw new Exception("Debe ingresar observaciones.");

                // 🔹 Crear entidad
                Consultation consulta = new Consultation
                {
                    ConsultationDate = DateTime.Now,
                    Diagnosis = Txtdiagnosticos.Text.Trim(),
                    Observations = textBox1.Text.Trim()
                };

                // 🔹 Asignar IDs desde ComboBoxes
                consulta.SetPatientById(Convert.ToInt32(ComPacientes.SelectedValue));
                consulta.SetTreatmentById(Convert.ToInt32(cmbtratamiento.SelectedValue));

                // 🔹 Guardar usando capa de negocio
                ConsultationBusiness business = new ConsultationBusiness(consulta);
                int filas = business.AddConsultation();

                if (filas > 0)
                {
                    MessageBox.Show("Consulta guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al listado de consultas
                    FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
                    menu?.AbrirFormulario(new FormConsultas());
                }
                else
                {
                    MessageBox.Show("No se guardó la consulta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            menu?.AbrirFormulario(new FormConsultas());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
            menu?.AbrirFormulario(new FormConsultas());
        }
    }
}
