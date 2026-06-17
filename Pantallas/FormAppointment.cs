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
        }
        private void FormAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }
        private void CargarCitas()
        {

            Appointment cita = new Appointment();
            AppointmentBusiness business = new AppointmentBusiness(cita);
            DataTable dt = business.ListAll();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Paciente"].HeaderText = "Paciente";
            dataGridView1.Columns["AppointmentId"].Visible = false;
            dataGridView1.Columns["Date"].HeaderText = "Fecha";
            dataGridView1.Columns["Time"].HeaderText = "Hora";
            dataGridView1.Columns["Reason"].HeaderText = "Motivo";
            dataGridView1.Columns["Status"].HeaderText = "Estado";
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nombre = TxtBuscar.Text.Trim();
            Appointment cita = new Appointment();
            AppointmentBusiness business = new AppointmentBusiness(cita);
            DataTable dt = business.SearchByPatientName(nombre);
            dataGridView1.DataSource = dt;
        }

        private void BtnCita_Click(object sender, EventArgs e)
        {
            FormAddApointment frm = new FormAddApointment
            {
                EsEdicion = false
            };

            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(frm);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value);

                FormAddApointment frm = new FormAddApointment
                {
                    EsEdicion = true,
                    IdCita = idCita
                };

                FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                menu?.AbrirFormulario(frm);
            }
            else
            {
                MessageBox.Show("Seleccione una cita para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value);

                DialogResult confirm = MessageBox.Show("¿Desea eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    Appointment cita = new Appointment { AppointmentId = idCita };
                    AppointmentBusiness business = new AppointmentBusiness(cita);

                    try
                    {
                        int result = business.DeleteAppointment();
                        if (result > 0)
                        {
                            MessageBox.Show("Cita eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCitas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Seleccione una cita para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
