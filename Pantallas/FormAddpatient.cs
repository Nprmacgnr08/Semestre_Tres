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
    public partial class FormAddpatient : Form
    {
        public FormAddpatient()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
            menu.AbrirFormulario(new FormPaciente()); // vuelve al listado sin guardar
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
       string.IsNullOrWhiteSpace(txtLastname.Text) ||
       string.IsNullOrWhiteSpace(mtbidcard.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios marcados con *.");
                return;
            }

            Patient p = new Patient
            {
                Name = txtname.Text,
                Lastname = txtLastname.Text,
                Phone = txtphone.Text,
                Gmail = txtgmail.Text,
                Gender = comboxgander.Text,
                BirthDate = DateTime.Parse(mtbbirthdate.Text),
                Address = txtadrees.Text,
                IdCard = mtbidcard.Text
            };

            if (p.Guardar())
            {
                MessageBox.Show("Paciente agregado correctamente.");
                FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
                menu.AbrirFormulario(new FormPaciente()); // refresca listado
            }
            else
            {
                MessageBox.Show("Error al agregar paciente.");
            }
        }

        private void mtbidcard_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
