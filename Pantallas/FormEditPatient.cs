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
    public partial class FormEditPatient : Form
    {
        private int idPatient;
        public FormEditPatient(int IdPatient)
        {
            InitializeComponent();
            idPatient = IdPatient;
        
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
            menu.AbrirFormulario(new FormPaciente());
        }
        private void FormEditPatient_Load(object sender, EventArgs e)
        {

            
            Patient p = new Patient();
            DataTable datos = p.BuscarPorId(idPatient); //  ahora busca por clave primaria

            if (datos.Rows.Count > 0)
            {
                txtname.Text = datos.Rows[0]["Name"].ToString();
                txtLastname.Text = datos.Rows[0]["Lastname"].ToString();
                mtbidcard.Text = datos.Rows[0]["IdCard"].ToString();
                txtphone.Text = datos.Rows[0]["Phone"].ToString();
                txtgmail.Text = datos.Rows[0]["Gmail"].ToString();
                mtbbirthdate.Text = Convert.ToDateTime(datos.Rows[0]["BirthDate"]).ToString("yyyy-MM-dd");
                txtadrees.Text = datos.Rows[0]["Address"].ToString();
                comboxgander.Text = datos.Rows[0]["Gender"].ToString();
            
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            //  Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(mtbidcard.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios marcados con *.");
                return; // Detiene la ejecución si falta información
            }

            // Si pasa la validación, crea el objeto y guarda
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

            if (p.Modificar())
            {
                MessageBox.Show("Cambios guardados correctamente.");
                FormMenuAdmin menu = (FormMenuAdmin)Application.OpenForms["FormMenuAdmin"];
                menu.AbrirFormulario(new FormPaciente()); //  vuelve al listado y refresca
            }
            else
            {
                MessageBox.Show("Error al guardar cambios.");
            }
        }
    }
}
