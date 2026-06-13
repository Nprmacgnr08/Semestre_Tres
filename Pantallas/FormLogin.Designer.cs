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
            panel1 = new Panel();
            btnentrar = new Button();
            checkBox1 = new CheckBox();
            txtclave = new TextBox();
            TxtUser = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnentrar);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtclave);
            panel1.Controls.Add(TxtUser);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(246, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 390);
            panel1.TabIndex = 0;
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.FromArgb(216, 220, 230);
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnentrar.ForeColor = SystemColors.Desktop;
            btnentrar.Location = new Point(82, 340);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(129, 37);
            btnentrar.TabIndex = 7;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(176, 304);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Ver contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtclave
            // 
            txtclave.Cursor = Cursors.IBeam;
            txtclave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtclave.Location = new Point(75, 265);
            txtclave.Name = "txtclave";
            txtclave.PlaceholderText = "Ingrese su contraseña";
            txtclave.Size = new Size(204, 33);
            txtclave.TabIndex = 5;
            txtclave.UseWaitCursor = true;
            // 
            // TxtUser
            // 
            TxtUser.Cursor = Cursors.IBeam;
            TxtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUser.Location = new Point(75, 186);
            TxtUser.Name = "TxtUser";
            TxtUser.PlaceholderText = "Ingrese su usuario";
            TxtUser.Size = new Size(204, 33);
            TxtUser.TabIndex = 4;
            TxtUser.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.key_password_lock_800;
            pictureBox3.Location = new Point(15, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bootloader_users_person_people_6080;
            pictureBox2.Location = new Point(15, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 118);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "Inicia Sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Clinica_Dental_Integral_Guadalupe_Logo1;
            pictureBox1.Location = new Point(75, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 225, 235);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox TxtUser;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnentrar;
        private CheckBox checkBox1;
        private TextBox txtclave;
    }
}