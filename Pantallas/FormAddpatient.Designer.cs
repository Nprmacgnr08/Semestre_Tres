namespace Semestre_Tres.Pantallas
{
    partial class FormAddpatient
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
            btncancelar = new Button();
            comboxgander = new ComboBox();
            txtadrees = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtgmail = new TextBox();
            mtbbirthdate = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            mtbidcard = new MaskedTextBox();
            label4 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtphone = new TextBox();
            txtLastname = new TextBox();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnagregar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x_icon_150997;
            pictureBox1.Location = new Point(960, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(404, 24);
            label1.Name = "label1";
            label1.Size = new Size(221, 40);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Paciente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Top;
            btncancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancelar.Location = new Point(194, 408);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 37);
            btncancelar.TabIndex = 31;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // comboxgander
            // 
            comboxgander.Anchor = AnchorStyles.Top;
            comboxgander.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboxgander.FormattingEnabled = true;
            comboxgander.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboxgander.Location = new Point(596, 339);
            comboxgander.Name = "comboxgander";
            comboxgander.Size = new Size(252, 33);
            comboxgander.TabIndex = 30;
            // 
            // txtadrees
            // 
            txtadrees.Anchor = AnchorStyles.Top;
            txtadrees.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadrees.Location = new Point(149, 339);
            txtadrees.Name = "txtadrees";
            txtadrees.Size = new Size(251, 33);
            txtadrees.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(502, 281);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 28;
            label9.Text = "Género*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 281);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 27;
            label8.Text = "Dirección*";
            // 
            // txtgmail
            // 
            txtgmail.Anchor = AnchorStyles.Top;
            txtgmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtgmail.Location = new Point(597, 232);
            txtgmail.Name = "txtgmail";
            txtgmail.Size = new Size(251, 33);
            txtgmail.TabIndex = 26;
            // 
            // mtbbirthdate
            // 
            mtbbirthdate.Anchor = AnchorStyles.Top;
            mtbbirthdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbbirthdate.Location = new Point(150, 232);
            mtbbirthdate.Mask = "00/00/0000";
            mtbbirthdate.Name = "mtbbirthdate";
            mtbbirthdate.Size = new Size(248, 33);
            mtbbirthdate.TabIndex = 25;
            mtbbirthdate.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(502, 178);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 24;
            label7.Text = "Email*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 178);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 23;
            label6.Text = "Nacimiento*";
            // 
            // mtbidcard
            // 
            mtbidcard.Anchor = AnchorStyles.Top;
            mtbidcard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbidcard.Location = new Point(150, 132);
            mtbidcard.Mask = "000-000000-0000L";
            mtbidcard.Name = "mtbidcard";
            mtbidcard.Size = new Size(248, 33);
            mtbidcard.TabIndex = 20;
            mtbidcard.MaskInputRejected += mtbidcard_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 85);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 19;
            label4.Text = "Cédula*";
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Top;
            txtname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(149, 45);
            txtname.Name = "txtname";
            txtname.Size = new Size(251, 33);
            txtname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 0;
            label2.Text = "Nombre*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(502, 85);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 22;
            label5.Text = "Teléfono*";
            // 
            // txtphone
            // 
            txtphone.Anchor = AnchorStyles.Top;
            txtphone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtphone.Location = new Point(597, 132);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(251, 33);
            txtphone.TabIndex = 21;
            // 
            // txtLastname
            // 
            txtLastname.Anchor = AnchorStyles.Top;
            txtLastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(597, 45);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(251, 33);
            txtLastname.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(502, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 1;
            label3.Text = "Apellidos*";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(216, 225, 235);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 449F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(txtLastname, 2, 1);
            tableLayoutPanel1.Controls.Add(txtphone, 2, 3);
            tableLayoutPanel1.Controls.Add(label5, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(txtname, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(mtbidcard, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 2, 4);
            tableLayoutPanel1.Controls.Add(mtbbirthdate, 1, 5);
            tableLayoutPanel1.Controls.Add(txtgmail, 2, 5);
            tableLayoutPanel1.Controls.Add(label8, 1, 6);
            tableLayoutPanel1.Controls.Add(label9, 2, 6);
            tableLayoutPanel1.Controls.Add(txtadrees, 1, 7);
            tableLayoutPanel1.Controls.Add(comboxgander, 2, 7);
            tableLayoutPanel1.Controls.Add(btncancelar, 1, 8);
            tableLayoutPanel1.Controls.Add(btnagregar, 2, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1030, 550);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnagregar
            // 
            btnagregar.Anchor = AnchorStyles.Top;
            btnagregar.BackColor = Color.FromArgb(127, 164, 201);
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(642, 408);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(160, 37);
            btnagregar.TabIndex = 32;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // FormAddpatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 650);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddpatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddpatient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        
        private Button btncancelar;
        private ComboBox comboxgander;
        private TextBox txtadrees;
        private Label label9;
        private Label label8;
        private TextBox txtgmail;
        private MaskedTextBox mtbbirthdate;
        private Label label7;
        private Label label6;
        private MaskedTextBox mtbidcard;
        private Label label4;
        private TextBox txtname;
        private Label label2;
        private Label label5;
        private TextBox txtphone;
        private TextBox txtLastname;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnagregar;
    }
}