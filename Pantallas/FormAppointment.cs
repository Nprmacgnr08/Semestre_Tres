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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Semestre_Tres.Pantallas
{
    public partial class FormAppointment : Form
    {

        public FormAppointment()
        {
            InitializeComponent();
        }

        private void BtnCita_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
            FormAddApointment frm = new FormAddApointment();
            frm.EsEdicion = false;
            menu.AbrirFormulario(frm);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value);
                FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
                FormAddApointment frm = new FormAddApointment();
                frm.EsEdicion = true;
                frm.IdCita = idCita;
                menu.AbrirFormulario(frm);
            }
            else
            {
                MessageBox.Show("Seleccione una cita para actualizar.");
            }
        }

        private void FormAppointment_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, mostrar todas las citas
            Appointment cita = new Appointment();
            dataGridView1.DataSource = cita.Listar(); // usa tu método base
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value);
                Appointment cita = new Appointment();
                cita.AppointmentId = idCita;

                if (cita.EliminarCita())
                {
                    MessageBox.Show("Cita eliminada correctamente.");
                    dataGridView1.DataSource = cita.Listar(); // refresca el listado
                }
                else
                {
                    MessageBox.Show("Error al eliminar cita.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cita para eliminar.");
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string nombre = TxtBuscar.Text.Trim();

            // Evitar que se ejecute cuando solo está el placeholder
            if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ingrese nombre del paciente")
            {
                Appointment cita = new Appointment();
                dataGridView1.DataSource = cita.Listar(); // mostrar todas
            }
            else
            {
                Appointment cita = new Appointment();
                dataGridView1.DataSource = cita.BuscarPorNombre(nombre);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string nombre = TxtBuscar.Text.Trim(); // TextBox donde escribes el nombre
            Appointment cita = new Appointment();

            if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ingrese nombre del paciente")
            {
                // Si está vacío o solo tiene el placeholder, mostrar todas las citas
                dataGridView1.DataSource = cita.Listar();
            }
            else
            {
                // Buscar por nombre del paciente
                dataGridView1.DataSource = cita.BuscarPorNombre(nombre);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
