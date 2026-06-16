namespace Semestre_Tres.Pantallas
{
    partial class FormAddTratamiento
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
            TxtDescripcionpro = new TextBox();
            label2 = new Label();
            txtprocedimineto = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            txtduracion = new TextBox();
            txtcosto = new TextBox();
            btnGuardar = new Button();
            btncancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            panel1.Size = new Size(723, 74);
            panel1.TabIndex = 1;
            // 
            // picSalir
            // 
            picSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSalir.Image = Properties.Resources.x_icon_150997;
            picSalir.Location = new Point(637, 24);
            picSalir.Name = "picSalir";
            picSalir.Size = new Size(35, 35);
            picSalir.SizeMode = PictureBoxSizeMode.Zoom;
            picSalir.TabIndex = 4;
            picSalir.TabStop = false;
            picSalir.Click += picSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x_icon_150997;
            pictureBox1.Location = new Point(1138, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(207, 24);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Tratamiento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDescripcionpro
            // 
            TxtDescripcionpro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescripcionpro.Location = new Point(33, 95);
            TxtDescripcionpro.Multiline = true;
            TxtDescripcionpro.Name = "TxtDescripcionpro";
            TxtDescripcionpro.PlaceholderText = "Descripción detallada del tratamirnto";
            TxtDescripcionpro.ScrollBars = ScrollBars.Horizontal;
            TxtDescripcionpro.Size = new Size(555, 63);
            TxtDescripcionpro.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre del procedimiento*";
            // 
            // txtprocedimineto
            // 
            txtprocedimineto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprocedimineto.Location = new Point(33, 31);
            txtprocedimineto.Name = "txtprocedimineto";
            txtprocedimineto.PlaceholderText = "Ej: Endodoncia";
            txtprocedimineto.Size = new Size(243, 25);
            txtprocedimineto.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 654F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Controls.Add(txtprocedimineto, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(TxtDescripcionpro, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 74);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.79105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.2089539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(723, 326);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 67);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 2;
            label3.Text = "Descripción*";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(txtduracion, 0, 1);
            tableLayoutPanel2.Controls.Add(txtcosto, 1, 1);
            tableLayoutPanel2.Controls.Add(btnGuardar, 1, 3);
            tableLayoutPanel2.Controls.Add(btncancelar, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(33, 184);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.6140366F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.3859634F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(648, 139);
            tableLayoutPanel2.TabIndex = 4;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(327, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 4;
            label5.Text = "Costo*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 3;
            label4.Text = "Duración*";
            // 
            // txtduracion
            // 
            txtduracion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtduracion.Location = new Point(3, 29);
            txtduracion.Name = "txtduracion";
            txtduracion.PlaceholderText = "Ej: 45min";
            txtduracion.Size = new Size(100, 25);
            txtduracion.TabIndex = 5;
            // 
            // txtcosto
            // 
            txtcosto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcosto.Location = new Point(327, 29);
            txtcosto.Name = "txtcosto";
            txtcosto.PlaceholderText = "00.00";
            txtcosto.Size = new Size(100, 25);
            txtcosto.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.FromArgb(127, 164, 201);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(406, 98);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 35);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar ";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Top;
            btncancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancelar.Location = new Point(82, 98);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 35);
            btncancelar.TabIndex = 32;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // FormAddTratamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 400);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddTratamiento";
            Text = "FormAddTratamiento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picSalir;
        private TextBox TxtDescripcionpro;
        private Label label2;
        private TextBox txtprocedimineto;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label4;
        private TextBox txtduracion;
        private TextBox txtcosto;
        private Button btnGuardar;
        private Button btncancelar;
    }
}