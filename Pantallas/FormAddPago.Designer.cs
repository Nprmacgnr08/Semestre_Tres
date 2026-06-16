namespace Semestre_Tres.Pantallas
{
    partial class FormAddPago
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
            picSalir = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            TxtMonto = new TextBox();
            cmbmoneda = new ComboBox();
            label6 = new Label();
            cmbmetodo = new ComboBox();
            panel2 = new Panel();
            btnGuardar = new Button();
            btncancelar = new Button();
            cmbtratamiento = new ComboBox();
            cmbpaciente = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(picSalir);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 99);
            panel1.TabIndex = 1;
            // 
            // picSalir
            // 
            picSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSalir.Image = Properties.Resources.x_icon_150997;
            picSalir.Location = new Point(932, 32);
            picSalir.Margin = new Padding(3, 4, 3, 4);
            picSalir.Name = "picSalir";
            picSalir.Size = new Size(40, 47);
            picSalir.SizeMode = PictureBoxSizeMode.Zoom;
            picSalir.TabIndex = 3;
            picSalir.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x_icon_150997;
            pictureBox1.Location = new Point(1503, 32);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(375, 25);
            label1.Name = "label1";
            label1.Size = new Size(253, 54);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Pago";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 906F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(cmbmetodo, 1, 6);
            tableLayoutPanel1.Controls.Add(panel2, 1, 7);
            tableLayoutPanel1.Controls.Add(cmbtratamiento, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbpaciente, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 99);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1029, 434);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 0;
            label2.Text = "Paciente*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 82);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 2;
            label3.Text = "Tratamiento*";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0875664F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9124336F));
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(TxtMonto, 0, 1);
            tableLayoutPanel2.Controls.Add(cmbmoneda, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(61, 179);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            tableLayoutPanel2.Size = new Size(900, 80);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(453, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 4;
            label5.Text = "Moneda*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 3;
            label4.Text = "Monto*";
            // 
            // TxtMonto
            // 
            TxtMonto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMonto.Location = new Point(3, 39);
            TxtMonto.Margin = new Padding(3, 4, 3, 4);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.PlaceholderText = "00.00";
            TxtMonto.Size = new Size(222, 32);
            TxtMonto.TabIndex = 5;
            // 
            // cmbmoneda
            // 
            cmbmoneda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmoneda.FormattingEnabled = true;
            cmbmoneda.Items.AddRange(new object[] { "Córdobas", "Dólares" });
            cmbmoneda.Location = new Point(453, 39);
            cmbmoneda.Margin = new Padding(3, 4, 3, 4);
            cmbmoneda.Name = "cmbmoneda";
            cmbmoneda.Size = new Size(222, 33);
            cmbmoneda.TabIndex = 6;
            cmbmoneda.SelectedIndexChanged += cmbmoneda_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 263);
            label6.Name = "label6";
            label6.Size = new Size(169, 28);
            label6.TabIndex = 5;
            label6.Text = "Método de pago*";
            // 
            // cmbmetodo
            // 
            cmbmetodo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmetodo.FormattingEnabled = true;
            cmbmetodo.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencias" });
            cmbmetodo.Location = new Point(61, 306);
            cmbmetodo.Margin = new Padding(3, 4, 3, 4);
            cmbmetodo.Name = "cmbmetodo";
            cmbmetodo.Size = new Size(349, 33);
            cmbmetodo.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btncancelar);
            panel2.Location = new Point(61, 361);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 69);
            panel2.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(127, 164, 201);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(359, 4);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(194, 47);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar Pago";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancelar.Location = new Point(88, 7);
            btncancelar.Margin = new Padding(3, 4, 3, 4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(194, 47);
            btncancelar.TabIndex = 0;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // cmbtratamiento
            // 
            cmbtratamiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbtratamiento.FormattingEnabled = true;
            cmbtratamiento.Location = new Point(61, 126);
            cmbtratamiento.Margin = new Padding(3, 4, 3, 4);
            cmbtratamiento.Name = "cmbtratamiento";
            cmbtratamiento.Size = new Size(349, 33);
            cmbtratamiento.TabIndex = 8;
            cmbtratamiento.SelectedIndexChanged += cmbtratamiento_SelectedIndexChanged;
            // 
            // cmbpaciente
            // 
            cmbpaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbpaciente.FormattingEnabled = true;
            cmbpaciente.Location = new Point(61, 37);
            cmbpaciente.Margin = new Padding(3, 4, 3, 4);
            cmbpaciente.Name = "cmbpaciente";
            cmbpaciente.Size = new Size(349, 36);
            cmbpaciente.TabIndex = 9;
            // 
            // FormAddPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 533);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddPago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picSalir;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox TxtPaciente;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label4;
        private TextBox TxtMonto;
        private ComboBox cmbmoneda;
     
        private Label label6;
        private ComboBox cmbmetodo;
        private Panel panel2;
        private Button btnGuardar;
        private Button btncancelar;
        private ComboBox cmbtratamiento;
        private ComboBox cmbpaciente;
    }
}