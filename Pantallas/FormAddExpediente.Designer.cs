namespace Semestre_Tres.Pantallas
{
    partial class FormAddExpediente
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
            picSalir = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            mtbcedula = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            cmbsangretype = new ComboBox();
            TxtAlergias = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txthistorial = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label8 = new Label();
            btncrear = new Button();
            btncancelar = new Button();
            cmbPaciente = new ComboBox();
            cmbtratamientos = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picSalir);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 74);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.x_icon_150997;
            pictureBox2.Location = new Point(932, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // picSalir
            // 
            picSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSalir.Image = Properties.Resources.x_icon_150997;
            picSalir.Location = new Point(1426, 24);
            picSalir.Name = "picSalir";
            picSalir.Size = new Size(35, 35);
            picSalir.SizeMode = PictureBoxSizeMode.Zoom;
            picSalir.TabIndex = 3;
            picSalir.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x_icon_150997;
            pictureBox1.Location = new Point(1925, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(331, 13);
            label1.Name = "label1";
            label1.Size = new Size(293, 45);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Expediente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.100592F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.89941F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 508F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(mtbcedula, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 2, 2);
            tableLayoutPanel1.Controls.Add(cmbsangretype, 1, 3);
            tableLayoutPanel1.Controls.Add(TxtAlergias, 2, 3);
            tableLayoutPanel1.Controls.Add(label6, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 2, 4);
            tableLayoutPanel1.Controls.Add(txthistorial, 2, 5);
            tableLayoutPanel1.Controls.Add(panel2, 1, 6);
            tableLayoutPanel1.Controls.Add(btncrear, 2, 7);
            tableLayoutPanel1.Controls.Add(btncancelar, 1, 7);
            tableLayoutPanel1.Controls.Add(cmbPaciente, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbtratamientos, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 74);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.3076935F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.6923065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 171F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
            tableLayoutPanel1.Size = new Size(1030, 576);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(498, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 1;
            label3.Text = "Cédula de identidad*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 2;
            label2.Text = "Seleccionar paciente*";
            // 
            // mtbcedula
            // 
            mtbcedula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbcedula.Location = new Point(498, 36);
            mtbcedula.Mask = "000-000000-0000L";
            mtbcedula.Name = "mtbcedula";
            mtbcedula.Size = new Size(296, 25);
            mtbcedula.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 78);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 5;
            label4.Text = "Tipo de sangre*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(498, 78);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 6;
            label5.Text = "Alergias*";
            // 
            // cmbsangretype
            // 
            cmbsangretype.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbsangretype.FormattingEnabled = true;
            cmbsangretype.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cmbsangretype.Location = new Point(38, 113);
            cmbsangretype.Name = "cmbsangretype";
            cmbsangretype.Size = new Size(299, 25);
            cmbsangretype.TabIndex = 7;
            // 
            // TxtAlergias
            // 
            TxtAlergias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAlergias.Location = new Point(498, 113);
            TxtAlergias.Name = "TxtAlergias";
            TxtAlergias.Size = new Size(299, 25);
            TxtAlergias.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 156);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 9;
            label6.Text = "Tratamiento*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(498, 156);
            label7.Name = "label7";
            label7.Size = new Size(126, 21);
            label7.TabIndex = 10;
            label7.Text = "Historial Clínico*";
            // 
            // txthistorial
            // 
            txthistorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txthistorial.Location = new Point(498, 196);
            txthistorial.Multiline = true;
            txthistorial.Name = "txthistorial";
            txthistorial.Size = new Size(299, 41);
            txthistorial.TabIndex = 14;
            // 
            // panel2
            // 
            tableLayoutPanel1.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(38, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 130);
            panel2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(583, 103);
            textBox1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(388, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 21);
            label8.TabIndex = 10;
            label8.Text = "Notas médicas*";
            // 
            // btncrear
            // 
            btncrear.Anchor = AnchorStyles.Top;
            btncrear.BackColor = Color.FromArgb(127, 164, 201);
            btncrear.FlatStyle = FlatStyle.Flat;
            btncrear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncrear.ForeColor = SystemColors.ControlText;
            btncrear.Location = new Point(664, 469);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(170, 35);
            btncrear.TabIndex = 16;
            btncrear.Text = "Crear Expediente";
            btncrear.UseVisualStyleBackColor = false;
            btncrear.Click += btncrear_Click;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Top;
            btncancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancelar.Location = new Point(185, 469);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 35);
            btncancelar.TabIndex = 32;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(38, 36);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(299, 23);
            cmbPaciente.TabIndex = 33;
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
            // 
            // cmbtratamientos
            // 
            cmbtratamientos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbtratamientos.FormattingEnabled = true;
            cmbtratamientos.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cmbtratamientos.Location = new Point(38, 196);
            cmbtratamientos.Name = "cmbtratamientos";
            cmbtratamientos.Size = new Size(299, 25);
            cmbtratamientos.TabIndex = 34;
            // 
            // FormAddExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 650);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddExpediente";
            Text = "FormAddExpediente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox picSalir;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private MaskedTextBox mtbcedula;
        private Label label4;
        private Label label5;
        private ComboBox cmbsangretype;
        private TextBox TxtAlergias;
        private Label label6;
        private Label label7;
        private TextBox txthistorial;
        private Panel panel2;
        private TextBox textBox1;
        private Label label8;
        private Button btncrear;
        private Button btncancelar;
        private ComboBox cmbPaciente;
        private ComboBox cmbtratamientos;
    }
}