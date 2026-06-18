using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;

namespace Semestre_Tres.Pantallas
{
    public partial class FormAddpatient : Form
    {
        public FormAddpatient()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormPaciente());
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //  Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(mtbidcard.Text) ||
                !mtbidcard.MaskCompleted)  // ✅ Verificar que la máscara esté completa
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (*).",
                                "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Validar fecha de nacimiento desde MaskedTextBox
            DateTime birthDate;
            if (!DateTime.TryParse(mtbbirthdate.Text, out birthDate))
            {
                MessageBox.Show("La fecha de nacimiento no es válida. Use el formato dd/MM/yyyy.",
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbbirthdate.Focus();
                return;
            }

            //  Validar que la fecha no sea futura
            if (birthDate > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual.",
                                "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validar edad mínima (por ejemplo, 1 año)
            int edad = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-edad)) edad--;
            if (edad < 1)
            {
                MessageBox.Show("La edad mínima debe ser de 1 año.",
                                "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto paciente
            Patient paciente = new Patient
            {
                Name = txtname.Text.Trim(),
                Lastname = txtLastname.Text.Trim(),
                Phone = txtphone.Text.Trim(),
                Gmail = txtgmail.Text.Trim(),
                Gender = comboxgander.Text.Trim(),
                BirthDate = birthDate,
                Address = txtadrees.Text.Trim(),
                IdCard = mtbidcard.Text.Trim(),
            };

            // Guardar usando la capa de negocio
            PatientBusiness business = new PatientBusiness(paciente);

            try
            {
                int result = business.AddPatient();

                if (result > 0)
                {
                    MessageBox.Show("Paciente agregado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al listado dentro del panel contenedor
                    FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                    menu?.AbrirFormulario(new FormPaciente());
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el paciente. Intente nuevamente.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar paciente: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtname.Clear();
            txtLastname.Clear();
            txtphone.Clear();
            txtgmail.Clear();
            comboxgander.SelectedIndex = -1;  
            mtbbirthdate.Clear();             
            txtadrees.Clear();               
            mtbidcard.Clear();               
            txtname.Focus();
        }
        private void mtbidcard_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormTratamiento());
        }


    }

}
