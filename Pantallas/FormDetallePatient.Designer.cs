namespace Semestre_Tres.Pantallas
{
    partial class FormDetallePatient
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
            label3 = new Label();
            LblName = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            LblLastname = new Label();
            LblIdcard = new Label();
            LblPhone = new Label();
            LblBirthDate = new Label();
            LblGmail = new Label();
            LblAdrees = new Label();
            LblGender = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 44);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.x_icon_150997;
            pictureBox1.Location = new Point(970, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(364, 6);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Detalles del paciente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 459F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 389F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(LblName, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 2, 2);
            tableLayoutPanel1.Controls.Add(label6, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 2, 4);
            tableLayoutPanel1.Controls.Add(label8, 1, 6);
            tableLayoutPanel1.Controls.Add(label9, 2, 6);
            tableLayoutPanel1.Controls.Add(LblLastname, 2, 1);
            tableLayoutPanel1.Controls.Add(LblIdcard, 1, 3);
            tableLayoutPanel1.Controls.Add(LblPhone, 2, 3);
            tableLayoutPanel1.Controls.Add(LblBirthDate, 1, 5);
            tableLayoutPanel1.Controls.Add(LblGmail, 2, 5);
            tableLayoutPanel1.Controls.Add(LblAdrees, 1, 7);
            tableLayoutPanel1.Controls.Add(LblGender, 2, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499176F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5016727F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.50328F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1030, 606);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(522, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 1;
            label3.Text = "Apellido*";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Dock = DockStyle.Left;
            LblName.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblName.ForeColor = Color.FromArgb(64, 64, 64);
            LblName.Location = new Point(63, 75);
            LblName.Name = "LblName";
            LblName.Size = new Size(0, 75);
            LblName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 150);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 3;
            label4.Text = "Cédula*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(522, 150);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 4;
            label5.Text = "Teléfono*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(63, 300);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 5;
            label6.Text = "Nacimiento*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(522, 300);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 6;
            label7.Text = "Email*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(63, 450);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 7;
            label8.Text = "Dirección*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(522, 450);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 8;
            label9.Text = "Género*";
            // 
            // LblLastname
            // 
            LblLastname.AutoSize = true;
            LblLastname.Dock = DockStyle.Left;
            LblLastname.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblLastname.ForeColor = Color.FromArgb(64, 64, 64);
            LblLastname.Location = new Point(522, 75);
            LblLastname.Name = "LblLastname";
            LblLastname.Size = new Size(0, 75);
            LblLastname.TabIndex = 9;
            // 
            // LblIdcard
            // 
            LblIdcard.AutoSize = true;
            LblIdcard.Dock = DockStyle.Left;
            LblIdcard.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblIdcard.ForeColor = Color.FromArgb(64, 64, 64);
            LblIdcard.Location = new Point(63, 225);
            LblIdcard.Name = "LblIdcard";
            LblIdcard.Size = new Size(0, 75);
            LblIdcard.TabIndex = 10;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Dock = DockStyle.Left;
            LblPhone.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPhone.ForeColor = Color.FromArgb(64, 64, 64);
            LblPhone.Location = new Point(522, 225);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(0, 75);
            LblPhone.TabIndex = 11;
            // 
            // LblBirthDate
            // 
            LblBirthDate.AutoSize = true;
            LblBirthDate.Dock = DockStyle.Left;
            LblBirthDate.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblBirthDate.ForeColor = Color.FromArgb(64, 64, 64);
            LblBirthDate.Location = new Point(63, 375);
            LblBirthDate.Name = "LblBirthDate";
            LblBirthDate.Size = new Size(0, 75);
            LblBirthDate.TabIndex = 12;
            // 
            // LblGmail
            // 
            LblGmail.AutoSize = true;
            LblGmail.Dock = DockStyle.Left;
            LblGmail.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblGmail.ForeColor = Color.FromArgb(64, 64, 64);
            LblGmail.Location = new Point(522, 375);
            LblGmail.Name = "LblGmail";
            LblGmail.Size = new Size(0, 75);
            LblGmail.TabIndex = 13;
            // 
            // LblAdrees
            // 
            LblAdrees.AutoSize = true;
            LblAdrees.Dock = DockStyle.Left;
            LblAdrees.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAdrees.ForeColor = Color.FromArgb(64, 64, 64);
            LblAdrees.Location = new Point(63, 525);
            LblAdrees.Name = "LblAdrees";
            LblAdrees.Size = new Size(0, 81);
            LblAdrees.TabIndex = 14;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Dock = DockStyle.Left;
            LblGender.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblGender.ForeColor = Color.FromArgb(64, 64, 64);
            LblGender.Location = new Point(522, 525);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(0, 81);
            LblGender.TabIndex = 15;
            // 
            // FormDetallePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 650);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetallePatient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalles del paciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label LblName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label LblIdcard;
        private Label LblLastname;
        private PictureBox pictureBox1;
        private Label LblPhone;
        private Label LblBirthDate;
        private Label LblGmail;
        private Label LblAdrees;
        private Label LblGender;
    }
}