namespace Semestre_Tres.Pantallas
{
    partial class FormExpediente
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
            btnnuevoexpediente = new Button();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            BtnCita = new Button();
            pictureBox1 = new PictureBox();
            TxtBuscar = new TextBox();
            flpexpedientes = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnnuevoexpediente);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(BtnCita);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TxtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 83);
            panel1.TabIndex = 2;
            // 
            // btnnuevoexpediente
            // 
            btnnuevoexpediente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnnuevoexpediente.BackColor = Color.FromArgb(127, 164, 201);
            btnnuevoexpediente.Cursor = Cursors.Hand;
            btnnuevoexpediente.FlatStyle = FlatStyle.Flat;
            btnnuevoexpediente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnuevoexpediente.Image = Properties.Resources._269362_plus_icon;
            btnnuevoexpediente.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevoexpediente.Location = new Point(561, 28);
            btnnuevoexpediente.Name = "btnnuevoexpediente";
            btnnuevoexpediente.Size = new Size(208, 35);
            btnnuevoexpediente.TabIndex = 5;
            btnnuevoexpediente.Text = "Nuevo Expediente";
            btnnuevoexpediente.TextAlign = ContentAlignment.MiddleRight;
            btnnuevoexpediente.UseVisualStyleBackColor = false;
            btnnuevoexpediente.Click += btnnuevoexpediente_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox3.Location = new Point(445, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(127, 164, 201);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources._269362_plus_icon;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1157, 42);
            button1.Name = "button1";
            button1.Size = new Size(212, 35);
            button1.TabIndex = 4;
            button1.Text = "Nuevo Tratamiento";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox2.Location = new Point(1049, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BtnCita
            // 
            BtnCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCita.BackColor = Color.FromArgb(127, 164, 201);
            BtnCita.Cursor = Cursors.Hand;
            BtnCita.FlatStyle = FlatStyle.Flat;
            BtnCita.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCita.Image = Properties.Resources._269362_plus_icon;
            BtnCita.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCita.Location = new Point(1759, 39);
            BtnCita.Name = "BtnCita";
            BtnCita.Size = new Size(211, 38);
            BtnCita.TabIndex = 3;
            BtnCita.Text = "Nueva Cita";
            BtnCita.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox1.Location = new Point(1699, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Cursor = Cursors.IBeam;
            TxtBuscar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(21, 28);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.PlaceholderText = "Buscar por nombre del paciente";
            TxtBuscar.Size = new Size(459, 35);
            TxtBuscar.TabIndex = 1;
            // 
            // flpexpedientes
            // 
            flpexpedientes.AutoScroll = true;
            flpexpedientes.BackColor = SystemColors.ControlLightLight;
            flpexpedientes.Dock = DockStyle.Fill;
            flpexpedientes.Location = new Point(0, 83);
            flpexpedientes.Name = "flpexpedientes";
            flpexpedientes.Padding = new Padding(20);
            flpexpedientes.Size = new Size(800, 367);
            flpexpedientes.TabIndex = 3;
            // 
            // FormExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpexpedientes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormExpediente";
            Text = "FormExpediente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox2;
        private Button BtnCita;
        private PictureBox pictureBox1;
        private TextBox TxtBuscar;
        private PictureBox pictureBox3;
        private Button btnnuevoexpediente;
        private FlowLayoutPanel flpexpedientes;
    }
}