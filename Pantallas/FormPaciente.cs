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
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        // Carga la lista de pacientes al abrir el formulario
        private void FormPaciente_Load(object sender, EventArgs e)
        {
            Patient p = new Patient();
            dtgpaciente.DataSource = p.Listar();
        }

        //Abre el formulario para agregar un nuevo paciente y refresca la lista después de agregar
        private void btnagregar_Click(object sender, EventArgs e)
        {
            FormAddpatient frm = new FormAddpatient();
            FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
            menu.AbrirFormulario(frm); 
        }

        // Abre el formulario de detalles del paciente seleccionado
        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (dtgpaciente.SelectedRows.Count > 0)
            {
                int idPatient = Convert.ToInt32(dtgpaciente.SelectedRows[0].Cells["IdPatient"].Value);
                FormDetallePatient frm = new FormDetallePatient(idPatient);
                FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
                menu.AbrirFormulario(frm);
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para ver detalles.");
            }

        }

        // Abre el formulario para editar el paciente seleccionado y refresca la lista después de editar
        private void btneditar_Click(object sender, EventArgs e)
        {

            if (dtgpaciente.SelectedRows.Count > 0)
            {
                int idPatient = Convert.ToInt32(dtgpaciente.SelectedRows[0].Cells["IdPatient"].Value);
                FormEditPatient frm = new FormEditPatient(idPatient);
                FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
                menu.AbrirFormulario(frm);
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para editar.");
            }


        }

        // Elimina el paciente seleccionado y refresca la lista después de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgpaciente.SelectedRows.Count > 0)
            {
                int idPatient = Convert.ToInt32(dtgpaciente.SelectedRows[0].Cells["IdPatient"].Value);
                Patient p = new Patient();
                if (p.Eliminar("IdPatient", idPatient))
                {
                    MessageBox.Show("Paciente eliminado correctamente.");
                    dtgpaciente.DataSource = p.Listar(); // refresca lista
                }
                else
                {
                    MessageBox.Show("Error al eliminar paciente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente en la lista.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            dtgpaciente.DataSource = p.BuscarPorCedula(textBox1.Text);
        }
    }
}
