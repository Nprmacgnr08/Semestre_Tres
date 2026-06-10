namespace Semestre_Tres.Pantallas
{
    partial class FormEditPatient
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
            label3 = new Label();
            txtLastname = new TextBox();
            txtphone = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtname = new TextBox();
            label4 = new Label();
            mtbidcard = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            mtbbirthdate = new MaskedTextBox();
            txtgmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtadrees = new TextBox();
            comboxgander = new ComboBox();
            btncancelar = new Button();
            btnguardar = new Button();
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
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x_icon_150997;
            pictureBox1.Location = new Point(1331, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 34);
            label1.Name = "label1";
            label1.Size = new Size(211, 40);
            label1.TabIndex = 0;
            label1.Text = "Editar Paciente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(216, 225, 235);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
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
            tableLayoutPanel1.Controls.Add(btnguardar, 2, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(800, 350);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(403, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 1;
            label3.Text = "Apellidos*";
            // 
            // txtLastname
            // 
            txtLastname.Anchor = AnchorStyles.Top;
            txtLastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(449, 38);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(251, 33);
            txtLastname.TabIndex = 18;
            // 
            // txtphone
            // 
            txtphone.Anchor = AnchorStyles.Top;
            txtphone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtphone.Location = new Point(449, 108);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(251, 33);
            txtphone.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(403, 70);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 22;
            label5.Text = "Teléfono*";
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
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Top;
            txtname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(99, 38);
            txtname.Name = "txtname";
            txtname.Size = new Size(251, 33);
            txtname.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 70);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 19;
            label4.Text = "Cédula*";
            // 
            // mtbidcard
            // 
            mtbidcard.Anchor = AnchorStyles.Top;
            mtbidcard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbidcard.Location = new Point(101, 108);
            mtbidcard.Mask = "000-000000-0000L";
            mtbidcard.Name = "mtbidcard";
            mtbidcard.Size = new Size(248, 33);
            mtbidcard.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 140);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 23;
            label6.Text = "Nacimiento*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(403, 140);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 24;
            label7.Text = "Email*";
            // 
            // mtbbirthdate
            // 
            mtbbirthdate.Anchor = AnchorStyles.Top;
            mtbbirthdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbbirthdate.Location = new Point(101, 178);
            mtbbirthdate.Mask = "00/00/0000";
            mtbbirthdate.Name = "mtbbirthdate";
            mtbbirthdate.Size = new Size(248, 33);
            mtbbirthdate.TabIndex = 25;
            mtbbirthdate.ValidatingType = typeof(DateTime);
            // 
            // txtgmail
            // 
            txtgmail.Anchor = AnchorStyles.Top;
            txtgmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtgmail.Location = new Point(449, 178);
            txtgmail.Name = "txtgmail";
            txtgmail.Size = new Size(251, 33);
            txtgmail.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 210);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 27;
            label8.Text = "Dirección*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(403, 210);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 28;
            label9.Text = "Género*";
            // 
            // txtadrees
            // 
            txtadrees.Anchor = AnchorStyles.Top;
            txtadrees.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadrees.Location = new Point(99, 248);
            txtadrees.Name = "txtadrees";
            txtadrees.Size = new Size(251, 33);
            txtadrees.TabIndex = 29;
            // 
            // comboxgander
            // 
            comboxgander.Anchor = AnchorStyles.Top;
            comboxgander.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboxgander.FormattingEnabled = true;
            comboxgander.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboxgander.Location = new Point(449, 248);
            comboxgander.Name = "comboxgander";
            comboxgander.Size = new Size(252, 33);
            comboxgander.TabIndex = 30;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.Top;
            btncancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancelar.Location = new Point(145, 283);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(160, 35);
            btncancelar.TabIndex = 31;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnguardar
            // 
            btnguardar.Anchor = AnchorStyles.Top;
            btnguardar.BackColor = Color.FromArgb(127, 164, 201);
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(495, 283);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(160, 35);
            btnguardar.TabIndex = 32;
            btnguardar.Text = "Guardar Cambios";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // FormEditPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditPatient";
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TextBox txtLastname;
        private TextBox txtphone;
        private Label label5;
        private Label label2;
        private TextBox txtname;
        private Label label4;
        private MaskedTextBox mtbidcard;
        private Label label6;
        private Label label7;
        private MaskedTextBox mtbbirthdate;
        private TextBox txtgmail;
        private Label label8;
        private Label label9;
        private TextBox txtadrees;
        private ComboBox comboxgander;
        private Button btncancelar;
        private Button btnguardar;
    }
}