namespace Semestre_Tres.Pantallas
{
    partial class FormAppointment
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
            BtnCita = new Button();
            pictureBox1 = new PictureBox();
            TxtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            BtnActualizar = new Button();
            btneliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(BtnCita);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TxtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 90);
            panel1.TabIndex = 0;
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
            BtnCita.Location = new Point(559, 39);
            BtnCita.Name = "BtnCita";
            BtnCita.Size = new Size(211, 38);
            BtnCita.TabIndex = 3;
            BtnCita.Text = "Nueva Cita";
            BtnCita.UseVisualStyleBackColor = false;
            BtnCita.Click += BtnCita_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox1.Location = new Point(499, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Cursor = Cursors.IBeam;
            TxtBuscar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(25, 39);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.PlaceholderText = "Buscar por nombre";
            TxtBuscar.Size = new Size(509, 35);
            TxtBuscar.TabIndex = 1;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 277);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnActualizar.BackColor = SystemColors.ActiveCaption;
            BtnActualizar.Cursor = Cursors.Hand;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnActualizar.Location = new Point(590, 147);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(138, 38);
            BtnActualizar.TabIndex = 4;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btneliminar.BackColor = SystemColors.ActiveCaption;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btneliminar.Location = new Point(590, 237);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(138, 38);
            btneliminar.TabIndex = 5;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // FormAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btneliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAppointment";
            Load += FormAppointment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtBuscar;
        private PictureBox pictureBox1;
        private Button BtnCita;
        private DataGridView dataGridView1;
        private Button BtnActualizar;
        private Button btneliminar;
    }
}