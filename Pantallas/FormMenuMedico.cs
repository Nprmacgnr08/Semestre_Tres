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

        //Definir los colores para el efecto
        Color colorNormal = Color.FromArgb(216, 225, 235); // Color original del panel
        Color colorActivo = Color.FromArgb(127, 164, 201); // Color para el efecto de activación
        public FormMenuMedico()
        {
            InitializeComponent();
            ActivarBoton(btndashboardmedi);
            AbrirFormulario(new FormDashboard());
        }
        private void ActivarBoton(Button botonActivo)
        {
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                btn.BackColor = colorNormal;
                btn.ForeColor = Color.Black;
            }

            botonActivo.BackColor = colorActivo;
            botonActivo.ForeColor = Color.White;
        }
        private void ActualizarHeader(string titulo, string subtitulo)
        {
            LblTitulo.Text = titulo;
            LblSubtitulo.Text = subtitulo;
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

        private void BotonMenuMedi(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            ActivarBoton(boton);

            switch (boton.Name)
            {
                case "btndashboardmedi":
                    ActualizarHeader("Panel Médico", "Bienvenido al sistema de gestión de la clínica Dental Integral Guadalupe");
                    AbrirFormulario(new FormDashboard());
                    break;

                case "btnconsultas":
                    ActualizarHeader("Gestión de Consultas", "Administra las consultas médicas y diagnósticos");
                    AbrirFormulario(new FormConsultas());
                    break;

                case "btnexpediente":
                    ActualizarHeader("Expediente del Paciente", "Visualiza y actualiza los historiales clínicos");
                    AbrirFormulario(new FormExpediente());
                    break;

                case "btncerrarsesion":
                    DialogResult resultado = MessageBox.Show(
                        "¿Está seguro que desea cerrar sesión?",
                        "Confirmar cierre de sesión",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        FormRol rol = new FormRol();
                        rol.Show();
                        this.Close();
                    }
                    break;
            }
        }
             public void AbrirFormulario(Form formulario)
        {
         
            foreach (Form frm in pnlcontenedormedi.Controls.OfType<Form>())
            {
                frm.Close();
            }


            pnlcontenedormedi.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlcontenedormedi.Controls.Add(formulario);
            formulario.Show();
        }
    }
    
}
