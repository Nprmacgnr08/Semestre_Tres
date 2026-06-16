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
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(mtbidcard.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios marcados con *.",
                                "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar fecha de nacimiento
            if (!DateTime.TryParse(mtbbirthdate.Text, out DateTime birthDate))
            {
                MessageBox.Show("La fecha de nacimiento no es válida.",
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto paciente
            Patient paciente = new Patient
            {
                Name = txtname.Text.Trim(),
                Lastname = txtLastname.Text.Trim(),
                Phone = txtphone.Text.Trim(),
                Gmail = txtgmail.Text.Trim(),
                Gender = comboxgander.Text,
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
