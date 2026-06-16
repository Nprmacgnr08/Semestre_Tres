namespace Semestre_Tres.Pantallas
{
    partial class FormTratamiento
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
            btntratamiento = new Button();
            pictureBox2 = new PictureBox();
            BtnCita = new Button();
            pictureBox1 = new PictureBox();
            TxtBuscar = new TextBox();
            flpTratamiento = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btntratamiento);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(BtnCita);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TxtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 120);
            panel1.TabIndex = 1;
            // 
            // btntratamiento
            // 
            btntratamiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btntratamiento.BackColor = Color.FromArgb(127, 164, 201);
            btntratamiento.Cursor = Cursors.Hand;
            btntratamiento.FlatStyle = FlatStyle.Flat;
            btntratamiento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntratamiento.Image = Properties.Resources._269362_plus_icon;
            btntratamiento.ImageAlign = ContentAlignment.MiddleLeft;
            btntratamiento.Location = new Point(742, 51);
            btntratamiento.Margin = new Padding(3, 4, 3, 4);
            btntratamiento.Name = "btntratamiento";
            btntratamiento.Size = new Size(259, 47);
            btntratamiento.TabIndex = 4;
            btntratamiento.Text = "Nuevo Tratamiento";
            btntratamiento.TextAlign = ContentAlignment.MiddleRight;
            btntratamiento.UseVisualStyleBackColor = false;
            btntratamiento.Click += btntratamiento_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox2.Location = new Point(613, 51);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            BtnCita.Location = new Point(1447, 52);
            BtnCita.Margin = new Padding(3, 4, 3, 4);
            BtnCita.Name = "BtnCita";
            BtnCita.Size = new Size(241, 51);
            BtnCita.TabIndex = 3;
            BtnCita.Text = "Nueva Cita";
            BtnCita.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox1.Location = new Point(1378, 56);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Cursor = Cursors.IBeam;
            TxtBuscar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(29, 56);
            TxtBuscar.Margin = new Padding(3, 4, 3, 4);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.PlaceholderText = "Buscar por Tratamiento";
            TxtBuscar.Size = new Size(524, 42);
            TxtBuscar.TabIndex = 1;
            // 
            // flpTratamiento
            // 
            flpTratamiento.AutoScroll = true;
            flpTratamiento.BackColor = Color.WhiteSmoke;
            flpTratamiento.CausesValidation = false;
            flpTratamiento.Dock = DockStyle.Fill;
            flpTratamiento.Location = new Point(0, 120);
            flpTratamiento.Margin = new Padding(3, 4, 3, 4);
            flpTratamiento.Name = "flpTratamiento";
            flpTratamiento.Padding = new Padding(11, 13, 11, 13);
            flpTratamiento.Size = new Size(1036, 480);
            flpTratamiento.TabIndex = 2;
            // 
            // FormTratamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 600);
            Controls.Add(flpTratamiento);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTratamiento";
            Text = "FormTratamiento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnCita;
        private PictureBox pictureBox1;
        private TextBox TxtBuscar;
        private PictureBox pictureBox2;
        private Button btntratamiento;
        private FlowLayoutPanel flpTratamiento;
    }
}