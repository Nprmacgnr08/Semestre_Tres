namespace Semestre_Tres.Pantallas
{
    public partial class FormMenuAdmin : Form
    {
        //Definir los colores para el efecto
        Color colorNormal = Color.FromArgb(216, 225, 235); // Color original del panel
        Color coloractivo = Color.FromArgb(127, 164, 201); // Color para el efecto de activación
        public FormMenuAdmin()
        {
            InitializeComponent();

            //Al iniciar el formulario, se activa el botón del dashboard por defecto
            ActivarBoton(btnmenu);
            //Al iniciar el formulario, se muestra el dashboard por defecto
            AbrirFormulario(new FormDashboard());

        }

        //Metodo para manejar el cambio de los botones activos

        private void ActivarBoton(Button botonActivo)
        {
            foreach (Button btn in panelMenu.Controls.OfType<Button>())
            {
                btn.BackColor = colorNormal; // todos vuelven al color normal
                btn.ForeColor = Color.Black;
            }

            botonActivo.BackColor = coloractivo; // el botón activo se resalta
            botonActivo.ForeColor = Color.White; // texto blanco para contraste
        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }
        //Metodo para actualizar el header según el botón activo
        private void ActualizarHeader(string titulo, string subtitulo)
        {
            LblTitulo.Text = titulo;
            LblSubtitulo.Text = subtitulo;
        }
        // Metodo para manejar el evento de clic en los botones del menú
        private void BotonMenu(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // identifica cuál botón fue presionado
            ActivarBoton(boton);

            // Actualizar el header según el botón presionado
            switch
                (boton.Name)
            {
                case "btnmenu":
                    ActualizarHeader("DashBoard Administrativo", "Bienvenido al sistema de gestión de la clínica Dental Integral Guadalupe");
                    AbrirFormulario(new FormDashboard()); // Abrir el formulario del dashboard
                    break;
                case "btnPaciente":
                    ActualizarHeader("Gestión de Pacientes", "Administra la información de los pacientes en la clínica");
                    AbrirFormulario(new FormPaciente()); // Abrir el formulario de pacientes
                    break;
                case "btncitas":
                    ActualizarHeader("Gestión de Citas", "Administra las citas programadas en la clínica");
                    AbrirFormulario(new FormAppointment()); // Abrir el formulario de citas
                    break;
                case "btnpago":
                    ActualizarHeader("Gestión de Pagos", "Registro y control sobre los pagos de la clínica");
                    AbrirFormulario(new FormPago()); // Abrir el formulario de pagos
                    break;
                case "btntratamiento":
                    ActualizarHeader("Gestión de Tratamientos", "Gestión de procedimientos y precios");
                    AbrirFormulario(new FormTratamiento()); // Abrir el formulario de tratamientos
                    break;
                case "btnsalir":

                    DialogResult resultado = MessageBox.Show(
                    "¿Está seguro que desea cerrar sesión?",
                    "Confirmar cierre de sesión",
                      MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
   );

                    if (resultado == DialogResult.Yes)
                    {
                        // Regresar al formulario de roles
                        FormRol rol = new FormRol();
                        rol.Show();
                        this.Close(); // Cierra el menú actual
                    }
                    // Si elige No, no pasa nada y se queda en el menú
                    break;
            }
        }
        // Método para colapsar o expandir el menú
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 220)
            {
                panelMenu.Width = 60; // Colapsar el menú
                foreach (Button button in panelMenu.Controls.OfType<Button>())
                {
                    button.Text = ""; // Ocultar el texto de los botones
                    button.ImageAlign = ContentAlignment.MiddleCenter; // Centrar la imagen
                }
            }
            else
            {
                panelMenu.Width = 220; // Expandir el menú

                btnmenu.Text = "DashBoard";
                btnPaciente.Text = "Pacientes";
                btncitas.Text = "Citas";
                btnpago.Text = "Pagos";
                btntratamiento.Text = "Tratamientos";
                btnsalir.Text = "Cerrar Sesión";
                foreach (Button button in panelMenu.Controls.OfType<Button>())
                {
                    button.ImageAlign = ContentAlignment.MiddleLeft; // Alinear la imagen a la izquierda
                }
            }
        }
        //Metodo para abrir los formularios dentro del panel principal
        public void AbrirFormulario(Form formulario)
        {
            foreach (Form frm in pnlcontenedor.Controls.OfType<Form>())
            {
                frm.Close();
            }


            pnlcontenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlcontenedor.Controls.Add(formulario);
            formulario.Show();
        }

    }

}
