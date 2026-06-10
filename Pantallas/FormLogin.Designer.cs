namespace Semestre_Tres.Pantallas
{
    partial class FormLogin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtclave = new TextBox();
            btnentrar = new Button();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtUser = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9954815F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7201567F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.32094F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 312F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 5);
            tableLayoutPanel1.Controls.Add(txtclave, 2, 5);
            tableLayoutPanel1.Controls.Add(btnentrar, 2, 7);
            tableLayoutPanel1.Controls.Add(checkBox1, 2, 6);
            tableLayoutPanel1.Controls.Add(panel1, 3, 0);
            tableLayoutPanel1.Controls.Add(txtUser, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0493832F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.99177F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6872425F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6337452F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.63786F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bootloader_users_person_people_6080;
            pictureBox1.Location = new Point(56, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 51, 51);
            label1.Location = new Point(211, 39);
            label1.Name = "label1";
            label1.Size = new Size(179, 34);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key_password_lock_800;
            pictureBox2.Location = new Point(56, 246);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtclave
            // 
            txtclave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtclave.BackColor = SystemColors.Control;
            txtclave.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtclave.Location = new Point(118, 271);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.PlaceholderText = "Ingrese su código";
            txtclave.Size = new Size(296, 29);
            txtclave.TabIndex = 5;
            txtclave.UseSystemPasswordChar = true;
            txtclave.TextChanged += txtclave_TextChanged;
            // 
            // btnentrar
            // 
            btnentrar.Anchor = AnchorStyles.Top;
            btnentrar.BackColor = Color.FromArgb(216, 225, 235);
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnentrar.Location = new Point(237, 361);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(127, 35);
            btnentrar.TabIndex = 3;
            btnentrar.Text = "Ingresar";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(356, 306);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(216, 225, 235);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(490, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 9);
            panel1.Size = new Size(307, 444);
            panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.Clinica_Dental_Integral_Guadalupe_Logo;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 444);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtUser.BackColor = SystemColors.Control;
            txtUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(118, 179);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Ingrese su usuario";
            txtUser.Size = new Size(296, 23);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUser;
        private Button btnentrar;
        private TextBox txtclave;
        private CheckBox checkBox1;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}