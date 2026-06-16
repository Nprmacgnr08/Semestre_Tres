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
            panel2 = new Panel();
            btnentrar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            txtclave = new TextBox();
            TxtUser = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 650);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnentrar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(txtclave);
            panel2.Controls.Add(TxtUser);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(162, 150);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(22, 19, 22, 19);
            panel2.Size = new Size(312, 416);
            panel2.TabIndex = 9;
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.PaleTurquoise;
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnentrar.ForeColor = SystemColors.ActiveCaptionText;
            btnentrar.Location = new Point(83, 350);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(129, 37);
            btnentrar.TabIndex = 7;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Clinica_Dental_Integral_Guadalupe_Logo1;
            pictureBox1.Location = new Point(83, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 104);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "Inicia Sesión";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(188, 284);
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
            txtclave.Location = new Point(76, 240);
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
            TxtUser.Location = new Point(76, 162);
            TxtUser.Name = "TxtUser";
            TxtUser.PlaceholderText = "Ingrese su usuario";
            TxtUser.Size = new Size(204, 33);
            TxtUser.TabIndex = 4;
            TxtUser.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.key_password_lock_800;
            pictureBox3.Location = new Point(13, 228);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bootloader_users_person_people_6080;
            pictureBox2.Location = new Point(13, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Right;
            pictureBox4.Image = Properties.Resources.Clinica_Dental_Integral_Guadalupe_Logo;
            pictureBox4.Location = new Point(642, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(388, 650);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 225, 235);
            ClientSize = new Size(1030, 650);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox4;
        private Panel panel2;
    }
}