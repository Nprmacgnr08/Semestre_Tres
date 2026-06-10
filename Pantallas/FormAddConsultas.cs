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
    public partial class FormAddConsultas : Form
    {
        public FormAddConsultas()
        {
            InitializeComponent();
        }
        private void FormAddConsultas_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar datos en los controles del formulario, como ComboBoxes para pacientes y tratamientos.
            // Llenar ComboBox de pacientes
            DataTable dtPacientes = Consultation.ListarPacientes();
            ComPacientes.DataSource = dtPacientes;
            ComPacientes.DisplayMember = "Name";
            ComPacientes.ValueMember = "PatientId";
            ComPacientes.SelectedIndex = -1;

            // Llenar ComboBox de tratamientos
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
                // Crear entidad y asignar asociaciones por Id (más eficiente que cargar objetos completos)
                Consultation consulta = new Consultation();
                consulta.Diagnosis = Txtdiagnosticos.Text.Trim();
                consulta.Observations = textBox1.Text.Trim();

                // Asignar ids desde ComboBoxes
                if (ComPacientes.SelectedValue is int pacienteId)
                    consulta.SetPatientById(pacienteId);
                else
                    throw new Exception("Seleccione un paciente.");

                if (cmbtratamiento.SelectedValue is int tratamientoId)
                    consulta.SetTreatmentById(tratamientoId);
                else
                    throw new Exception("Seleccione un tratamiento.");

                // Business
                ConsultationBusiness business = new ConsultationBusiness(consulta);
                int filas = business.AddConsultation();

                if (filas > 0)
                    MessageBox.Show("Consulta guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se guardó la consulta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
