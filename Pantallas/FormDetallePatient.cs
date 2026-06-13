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
    public partial class FormDetallePatient : Form
    {
        private int _patientId;
        public FormDetallePatient(int IdPatient)
        {
            InitializeComponent();
           _patientId = IdPatient;
        }

        private void FormDetallePatient_Load(object sender, EventArgs e)
        {

            CargarDetallesPaciente();
        }

        private void CargarDetallesPaciente()
        {
            try
            {
                Patient paciente = new Patient();
                PatientBusiness business = new PatientBusiness(paciente);

                // Obtener el paciente por ID
                Patient datos = paciente.GetPatientById(_patientId);

                if (datos != null && datos.PatientId > 0)
                {
                    LblName.Text = datos.Name;
                    LblLastname.Text = datos.Lastname;
                    LblIdcard.Text = datos.IdCard;
                    LblPhone.Text = datos.Phone;
                    LblBirthDate.Text = datos.BirthDate.ToString("dd/MM/yyyy");
                    LblGmail.Text = datos.Gmail;
                    LblAdrees.Text = datos.Address;
                    LblGender.Text = datos.Gender;
                }
                else
                {
                    MessageBox.Show("No se encontró información del paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormPaciente());
        }
    }
}
