using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

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
            //Cargar pacientes en el ComboBox
            CargarPacientes();

            // Cargar horas base
            CargarHoras();

            // Configurar según sea edición o nuevo
            if (EsEdicion && IdCita > 0)
            {

                BtnAgendar.Text = "Actualizar Cita";
                CargarDatosCita();

                // Bloquear campos que no deben cambiar en edición
                CmbSeleccionarPaciente.Enabled = false;
                txtrason.Enabled = false;
                maskedTextBox1.Enabled = false;
            }
            else
            {
                BtnAgendar.Text = "Agendar Cita";
                maskedTextBox1.Text = DateTime.Today.ToString("dd/MM/yyyy");
            }
        }
        #region Métodos para cargar ComboBox

        private void CargarPacientes()
        {
            try
            {
                PatientBusiness business = new PatientBusiness();
                List<Patient> pacientes = business.ReadPatient();

                CmbSeleccionarPaciente.DataSource = null;
                CmbSeleccionarPaciente.DataSource = pacientes;
                CmbSeleccionarPaciente.DisplayMember = "Name";
                CmbSeleccionarPaciente.ValueMember = "PatientId";

                if (CmbSeleccionarPaciente.Items.Count > 0)
                    CmbSeleccionarPaciente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHoras()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = horasBase;

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = -1;
        }

        #endregion
        #region Cargar datos para edición

        private void CargarDatosCita()
        {
            try
            {
                AppointmentBusiness business = new AppointmentBusiness();
                DataTable dt = business.SearchById(IdCita);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    //  Seleccionar paciente
                    int idPatient = Convert.ToInt32(row["IdPatient"]);
                    CmbSeleccionarPaciente.SelectedValue = idPatient;

                    //  Fecha
                    DateTime fecha = Convert.ToDateTime(row["Date"]);
                    maskedTextBox1.Text = fecha.ToString("dd/MM/yyyy");

                    // Hora
                    string hora = row["Time"].ToString();
                    comboBox1.SelectedItem = hora;

                    //  Motivo
                    txtrason.Text = row["Reason"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró la cita seleccionada.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de la cita: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Validaciones y Guardar

        private bool ValidarCampos()
        {
            // Validar paciente seleccionado
            if (CmbSeleccionarPaciente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un paciente.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbSeleccionarPaciente.Focus();
                return false;
            }

            // Validar fecha
            DateTime fechaCita;
            if (!DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaCita))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida en el formato dd/MM/yyyy.",
                    "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();
                return false;
            }

            // Validar que la fecha no sea pasada (solo para nuevas citas)
            if (!EsEdicion && fechaCita.Date < DateTime.Today.Date)
            {
                MessageBox.Show("No se pueden programar citas en fechas pasadas.",
                    "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();
                return false;
            }

            //  Validar hora seleccionada
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una hora.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return false;
            }

            // Validar motivo
            if (string.IsNullOrWhiteSpace(txtrason.Text))
            {
                MessageBox.Show("Ingrese el motivo de la cita.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrason.Focus();
                return false;
            }

            return true;
        }
        #endregion

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
            if (!ValidarCampos())
                return;

            try
            {
                // Obtener la fecha
                DateTime fechaCita = DateTime.ParseExact(maskedTextBox1.Text, "dd/MM/yyyy", null);

                // Obtener el paciente seleccionado
                Patient pacienteSeleccionado = (Patient)CmbSeleccionarPaciente.SelectedItem;

                //  Crear objeto Appointment
                Appointment cita = new Appointment
                {
                    Patient = pacienteSeleccionado,
                    Date = fechaCita,
                    Time = comboBox1.SelectedItem.ToString(),
                    Reason = txtrason.Text.Trim(),
                    Status = "Programada"
                };

                AppointmentBusiness business = new AppointmentBusiness(cita);
                int resultado;

                if (EsEdicion && IdCita > 0)
                {
                    //  Actualizar
                    cita.AppointmentId = IdCita;
                    resultado = business.UpdateAppointment();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cita actualizada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  NO cerrar el formulario, solo mostrar mensaje
                        //  Actualizar el título para que sepa que ya fue actualizada
                        
                    }
                }
                else
                {
                    // ✅ Agregar nueva
                    resultado = business.AddAppointment();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cita agregada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  NO cerrar el formulario
                        //  Limpiar campos para agregar otra cita
                        LimpiarCampos();
                    }
                }

                if (resultado <= 0)
                {
                    MessageBox.Show("No se pudo guardar la cita. Intente nuevamente.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la cita: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            CmbSeleccionarPaciente.SelectedIndex = -1;
            maskedTextBox1.Text = DateTime.Today.ToString("dd/MM/yyyy");
            comboBox1.SelectedIndex = -1;
            txtrason.Clear();
            txtrason.Focus();

            // Restaurar horas disponibles
            comboBox1.DataSource = null;
            comboBox1.DataSource = horasBase;
        }






        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DateTime fechaCita;
            if (!DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaCita))
                return;

            try
            {
                Appointment cita = new Appointment();
                DataTable citasDelDia = cita.BuscarPorFecha(maskedTextBox1.Text);

                //  Obtener horas ocupadas
                var horasOcupadas = citasDelDia.AsEnumerable()
                                               .Select(r => r["Time"].ToString())
                                               .ToList();

                //  Filtrar horas disponibles (solo para nuevas citas)
                if (!EsEdicion)
                {
                    var horasDisponibles = horasBase.Except(horasOcupadas).ToList();
                    comboBox1.DataSource = null;
                    comboBox1.DataSource = horasDisponibles;

                    if (comboBox1.Items.Count == 0)
                    {
                        MessageBox.Show("No hay horas disponibles para esta fecha.", "Horas agotadas",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // No mostrar error si no hay citas en esa fecha
            }
        }

        private void CmbSeleccionarPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
