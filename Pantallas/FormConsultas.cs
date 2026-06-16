using Semestre_Tres.Bussines;
using Semestre_Tres.Clases;
using System.Data;

namespace Semestre_Tres.Pantallas
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            CargarConsultas();
        }
        private void CargarConsultas()
        {
            flpConsultas.Controls.Clear();
            flpConsultas.AutoScroll = true;

            Consultation consulta = new Consultation();
            ConsultationBusiness business = new ConsultationBusiness(consulta);
            DataTable dt = business.ListAll();

            foreach (DataRow row in dt.Rows)
            {
                Panel card = CrearTarjetaConsulta(row);
                flpConsultas.Controls.Add(card);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string nombre = TxtBuscar.Text.Trim();
            flpConsultas.Controls.Clear();

            Consultation consulta = new Consultation();
            ConsultationBusiness business = new ConsultationBusiness(consulta);
            DataTable dt = business.SearchByPatientName(nombre);

            foreach (DataRow row in dt.Rows)
            {
                Panel card = CrearTarjetaConsulta(row);
                flpConsultas.Controls.Add(card);
            }
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            FormAddConsultas frm = new FormAddConsultas();
            FormMenuMedico menu = Application.OpenForms["FormMenuMedico"] as FormMenuMedico;
            menu?.AbrirFormulario(frm);
        }
        private Panel CrearTarjetaConsulta(DataRow row)
        {
            Panel card = new Panel
            {
                Width = 520,
                Height = 100,
                BackColor = Color.White,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // 🔹 Encabezado verde
            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 25,
                BackColor = Color.ForestGreen
            };
            Label lblCodigo = new Label
            {
                Text = "CON" + row["ConsultationId"].ToString().PadLeft(3, '0'),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 8),
                Location = new Point(10, 5)
            };
            Label lblPaciente = new Label
            {
                Text = row["Paciente"].ToString(),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 8),
                Location = new Point(80, 5)
            };
            header.Controls.Add(lblCodigo);
            header.Controls.Add(lblPaciente);
            card.Controls.Add(header);

            // 🔹 Diagnóstico
            Label lblDiagTitulo = new Label
            {
                Text = "Dx:",
                Font = new Font("Segoe UI Semibold", 8),
                ForeColor = Color.FromArgb(220, 53, 69),
                Location = new Point(10, 35)
            };
            Label lblDiag = new Label
            {
                Text = row["Diagnosis"].ToString(),
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Black,
                Location = new Point(50, 35),
                AutoSize = true
            };

            // 🔹 Tratamiento
            Label lblTratTitulo = new Label
            {
                Text = "Proc:",
                Font = new Font("Segoe UI Semibold", 8),
                ForeColor = Color.FromArgb(111, 66, 193),
                Location = new Point(10, 55)
            };
            Label lblTrat = new Label
            {
                Text = row["Tratamiento"].ToString(),
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Black,
                Location = new Point(50, 55),
                AutoSize = true
            };

            // 🔹 Observaciones
            Label lblObsTitulo = new Label
            {
                Text = "Obs:",
                Font = new Font("Segoe UI Semibold", 8),
                ForeColor = Color.FromArgb(255, 193, 7),
                Location = new Point(10, 75)
            };
            Label lblObs = new Label
            {
                Text = row["Observations"].ToString(),
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Black,
                Location = new Point(50, 75),
                Width = 380,
                AutoSize = false
            };

            // 🔹 Botón eliminar con ícono de papelera
            Button btnEliminar = new Button
            {
                Size = new Size(30, 30),
                Location = new Point(480, 60),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Image = Properties.Resources.dustbin_ui_button_eliminate_rubbish_delete_bin_can_trash_icon_210821, // tu recurso de papelera
                ImageAlign = ContentAlignment.MiddleCenter
            };
            btnEliminar.FlatAppearance.BorderSize = 0;

            // Evento click del botón
            btnEliminar.Click += (s, e) =>
            {
                int consultaId = Convert.ToInt32(row["ConsultationId"]);
                Consultation consulta = new Consultation { ConsultationId = consultaId };
                ConsultationBusiness business = new ConsultationBusiness(consulta);

                DialogResult confirm = MessageBox.Show("¿Desea eliminar esta consulta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int result = business.DeleteConsultation();
                    if (result > 0)
                    {
                        MessageBox.Show("Consulta eliminada correctamente.");
                        CargarConsultas(); // refrescar listado
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la consulta.");
                    }
                }
            };

            // Agregar al panel
            card.Controls.Add(lblDiagTitulo);
            card.Controls.Add(lblDiag);
            card.Controls.Add(lblTratTitulo);
            card.Controls.Add(lblTrat);
            card.Controls.Add(lblObsTitulo);
            card.Controls.Add(lblObs);
            card.Controls.Add(btnEliminar);

            return card;
        }
    }
}
