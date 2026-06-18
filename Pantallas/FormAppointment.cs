using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Pantallas
{
    public partial class FormAppointment : Form
    {

        public FormAppointment()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }
        private void FormAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarDataGridView()
        {
            //  Desactivar autogeneración de columnas
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Limpiar columnas existentes
            dataGridView1.Columns.Clear();

            // Columna AppointmentId (oculta)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AppointmentId",
                DataPropertyName = "AppointmentId",
                HeaderText = "ID",
                Visible = false
            });

            // Columna Paciente
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Paciente",
                DataPropertyName = "Paciente",
                HeaderText = "Paciente",
                Width = 180
            });

            // Columna Date
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Date",
                DataPropertyName = "Date",
                HeaderText = "Fecha",
                Width = 120,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            // Columna Time
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Time",
                DataPropertyName = "Time",
                HeaderText = "Hora",
                Width = 80
            });

            // Columna Reason
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Reason",
                DataPropertyName = "Reason",
                HeaderText = "Motivo",
                Width = 200
            });

            // Columna Status
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Estado",
                Width = 120
            });
        }
        private void CargarCitas()
        {

            try
            {
                AppointmentBusiness business = new AppointmentBusiness();
                DataTable dt = business.ListAll();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;

                // ✅ Actualizar contador si tienes un label
                // lblTotal.Text = $"Total: {dt?.Rows.Count ?? 0} citas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nombre = TxtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                CargarCitas();
                return;
            }

            try
            {
                AppointmentBusiness business = new AppointmentBusiness();
                DataTable dt = business.SearchByPatientName(nombre);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCita_Click(object sender, EventArgs e)
        {
            //  Abrir formulario para NUEVA cita
            FormAddApointment frm = new FormAddApointment();
            frm.EsEdicion = false;
            frm.IdCita = 0;

            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(frm);

            // ✅ Recargar cuando se cierre
            frm.FormClosed += (s, args) => CargarCitas();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value);

                // Abrir formulario para EDITAR cita
                FormAddApointment frm = new FormAddApointment();
                frm.EsEdicion = true;
                frm.IdCita = idCita;

                FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                menu?.AbrirFormulario(frm);

                // Recargar cuando se cierre
                frm.FormClosed += (s, args) => CargarCitas();
            }
            else
            {
                MessageBox.Show("Seleccione una cita para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value);
                string paciente = dataGridView1.SelectedRows[0].Cells["Paciente"].Value?.ToString() ?? "";

                DialogResult confirm = MessageBox.Show($"¿Desea eliminar la cita de {paciente}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Appointment cita = new Appointment { AppointmentId = idCita };
                        AppointmentBusiness business = new AppointmentBusiness(cita);

                        int result = business.DeleteAppointment();

                        if (result > 0)
                        {
                            MessageBox.Show("Cita eliminada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCitas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la cita.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cita para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
