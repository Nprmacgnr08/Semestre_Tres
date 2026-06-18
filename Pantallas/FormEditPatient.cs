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
                    // Cargar datos en los controles
                    txtname.Text = datos.Name;
                    txtLastname.Text = datos.Lastname;
                    mtbidcard.Text = datos.IdCard;
                    txtphone.Text = datos.Phone;
                    txtgmail.Text = datos.Gmail;
                    comboxgander.Text = datos.Gender;
                    mtbbirthdate.Text = datos.BirthDate.ToString("dd/MM/yyyy"); // Formato corregido
                    txtadrees.Text = datos.Address;

                    // Hacer la cédula de solo lectura (no se puede modificar)
                    mtbidcard.ReadOnly = true;
                    mtbidcard.BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    MessageBox.Show("No se encontró información del paciente.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del paciente: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(mtbidcard.Text) ||
                !mtbidcard.MaskCompleted)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (*).",
                                "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Validar fecha de nacimiento
            DateTime birthDate;
            if (!DateTime.TryParse(mtbbirthdate.Text, out birthDate))
            {
                MessageBox.Show("La fecha de nacimiento no es válida. Use el formato dd/MM/yyyy.",
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbbirthdate.Focus();
                return;
            }

            // Validar que la fecha no sea futura
            if (birthDate > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual.",
                                "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbbirthdate.Focus();
                return;
            }

            // Validar edad mínima (1 año)
            int edad = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-edad)) edad--;

            if (edad < 1)
            {
                MessageBox.Show("La edad mínima debe ser de 1 año.",
                                "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbbirthdate.Focus();
                return;
            }

            // Crear objeto paciente con los datos actualizados
            Patient paciente = new Patient
            {
                PatientId = _patientId, // IMPORTANTE: Asignar el ID
                Name = txtname.Text.Trim(),
                Lastname = txtLastname.Text.Trim(),
                Phone = txtphone.Text.Trim(),
                Gmail = txtgmail.Text.Trim(),
                Gender = comboxgander.Text.Trim(),
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
                else
                {
                    MessageBox.Show("No se pudo actualizar el paciente. Intente nuevamente.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        }

        private void comboxgander_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
