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

namespace Semestre_Tres.Pantallas
{
    public partial class FormDetallePatient : Form
    {
        private int idPatient;
        public FormDetallePatient(int IdPatient)
        {
            InitializeComponent();
            idPatient = IdPatient;
        }

        private void FormDetallePatient_Load(object sender, EventArgs e)
        {

            Patient p = new Patient();
            DataTable datos = p.BuscarPorId(idPatient); // ✅ usamos el nuevo método

            if (datos.Rows.Count > 0)
            {
                LblName.Text = datos.Rows[0]["Name"].ToString();
                LblLastname.Text = datos.Rows[0]["Lastname"].ToString();
                LblIdcard.Text = datos.Rows[0]["IdCard"].ToString();
                LblPhone.Text = datos.Rows[0]["Phone"].ToString();
                LblGmail.Text = datos.Rows[0]["Gmail"].ToString();
                LblBirthDate.Text = Convert.ToDateTime(datos.Rows[0]["BirthDate"]).ToString("dd/MM/yyyy");
                LblAdrees.Text = datos.Rows[0]["Address"].ToString();
                LblGender.Text = datos.Rows[0]["Gender"].ToString();
         
            }
            else
            {
                MessageBox.Show("No se encontró información del paciente.");
                FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
                menu.AbrirFormulario(new FormPaciente()); // ✅ vuelve al listado si no hay datos
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
            menu.AbrirFormulario(new FormPaciente());
        }
    }
}
