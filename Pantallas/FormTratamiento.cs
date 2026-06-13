using Semestre_Tres.Bussines;
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
    public partial class FormTratamiento : Form
    {
        public FormTratamiento()
        {
            InitializeComponent();
            CargarTratamientos();
        }
        private void CargarTratamientos()
        {
            flpTratamiento.Controls.Clear();

            Treatment t = new Treatment();
            TreatmentBusiness business = new TreatmentBusiness(t);
            DataTable dt = business.ListAll();

            foreach (DataRow row in dt.Rows)
            {
                Panel card = CrearTarjetaTratamiento(row);
                flpTratamiento.Controls.Add(card);
            }
        }
        private Panel CrearTarjetaTratamiento(DataRow row)
        {
            Panel card = new Panel
            {
                Width = 250,
                Height = 180,
                BackColor = Color.White,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10), 
                Cursor = Cursors.Hand       
            };

            Label lblCodigo = new Label
            {
                Text = $"TRT{row["TreatmentId"]:000}",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(10, 10)
            };

            Label lblNombre = new Label
            {
                Text = row["Name"].ToString(),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(10, 35),
                AutoSize = true
            };

            Label lblDescripcion = new Label
            {
                Text = row["Description"].ToString(),
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(10, 60),
                Size = new Size(230, 40)
            };

            Label lblPrecio = new Label
            {
                Text = $"Precio: C$ {Convert.ToDecimal(row["Cost"]):N2}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.ForestGreen,
                Location = new Point(10, 105)
            };

            Label lblDuracion = new Label
            {
                Text = $"Duración: {row["Duration"]}",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DodgerBlue,
                Location = new Point(10, 130)
            };

            Button btnEliminar = new Button
            {
                Text = "Eliminar",
                BackColor = Color.LightCoral,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(150, 130),
                Width = 80,
                Height = 25
            };

            btnEliminar.Click += (s, e) =>
            {
                int id = Convert.ToInt32(row["TreatmentId"]);
                EliminarTratamiento(id);
            };

            card.Controls.Add(lblCodigo);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblDescripcion);
            card.Controls.Add(lblPrecio);
            card.Controls.Add(lblDuracion);
            card.Controls.Add(btnEliminar);

            return card;
        }
        private void EliminarTratamiento(int id)
        {
            DialogResult confirm = MessageBox.Show("¿Desea eliminar este tratamiento?",
                                                   "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Treatment t = new Treatment { TreatmentId = id };
                TreatmentBusiness business = new TreatmentBusiness(t);

                try
                {
                    int result = business.DeleteTreatment();
                    if (result > 0)
                    {
                        MessageBox.Show("Tratamiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTratamientos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el tratamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string nombre = TxtBuscar.Text.Trim();
            flpTratamiento.Controls.Clear();

            Treatment t = new Treatment();
            TreatmentBusiness business = new TreatmentBusiness(t);
            DataTable dt = business.SearchByName(nombre);

            foreach (DataRow row in dt.Rows)
            {
                Panel card = CrearTarjetaTratamiento(row);
                flpTratamiento.Controls.Add(card);
            }
        }

        private void btntratamiento_Click(object sender, EventArgs e)
        {
            FormAddTratamiento frm = new FormAddTratamiento();
            FormMenuAdmin menu = Application.OpenForms["FormMenuAdmin"] as FormMenuAdmin;
            menu?.AbrirFormulario(frm);
        }
    }
}
