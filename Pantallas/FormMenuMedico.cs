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
    public partial class FormMenuMedico : Form
    {
        public FormMenuMedico()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 220)
            {
                // 🔹 Colapsar menú
                panel1.Width = 60;

                // Ocultar texto de los botones
                btndashboardmedi.Text = "";
                btnconsultas.Text = "";
                btnexpediente.Text = "";
                btncerrarsesion.Text = "";

                // Centrar los íconos
                btndashboardmedi.ImageAlign = ContentAlignment.MiddleCenter;
                btnconsultas.ImageAlign = ContentAlignment.MiddleCenter;
                btnexpediente.ImageAlign = ContentAlignment.MiddleCenter;
                btncerrarsesion.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                // 🔹 Expandir menú
                panel1.Width = 220;

                // Restaurar texto
                btndashboardmedi.Text = "DashBoard";
                btnconsultas.Text = "Consultas";
                btnexpediente.Text = "Expediente";
                btncerrarsesion.Text = "Cerrar Sesión";

                // Alinear íconos y texto
                btndashboardmedi.ImageAlign = ContentAlignment.MiddleLeft;
                btnconsultas.ImageAlign = ContentAlignment.MiddleLeft;
                btnexpediente.ImageAlign = ContentAlignment.MiddleLeft;
                btncerrarsesion.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
