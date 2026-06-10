using Semestre_Tres.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestre_Tres.Pantallas
{
    public partial class FormAddApointment : Form
    {
        public bool EsEdicion { get; set; }
        public int IdCita { get; set; }

        List<string> horasBase = new List<string>
{
    "07:00 AM", "08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM",
    "12:00 PM", "01:00 PM", "02:00 PM", "03:00 PM", "04:00 PM",
    "05:00 PM", "06:00 PM"
};

        public FormAddApointment()
        {
            InitializeComponent();

        }

        private void FormAddApointment_Load(object sender, EventArgs e)
        {
            Patient p = new Patient();
            CmbSeleccionarPaciente.DataSource = p.Listar(); // usa tu método base
            CmbSeleccionarPaciente.DisplayMember = "Name";  // nombre del paciente
            CmbSeleccionarPaciente.ValueMember = "PatientId"; // id del paciente

            if (EsEdicion)
            {
                BtnAgendar.Text = "Actualizar Cita";
                Appointment cita = new Appointment();
                DataTable datos = cita.BuscarPorNombre(IdCita.ToString()); // usa tu método base

                if (datos.Rows.Count > 0)
                {
                    CmbSeleccionarPaciente.SelectedValue = datos.Rows[0]["PatientId"];
                    maskedTextBox1.Text = datos.Rows[0]["Date"].ToString();
                    comboBox1.Text = datos.Rows[0]["Time"].ToString();
                    txtrason.Text = datos.Rows[0]["Reason"].ToString();
                }
            }
            else
            {
                BtnAgendar.Text = "Agendar Cita";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin MenuAdmin = this.ParentForm as FormMenuAdmin;
            if (MenuAdmin != null)
            {
                MenuAdmin.AbrirFormulario(new FormAppointment());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenuAdmin MenuAdmin = this.ParentForm as FormMenuAdmin;
            if (MenuAdmin != null)
            {
                MenuAdmin.AbrirFormulario(new FormAppointment());
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {

            if (CmbSeleccionarPaciente.SelectedIndex == -1 ||
    string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
    comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar paciente, fecha y hora antes de agendar la cita.");
                return;
            }

            Appointment cita = new Appointment
            {
                Date = DateTime.Parse(maskedTextBox1.Text),
                Time = comboBox1.Text,   // 👈 aquí mejor usar string, no DateTime
                Reason = txtrason.Text,
                Status = "Pendiente"
            };

            if (EsEdicion)
            {
                cita.AppointmentId = IdCita;
                if (cita.Actualizar())
                {
                    MessageBox.Show("Cita actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar cita.");
                }
            }
            else
            {
                if (cita.Agregar())
                {
                    MessageBox.Show("Cita agregada correctamente.");

                    // 🔹 Aquí limpias los campos SOLO si fue nueva cita
                    maskedTextBox1.Clear();
                    comboBox1.SelectedIndex = -1;
                    txtrason.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar cita.");
                }
            }

            // Volver al listado
            FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
            menu.AbrirFormulario(new FormAppointment());
        }

       

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (DateTime.TryParse(maskedTextBox1.Text, out DateTime fechaSeleccionada))
            {
                Appointment cita = new Appointment();
                DataTable citasDelDia = cita.BuscarPorFecha(fechaSeleccionada);

                var horasOcupadas = citasDelDia.AsEnumerable()
                                               .Select(r => r["Time"].ToString())
                                               .ToList();

                var horasDisponibles = horasBase.Except(horasOcupadas).ToList();
                comboBox1.DataSource = horasDisponibles;
            }
            else
            {
                MessageBox.Show("Ingrese una fecha válida en el formato correcto (dd/MM/yyyy).");
            }
        }
    }
}
