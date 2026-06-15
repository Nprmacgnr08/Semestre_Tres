namespace Semestre_Tres.Pantallas
{
    partial class FormAddApointment
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            CmbSeleccionarPaciente = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            txtrason = new TextBox();
            BtnAgendar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 99);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x_icon_150997;
            pictureBox1.Location = new Point(933, 32);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(399, 25);
            label1.Name = "label1";
            label1.Size = new Size(219, 54);
            label1.TabIndex = 0;
            label1.Text = "Nueva Cita";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 430F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 430F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 2);
            tableLayoutPanel1.Controls.Add(maskedTextBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
            tableLayoutPanel1.Controls.Add(BtnAgendar, 2, 7);
            tableLayoutPanel1.Controls.Add(btnCancelar, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 99);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1030, 498);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 0;
            label2.Text = "Paciente*";
            // 
            // panel2
            // 
            tableLayoutPanel1.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(CmbSeleccionarPaciente);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(72, 44);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 45);
            panel2.TabIndex = 1;
            // 
            // CmbSeleccionarPaciente
            // 
            CmbSeleccionarPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbSeleccionarPaciente.FormattingEnabled = true;
            CmbSeleccionarPaciente.Location = new Point(0, 5);
            CmbSeleccionarPaciente.Margin = new Padding(3, 4, 3, 4);
            CmbSeleccionarPaciente.Name = "CmbSeleccionarPaciente";
            CmbSeleccionarPaciente.Size = new Size(378, 40);
            CmbSeleccionarPaciente.TabIndex = 0;
            CmbSeleccionarPaciente.SelectedIndexChanged += CmbSeleccionarPaciente_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 93);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 1;
            label4.Text = "Fecha*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(502, 93);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 4;
            label3.Text = "Hora*";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(72, 137);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(251, 32);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(502, 137);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 33);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Seleccione";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 186);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 7;
            label5.Text = "Motivo*";
            // 
            // panel3
            // 
            tableLayoutPanel1.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(txtrason);
            panel3.Location = new Point(72, 230);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(635, 108);
            panel3.TabIndex = 8;
            // 
            // txtrason
            // 
            txtrason.Dock = DockStyle.Fill;
            txtrason.Location = new Point(0, 0);
            txtrason.Margin = new Padding(3, 4, 3, 4);
            txtrason.Multiline = true;
            txtrason.Name = "txtrason";
            txtrason.PlaceholderText = "Descripción del motivo";
            txtrason.ScrollBars = ScrollBars.Horizontal;
            txtrason.Size = new Size(635, 108);
            txtrason.TabIndex = 0;
            // 
            // BtnAgendar
            // 
            BtnAgendar.Anchor = AnchorStyles.Top;
            BtnAgendar.BackColor = Color.FromArgb(127, 164, 201);
            BtnAgendar.FlatStyle = FlatStyle.Flat;
            BtnAgendar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgendar.ForeColor = SystemColors.ActiveCaptionText;
            BtnAgendar.Location = new Point(634, 378);
            BtnAgendar.Margin = new Padding(3, 4, 3, 4);
            BtnAgendar.Name = "BtnAgendar";
            BtnAgendar.Size = new Size(160, 47);
            BtnAgendar.TabIndex = 10;
            BtnAgendar.Text = "Agendar Cita";
            BtnAgendar.UseVisualStyleBackColor = false;
            BtnAgendar.Click += BtnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(204, 378);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 47);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAddApointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 597);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddApointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddApointment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Label label5;
        private Panel panel3;
        private TextBox txtrason;
        private Button BtnAgendar;
        private Button btnCancelar;
        private ComboBox CmbSeleccionarPaciente;
    }
}