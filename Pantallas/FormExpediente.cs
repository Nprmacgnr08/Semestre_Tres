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
    public partial class FormExpediente : Form
    {
        public FormExpediente()
        {
            InitializeComponent();
        }

        private void FormExpediente_Load(object sender, EventArgs e)
        {
            CargarExpedientes();
        }
        private void CargarExpedientes()
        {
            flpexpedientes.Controls.Clear();
            flpexpedientes.AutoScroll = true;

            Expedient expediente = new Expedient();
            ExpedientBusiness business = new ExpedientBusiness(expediente);
            DataTable dt = business.ListAll();

            foreach (DataRow row in dt.Rows)
            {
                Panel card = new Panel
                {
                    Width = 260,
                    Height = 220,
                    BackColor = Color.White,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // 🔹 Encabezado azul
                Panel header = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 40,
                    BackColor = Color.FromArgb(0, 102, 204)
                };
                Label lblCodigo = new Label
                {
                    Text = "EXP" + row["ExpedientId"].ToString().PadLeft(3, '0'),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI Semibold", 9),
                    Location = new Point(10, 10)
                };
                Label lblFecha = new Label
                {
                    Text = Convert.ToDateTime(row["OpenDate"]).ToString("yyyy-MM-dd"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 8),
                    Location = new Point(180, 10)
                };
                header.Controls.Add(lblCodigo);
                header.Controls.Add(lblFecha);
                card.Controls.Add(header);

                // 🔹 Nombre del paciente
                Label lblPaciente = new Label
                {
                    Text = row["Paciente"].ToString(),
                    Font = new Font("Segoe UI Semibold", 10),
                    ForeColor = Color.Black,
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                card.Controls.Add(lblPaciente);

                // 🔹 Tipo de sangre
                Label lblSangreTitulo = new Label
                {
                    Text = "Tipo de Sangre:",
                    Font = new Font("Segoe UI Semibold", 8),
                    ForeColor = Color.FromArgb(0, 102, 204),
                    Location = new Point(10, 75)
                };
                Label lblSangre = new Label
                {
                    Text = row["BloodType"].ToString(),
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.Black,
                    Location = new Point(120, 75)
                };
                card.Controls.Add(lblSangreTitulo);
                card.Controls.Add(lblSangre);

                // 🔹 Alergias
                Label lblAlergiaTitulo = new Label
                {
                    Text = "Alergias:",
                    Font = new Font("Segoe UI Semibold", 8),
                    ForeColor = Color.FromArgb(220, 53, 69),
                    Location = new Point(10, 95)
                };
                Label lblAlergia = new Label
                {
                    Text = row["Allergies"].ToString(),
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.Black,
                    Location = new Point(120, 95)
                };
                card.Controls.Add(lblAlergiaTitulo);
                card.Controls.Add(lblAlergia);

                // 🔹 Estado
                Label lblEstadoTitulo = new Label
                {
                    Text = "Estado:",
                    Font = new Font("Segoe UI Semibold", 8),
                    ForeColor = Color.FromArgb(111, 66, 193),
                    Location = new Point(10, 115)
                };
                Label lblEstado = new Label
                {
                    Text = row["Status"].ToString(),
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.Black,
                    Location = new Point(120, 115)
                };
                card.Controls.Add(lblEstadoTitulo);
                card.Controls.Add(lblEstado);

                // 🔹 Botón Ver Expediente
                Button btnVer = new Button
                {
                    Text = "Ver Expediente",
                    Size = new Size(120, 30),
                    Location = new Point(10, 170),
                    BackColor = Color.FromArgb(0, 102, 204),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btnVer.FlatAppearance.BorderSize = 0;
                btnVer.Click += (s, e) =>
                {
                    int idExpediente = Convert.ToInt32(row["ExpedientId"]);
                    FormVerExpediente frm = new FormVerExpediente(idExpediente);
                    FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
                    menu?.AbrirFormulario(frm);
                };
                card.Controls.Add(btnVer);

                // 🔹 Botón Eliminar (ícono de papelera)
                Button btnEliminar = new Button
                {
                    Size = new Size(30, 30),
                    Location = new Point(200, 170),
                    BackColor = Color.Transparent,
                    FlatStyle = FlatStyle.Flat,
                    Image = Properties.Resources.dustbin_ui_button_eliminate_rubbish_delete_bin_can_trash_icon_210821,
                    ImageAlign = ContentAlignment.MiddleCenter
                };
                btnEliminar.FlatAppearance.BorderSize = 0;
                btnEliminar.Click += (s, e) =>
                {
                    int idExpediente = Convert.ToInt32(row["ExpedientId"]);
                    Expedient exp = new Expedient { ExpedientId = idExpediente };
                    ExpedientBusiness businessDelete = new ExpedientBusiness(exp);

                    DialogResult confirm = MessageBox.Show("¿Desea eliminar este expediente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        int result = businessDelete.DeleteExpedient();
                        if (result > 0)
                        {
                            MessageBox.Show("Expediente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarExpedientes();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el expediente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };
                card.Controls.Add(btnEliminar);

                flpexpedientes.Controls.Add(card);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string nombre = TxtBuscar.Text.Trim();
            flpexpedientes.Controls.Clear();

            Expedient expediente = new Expedient();
            ExpedientBusiness business = new ExpedientBusiness(expediente);
            DataTable dt = business.SearchByPatientName(nombre);

            foreach (DataRow row in dt.Rows)
            {
                Panel card = CrearTarjetaExpediente(row);
                flpexpedientes.Controls.Add(card);
            }
        }

        private void btnnuevoexpediente_Click(object sender, EventArgs e)
        {
            FormAddExpediente frm = new FormAddExpediente();
            FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
            menu?.AbrirFormulario(frm);
        }
        private Panel CrearTarjetaExpediente(DataRow row)
        {
            // Puedes copiar aquí el mismo bloque de creación de tarjeta usado en CargarExpedientes()
            // para mantener consistencia visual.
            Panel card = new Panel
            {
                Width = 260,
                Height = 220,
                BackColor = Color.White,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };
            // ... (reutiliza el mismo contenido del método anterior)
            return card;
        }
    }
}
