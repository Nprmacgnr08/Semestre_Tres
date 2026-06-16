namespace Semestre_Tres.Pantallas
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

        }

        private Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "Administrador@gmail.com", "Admin14" },
            { "Medico@gmail.com", "medico77" },

        };


        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtclave.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtclave.UseSystemPasswordChar = false;
            }
            else
            {
                txtclave.UseSystemPasswordChar = true;
            }
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string correo = TxtUser.Text.Trim();
            string codigo = txtclave.Text.Trim();

            if (usuarios.ContainsKey(correo) && usuarios[correo] == codigo)
            {
                MessageBox.Show("Acceso concedido", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir menú según el rol
                if (correo == "Administrador@gmail.com")
                {
                    FormMenuAdmin menuAdmin = new FormMenuAdmin();
                    menuAdmin.Show();
                }
                else if (correo == "Medico@gmail.com")
                {
                    FormMenuMedico menuMedico = new FormMenuMedico();
                    menuMedico.Show();
                }

                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o código incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
