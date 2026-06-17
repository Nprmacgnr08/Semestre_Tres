using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Pantallas
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        // Carga la lista de pacientes al abrir el formulario
        private void FormPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }

        private void CargarPacientes()
        {
            Patient paciente = new Patient();
            PatientBusiness business = new PatientBusiness(paciente);
            DataTable dt = business.ListAll();

            MessageBox.Show("Filas encontradas: " + dt.Rows.Count);

            dtgpacientess.DataSource = null;
            dtgpacientess.AutoGenerateColumns = true;
            dtgpacientess.DataSource = dt;

            if (dtgpacientess.Rows.Count > 0)
            {
                dtgpacientess.Columns["PatientId"].Visible = false;
                dtgpacientess.Columns["Name"].HeaderText = "Nombre";
                dtgpacientess.Columns["Lastname"].HeaderText = "Apellido";
                dtgpacientess.Columns["Phone"].HeaderText = "Telefono";
                dtgpacientess.Columns["Gmail"].HeaderText = "Email";
                dtgpacientess.Columns["Gender"].HeaderText = "Genero";
                dtgpacientess.Columns["BirthDate"].HeaderText = "Cumpleaños";
                dtgpacientess.Columns["Address"].HeaderText = "Direccion";
                dtgpacientess.Columns["IdCard"].HeaderText = "Cedula";

            }
        }
        //Abre el formulario para agregar un nuevo paciente y refresca la lista después de agregar
        private void btnagregar_Click(object sender, EventArgs e)
        {

            FormAddpatient frm = new FormAddpatient();
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(frm);
        }

        // Abre el formulario de detalles del paciente seleccionado
        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (dtgpacientess.SelectedRows.Count > 0)
            {
                int idPatient = Convert.ToInt32(dtgpacientess.SelectedRows[0].Cells["PatientId"].Value);
                FormDetallePatient frm = new FormDetallePatient(idPatient);
                FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                menu?.AbrirFormulario(frm);
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para ver detalles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Abre el formulario para editar el paciente seleccionado y refresca la lista después de editar
        private void btneditar_Click(object sender, EventArgs e)
        {

            if (dtgpacientess.SelectedRows.Count > 0)
            {
                int idPatient = Convert.ToInt32(dtgpacientess.SelectedRows[0].Cells["PatientId"].Value);
                FormEditPatient frm = new FormEditPatient(idPatient);
                FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                menu?.AbrirFormulario(frm);
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        // Elimina el paciente seleccionado y refresca la lista después de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgpacientess.SelectedRows.Count > 0)
            {
                int idPatient = Convert.ToInt32(dtgpacientess.SelectedRows[0].Cells["PatientId"].Value);

                DialogResult confirm = MessageBox.Show("¿Desea eliminar este paciente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    Patient paciente = new Patient { PatientId = idPatient };
                    PatientBusiness business = new PatientBusiness(paciente);

                    try
                    {
                        int result = business.DeletePatient();
                        if (result > 0)
                        {
                            MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPacientes();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente en la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string cedula = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Ingrese una cédula para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Patient paciente = new Patient();
            PatientBusiness business = new PatientBusiness(paciente);
            dtgpacientess.DataSource = business.SearchByCedula(cedula);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
