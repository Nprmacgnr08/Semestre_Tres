using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;

namespace Semestre_Tres.Pantallas
{
    public partial class FormAddTratamiento : Form
    {
        public FormAddTratamiento()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtprocedimineto.Text) ||
                string.IsNullOrWhiteSpace(TxtDescripcionpro.Text) ||
                string.IsNullOrWhiteSpace(txtduracion.Text) ||
                string.IsNullOrWhiteSpace(txtcosto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar costo numérico
            if (!decimal.TryParse(txtcosto.Text, out decimal costo))
            {
                MessageBox.Show("El costo debe ser un número válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto Treatment con los datos del formulario
            Treatment tratamiento = new Treatment
            {
                Name = txtprocedimineto.Text.Trim(),
                Description = TxtDescripcionpro.Text.Trim(),
                Duration = txtduracion.Text.Trim(),
                Cost = costo
            };

            // Usar la capa de negocio para agregar el tratamiento
            TreatmentBusiness business = new TreatmentBusiness(tratamiento);

            try
            {
                int result = business.AddTreatment();

                if (result > 0)
                {
                    MessageBox.Show("Tratamiento agregado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al FormTratamiento
                    FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                    menu?.AbrirFormulario(new FormTratamiento());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar tratamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Volver al listado sin guardar
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormTratamiento());
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            // Volver al listado sin guardar
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(new FormTratamiento());
        }
    }
}
