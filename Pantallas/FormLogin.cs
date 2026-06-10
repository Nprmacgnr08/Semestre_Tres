using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestre_Tres.Pantallas
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim().ToLower();
            string clave = txtclave.Text.Trim();


            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (usuario == "Admin@gmail.com" && clave == "admin1234")
            {
                MessageBox.Show("¡Bienvenido, admin!", "Acceso Permitido",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuAdmin menuAdmin = new FormMenuAdmin();
                menuAdmin.Show();
                this.Close();
            }
            else if (usuario == "Medico@gmail.com" && clave == "medico1234")
            {
                MessageBox.Show("¡Bienvenido, Médico!", "Acceso Permitido",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuMedico menuMedico = new FormMenuMedico();
                menuMedico.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.");
            }
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            txtclave.ForeColor = Color.Black;
        }
    }
}
