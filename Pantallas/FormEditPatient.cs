using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;

namespace Semestre_Tres.Pantallas
{
    public partial class FormEditPatient : Form
    {
        private int _patientId;
        public FormEditPatient(int IdPatient)
        {
            InitializeComponent();
            _patientId = IdPatient;

        }
        private void CargarDatosPaciente()
        {
            try
            {
                Patient paciente = new Patient();
                Patient datos = paciente.GetPatientById(_patientId);

                if (datos != null && datos.PatientId > 0)
                {
                    txtname.Text = datos.Name;
                    txtLastname.Text = datos.Lastname;
                    mtbidcard.Text = datos.IdCard;
                    txtphone.Text = datos.Phone;
                    txtgmail.Text = datos.Gmail;
                    comboxgander.Text = datos.Gender;
                    mtbbirthdate.Text = datos.BirthDate.ToString("yyyy-MM-dd");
                    txtadrees.Text = datos.Address;

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
        private void btncancelar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormPaciente());
        }
        private void FormEditPatient_Load(object sender, EventArgs e)
        {

            CargarDatosPaciente();


        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
            string.IsNullOrWhiteSpace(txtLastname.Text) ||
            string.IsNullOrWhiteSpace(mtbidcard.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios marcados con *.",
                                "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(mtbbirthdate.Text, out DateTime birthDate))
            {
                MessageBox.Show("La fecha de nacimiento no es válida.",
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Patient paciente = new Patient
            {
                PatientId = _patientId,
                Name = txtname.Text.Trim(),
                Lastname = txtLastname.Text.Trim(),
                Phone = txtphone.Text.Trim(),
                Gmail = txtgmail.Text.Trim(),
                Gender = comboxgander.Text,
                BirthDate = birthDate,
                Address = txtadrees.Text.Trim(),
                IdCard = mtbidcard.Text.Trim(),

            };

            PatientBusiness business = new PatientBusiness(paciente);

            try
            {
                int result = business.UpdatePatient();

                if (result > 0)
                {
                    MessageBox.Show("Cambios guardados correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al listado dentro del panel contenedor
                    FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                    menu?.AbrirFormulario(new FormPaciente());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al actualizar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboxgander_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
