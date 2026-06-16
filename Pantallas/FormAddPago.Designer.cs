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
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 74);
            panel1.TabIndex = 1;
            // 
            // picSalir
            // 
            picSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSalir.Image = Properties.Resources.x_icon_150997;
            picSalir.Location = new Point(946, 24);
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
            pictureBox1.Location = new Point(1445, 24);
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
            label1.Location = new Point(391, 14);
            label1.Name = "label1";
            label1.Size = new Size(203, 45);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Pago";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 807F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(cmbmetodo, 1, 6);
            tableLayoutPanel1.Controls.Add(panel2, 1, 7);
            tableLayoutPanel1.Controls.Add(cmbtratamiento, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbpaciente, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 74);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1030, 576);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 0;
            label2.Text = "Paciente*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 80);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 2;
            label3.Text = "Tratamiento*";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.68914F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.31086F));
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(TxtMonto, 0, 1);
            tableLayoutPanel2.Controls.Add(cmbmoneda, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(107, 156);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.4074059F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 67.59259F));
            tableLayoutPanel2.Size = new Size(801, 108);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(393, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 4;
            label5.Text = "Moneda*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 3;
            label4.Text = "Monto*";
            // 
            // TxtMonto
            // 
            TxtMonto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMonto.Location = new Point(3, 37);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.PlaceholderText = "00.00";
            TxtMonto.Size = new Size(195, 27);
            TxtMonto.TabIndex = 5;
            // 
            // cmbmoneda
            // 
            cmbmoneda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmoneda.FormattingEnabled = true;
            cmbmoneda.Items.AddRange(new object[] { "Córdobas", "Dólares" });
            cmbmoneda.Location = new Point(393, 37);
            cmbmoneda.Name = "cmbmoneda";
            cmbmoneda.Size = new Size(195, 28);
            cmbmoneda.TabIndex = 6;
            cmbmoneda.SelectedIndexChanged += cmbmoneda_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(107, 267);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 5;
            label6.Text = "Método de pago*";
            // 
            // cmbmetodo
            // 
            cmbmetodo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmetodo.FormattingEnabled = true;
            cmbmetodo.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencias" });
            cmbmetodo.Location = new Point(107, 316);
            cmbmetodo.Name = "cmbmetodo";
            cmbmetodo.Size = new Size(306, 28);
            cmbmetodo.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btncancelar);
            panel2.Location = new Point(107, 472);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 79);
            panel2.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(127, 164, 201);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(494, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 35);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar Pago";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancelar.Location = new Point(127, 5);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(170, 35);
            btncancelar.TabIndex = 0;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // cmbtratamiento
            // 
            cmbtratamiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbtratamiento.FormattingEnabled = true;
            cmbtratamiento.Location = new Point(107, 115);
            cmbtratamiento.Name = "cmbtratamiento";
            cmbtratamiento.Size = new Size(306, 28);
            cmbtratamiento.TabIndex = 8;
            cmbtratamiento.SelectedIndexChanged += cmbtratamiento_SelectedIndexChanged;
            // 
            // cmbpaciente
            // 
            cmbpaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbpaciente.FormattingEnabled = true;
            cmbpaciente.Location = new Point(107, 39);
            cmbpaciente.Name = "cmbpaciente";
            cmbpaciente.Size = new Size(306, 29);
            cmbpaciente.TabIndex = 9;
            // 
            // FormAddPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 650);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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