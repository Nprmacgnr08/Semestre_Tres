using Semestre_Tres.Bussines;
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
        public bool EsEdicion { get; set; } = false;
        public int IdCita { get; set; } = 0;

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
            // 🔹 Cargar pacientes en el ComboBox
            Patient p = new Patient();
            CmbSeleccionarPaciente.DataSource = p.Listar(); // método que devuelve todos los pacientes
            CmbSeleccionarPaciente.DisplayMember = "Name";
            CmbSeleccionarPaciente.ValueMember = "PatientId";

            // 🔹 Cargar horas base
            comboBox1.DataSource = horasBase;

            if (EsEdicion)
            {
                BtnAgendar.Text = "Actualizar Cita";
                Appointment cita = new Appointment();
                DataTable datos = cita.BuscarPorNombre(IdCita.ToString()); // método que devuelve la cita por ID

                if (datos.Rows.Count > 0)
                {
                    CmbSeleccionarPaciente.SelectedValue = datos.Rows[0]["PatientId"];
                    maskedTextBox1.Text = Convert.ToDateTime(datos.Rows[0]["Date"]).ToString("dd/MM/yyyy");
                    comboBox1.Text = datos.Rows[0]["Time"].ToString();
                    txtrason.Text = datos.Rows[0]["Reason"].ToString();
                }

                // 🔹 Bloquear campos que no deben cambiar
                CmbSeleccionarPaciente.Enabled = false;
                txtrason.Enabled = false;
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
            DateTime fechaCita;
            if (!DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaCita))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida en el formato dd/MM/yyyy.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Appointment cita = new Appointment
            {
                Date = fechaCita,
                Time = comboBox1.Text,
                Reason = txtrason.Text,
                Status = "Pendiente"
            };
            cita.SetPatientById(Convert.ToInt32(CmbSeleccionarPaciente.SelectedValue));

            AppointmentBusiness business = new AppointmentBusiness(cita);

            try
            {
                if (EsEdicion)
                {
                    cita.AppointmentId = IdCita;
                    int result = business.UpdateAppointment();
                    MessageBox.Show(result > 0 ? "Cita actualizada correctamente." : "Error al actualizar cita.");
                }
                else
                {
                    int result = business.AddAppointment();
                    MessageBox.Show(result > 0 ? "Cita agregada correctamente." : "Error al agregar cita.");
                }

                // Volver al listado
                FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
                menu?.AbrirFormulario(new FormAppointment());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          
        

       

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Appointment cita = new Appointment();
            DataTable citasDelDia = cita.BuscarPorFecha(maskedTextBox1.Text);

            var horasOcupadas = citasDelDia.AsEnumerable()
                                           .Select(r => r["Time"].ToString())
                                           .ToList();

            var horasDisponibles = horasBase.Except(horasOcupadas).ToList();
            comboBox1.DataSource = horasDisponibles;
        }
    }
}
