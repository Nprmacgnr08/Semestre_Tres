using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Pantallas
{
    public partial class FormPaciente : Form
    {
        private List<Patient> _listaPacientes; // Guardar la lista para operaciones
        public FormPaciente()
        {
            InitializeComponent();
            ConfigurarDataGridView(); 


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
        private void ConfigurarDataGridView()
        {
            // Limpiar columnas existentes
            dtgpacientess.Columns.Clear();

            // Desactivar autogeneración de columnas
            dtgpacientess.AutoGenerateColumns = false;

            // Configurar el DataGridView
            dtgpacientess.AllowUserToAddRows = false;
            dtgpacientess.AllowUserToDeleteRows = false;
            dtgpacientess.ReadOnly = true;
            dtgpacientess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgpacientess.MultiSelect = false;

            // Crear columna PatientId (oculta)
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "PatientId";
            colId.DataPropertyName = "PatientId";
            colId.HeaderText = "ID";
            colId.Visible = false; // Oculta
            dtgpacientess.Columns.Add(colId);

            // Crear columna Name
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "Name";
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Nombre";
            colName.Width = 150;
            dtgpacientess.Columns.Add(colName);

            // Crear columna Lastname
            DataGridViewTextBoxColumn colLastname = new DataGridViewTextBoxColumn();
            colLastname.Name = "Lastname";
            colLastname.DataPropertyName = "Lastname";
            colLastname.HeaderText = "Apellido";
            colLastname.Width = 150;
            dtgpacientess.Columns.Add(colLastname);

            // Crear columna Phone
            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
            colPhone.Name = "Phone";
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Teléfono";
            colPhone.Width = 120;
            dtgpacientess.Columns.Add(colPhone);

            // Crear columna Gmail
            DataGridViewTextBoxColumn colGmail = new DataGridViewTextBoxColumn();
            colGmail.Name = "Gmail";
            colGmail.DataPropertyName = "Gmail";
            colGmail.HeaderText = "Email";
            colGmail.Width = 180;
            dtgpacientess.Columns.Add(colGmail);

            // Crear columna Gender
            DataGridViewTextBoxColumn colGender = new DataGridViewTextBoxColumn();
            colGender.Name = "Gender";
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Género";
            colGender.Width = 80;
            dtgpacientess.Columns.Add(colGender);

            // Crear columna BirthDate
            DataGridViewTextBoxColumn colBirthDate = new DataGridViewTextBoxColumn();
            colBirthDate.Name = "BirthDate";
            colBirthDate.DataPropertyName = "BirthDate";
            colBirthDate.HeaderText = "Fecha Nacimiento";
            colBirthDate.Width = 120;
            colBirthDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgpacientess.Columns.Add(colBirthDate);

            // Crear columna Address
            DataGridViewTextBoxColumn colAddress = new DataGridViewTextBoxColumn();
            colAddress.Name = "Address";
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Dirección";
            colAddress.Width = 200;
            dtgpacientess.Columns.Add(colAddress);

            // Crear columna IdCard
            DataGridViewTextBoxColumn colIdCard = new DataGridViewTextBoxColumn();
            colIdCard.Name = "IdCard";
            colIdCard.DataPropertyName = "IdCard";
            colIdCard.HeaderText = "Cédula";
            colIdCard.Width = 130;
            dtgpacientess.Columns.Add(colIdCard);
        }

        private void CargarPacientes()
        {
            try
            {
                PatientBusiness business = new PatientBusiness();
                _listaPacientes = business.ReadPatient();

                dtgpacientess.DataSource = null;
                dtgpacientess.DataSource = _listaPacientes;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        //Abre el formulario para agregar un nuevo paciente y refresca la lista después de agregar
        private void btnagregar_Click(object sender, EventArgs e)
        {

            FormAddpatient frm = new FormAddpatient();
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;

            // ✅ Abrir dentro del panel contenedor
            menu?.AbrirFormulario(frm);

            // ✅ Recargar la lista cuando se cierre el formulario hijo
            frm.FormClosed += (s, args) => CargarPacientes();
        }

        // Abre el formulario de detalles del paciente seleccionado
        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (dtgpacientess.SelectedRows.Count > 0)
            {
                Patient pacienteSeleccionado = (Patient)dtgpacientess.SelectedRows[0].DataBoundItem;

                if (pacienteSeleccionado != null)
                {
                    FormDetallePatient frm = new FormDetallePatient(pacienteSeleccionado.PatientId);
                    FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                    menu?.AbrirFormulario(frm);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para ver detalles.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Abre el formulario para editar el paciente seleccionado y refresca la lista después de editar
        private void btneditar_Click(object sender, EventArgs e)
        {

            if (dtgpacientess.SelectedRows.Count > 0)
            {
                // ✅ Obtener el objeto Patient directamente del DataGridView
                Patient pacienteSeleccionado = (Patient)dtgpacientess.SelectedRows[0].DataBoundItem;

                if (pacienteSeleccionado != null)
                {
                    FormEditPatient frm = new FormEditPatient(pacienteSeleccionado.PatientId);
                    FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;

                    // ✅ Abrir dentro del panel contenedor
                    menu?.AbrirFormulario(frm);

                    // ✅ Recargar la lista cuando se cierre el formulario hijo
                    frm.FormClosed += (s, args) => CargarPacientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        // Elimina el paciente seleccionado y refresca la lista después de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgpacientess.SelectedRows.Count > 0)
            {
                Patient pacienteSeleccionado = (Patient)dtgpacientess.SelectedRows[0].DataBoundItem;

                if (pacienteSeleccionado == null) return;

                DialogResult confirm = MessageBox.Show($"¿Desea eliminar a {pacienteSeleccionado.Name} {pacienteSeleccionado.Lastname}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        PatientBusiness business = new PatientBusiness(pacienteSeleccionado);
                        int result = business.DeletePatient();

                        if (result > 0)
                        {
                            MessageBox.Show("Paciente eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPacientes();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el paciente.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente en la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                string cedula = textBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(cedula))
                {
                    MessageBox.Show("Ingrese una cédula para buscar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    // Buscar por cédula usando LINQ sobre la lista
                    var resultado = _listaPacientes
                        .Where(p => p.IdCard != null && p.IdCard.Contains(cedula))
                        .ToList();

                    if (resultado.Count > 0)
                    {
                        dtgpacientess.DataSource = null;
                        dtgpacientess.DataSource = resultado;


                    }
                    else
                    {
                        MessageBox.Show("No se encontraron pacientes con esa cédula.", "Sin resultados",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPacientes(); // Restaurar la lista completa
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            CargarPacientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
