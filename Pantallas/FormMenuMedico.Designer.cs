namespace Semestre_Tres.Pantallas
{
    partial class FormMenuMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btncerrarsesion = new Button();
            btnexpediente = new Button();
            btnconsultas = new Button();
            btndashboardmedi = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pnlcontenedormedi = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(216, 225, 235);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btncerrarsesion);
            panel1.Controls.Add(btnexpediente);
            panel1.Controls.Add(btnconsultas);
            panel1.Controls.Add(btndashboardmedi);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.double_arrow_horizontal_symbol_icon_icons_com_73277;
            pictureBox2.Location = new Point(184, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btncerrarsesion
            // 
            btncerrarsesion.Dock = DockStyle.Bottom;
            btncerrarsesion.FlatAppearance.BorderSize = 0;
            btncerrarsesion.FlatStyle = FlatStyle.Flat;
            btncerrarsesion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncerrarsesion.Image = Properties.Resources.entry_door_open_exit_icon_208826;
            btncerrarsesion.ImageAlign = ContentAlignment.MiddleLeft;
            btncerrarsesion.Location = new Point(0, 400);
            btncerrarsesion.Name = "btncerrarsesion";
            btncerrarsesion.Size = new Size(220, 50);
            btncerrarsesion.TabIndex = 4;
            btncerrarsesion.Text = "Cerrar Sesión";
            btncerrarsesion.UseVisualStyleBackColor = true;
            // 
            // btnexpediente
            // 
            btnexpediente.Dock = DockStyle.Top;
            btnexpediente.FlatAppearance.BorderSize = 0;
            btnexpediente.FlatStyle = FlatStyle.Flat;
            btnexpediente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexpediente.Image = Properties.Resources.fileinterfacesymboloftextpapersheet_79740;
            btnexpediente.ImageAlign = ContentAlignment.MiddleLeft;
            btnexpediente.Location = new Point(0, 200);
            btnexpediente.Name = "btnexpediente";
            btnexpediente.Size = new Size(220, 50);
            btnexpediente.TabIndex = 3;
            btnexpediente.Text = "Expediente";
            btnexpediente.UseVisualStyleBackColor = true;
            // 
            // btnconsultas
            // 
            btnconsultas.Dock = DockStyle.Top;
            btnconsultas.FlatAppearance.BorderSize = 0;
            btnconsultas.FlatStyle = FlatStyle.Flat;
            btnconsultas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconsultas.Image = Properties.Resources.Doctor_Medical_Instrument_Stethoscope_icon_icons_com_65902;
            btnconsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnconsultas.Location = new Point(0, 150);
            btnconsultas.Name = "btnconsultas";
            btnconsultas.Size = new Size(220, 50);
            btnconsultas.TabIndex = 2;
            btnconsultas.Text = "Consultas";
            btnconsultas.UseVisualStyleBackColor = true;
            // 
            // btndashboardmedi
            // 
            btndashboardmedi.Dock = DockStyle.Top;
            btndashboardmedi.FlatAppearance.BorderSize = 0;
            btndashboardmedi.FlatStyle = FlatStyle.Flat;
            btndashboardmedi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndashboardmedi.Image = Properties.Resources.home_house_icon_icons_com_49851;
            btndashboardmedi.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboardmedi.Location = new Point(0, 100);
            btndashboardmedi.Name = "btndashboardmedi";
            btndashboardmedi.Size = new Size(220, 50);
            btndashboardmedi.TabIndex = 1;
            btndashboardmedi.Text = "DashBoard";
            btndashboardmedi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Clinica_Dental_Integral_Guadalupe_Logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(216, 225, 235);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 100);
            panel2.TabIndex = 1;
            // 
            // pnlcontenedormedi
            // 
            pnlcontenedormedi.Dock = DockStyle.Fill;
            pnlcontenedormedi.Location = new Point(220, 100);
            pnlcontenedormedi.Name = "pnlcontenedormedi";
            pnlcontenedormedi.Size = new Size(580, 350);
            pnlcontenedormedi.TabIndex = 2;
            // 
            // FormMenuMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlcontenedormedi);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuMedico";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel pnlcontenedormedi;
        private Button btncerrarsesion;
        private Button btnexpediente;
        private Button btnconsultas;
        private Button btndashboardmedi;
        private PictureBox pictureBox2;
    }
}