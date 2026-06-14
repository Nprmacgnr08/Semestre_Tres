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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblver_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menuAdmin = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;

            if (menuAdmin != null)
            {
                // Abrir el formulario de citas dentro del panel contenedor del menú
                menuAdmin.AbrirFormulario(new FormAppointment());
            }
        }
        private void lblver_MouseEnter(object sender, EventArgs e)
        {
            lblver.ForeColor = Color.DodgerBlue; // cambia color al pasar el cursor
            lblver.Cursor = Cursors.Hand;        // muestra el cursor de enlace
        }

        private void lblver_MouseLeave(object sender, EventArgs e)
        {
            lblver.ForeColor = Color.Black; // vuelve al color normal
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
