namespace Semestre_Tres.Pantallas
{
    partial class FormPaciente
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
            btnagregar = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            dtgpacientess = new DataGridView();
            panel3 = new Panel();
            btnEliminar = new Button();
            btneditar = new Button();
            BtnVer = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgpacientess).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnagregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 68);
            panel1.TabIndex = 0;
            // 
            // btnagregar
            // 
            btnagregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregar.BackColor = Color.FromArgb(127, 164, 201);
            btnagregar.Cursor = Cursors.Hand;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnagregar.Image = Properties.Resources._269362_plus_icon;
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(766, 20);
            btnagregar.Margin = new Padding(4);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(211, 38);
            btnagregar.TabIndex = 2;
            btnagregar.Text = "Nuevo Paciente";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox1.Location = new Point(554, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(24, 20);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por cédula";
            textBox1.Size = new Size(509, 35);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgpacientess);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 582);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dtgpacientess
            // 
            dtgpacientess.BackgroundColor = SystemColors.ButtonHighlight;
            dtgpacientess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgpacientess.Location = new Point(24, 28);
            dtgpacientess.Name = "dtgpacientess";
            dtgpacientess.Size = new Size(509, 465);
            dtgpacientess.TabIndex = 5;
            dtgpacientess.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btneditar);
            panel3.Controls.Add(BtnVer);
            panel3.Location = new Point(703, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 465);
            panel3.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(32, 352);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = SystemColors.ActiveCaption;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneditar.Location = new Point(32, 215);
            btneditar.Margin = new Padding(4);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(139, 40);
            btneditar.TabIndex = 2;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // BtnVer
            // 
            BtnVer.Anchor = AnchorStyles.Right;
            BtnVer.BackColor = SystemColors.ActiveCaption;
            BtnVer.FlatStyle = FlatStyle.Flat;
            BtnVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVer.Location = new Point(32, 54);
            BtnVer.Margin = new Padding(4);
            BtnVer.Name = "BtnVer";
            BtnVer.Size = new Size(139, 40);
            BtnVer.TabIndex = 1;
            BtnVer.Text = "Ver";
            BtnVer.UseVisualStyleBackColor = false;
            BtnVer.Click += BtnVer_Click;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 650);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPaciente";
            Text = "FormPaciente";
            Load += FormPaciente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgpacientess).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnagregar;
        private Panel panel2;
        private Button btnEliminar;
        private Button btneditar;
        private Button BtnVer;
        private Panel panel3;
        private DataGridView dtgpacientess;
    }
}