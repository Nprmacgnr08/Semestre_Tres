namespace Semestre_Tres.Pantallas
{
    partial class FormMenuAdmin
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
            panelMenu = new Panel();
            btnsalir = new Button();
            btntratamiento = new Button();
            btnpago = new Button();
            btncitas = new Button();
            btnPaciente = new Button();
            btnmenu = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnltop = new Panel();
            LblSubtitulo = new Label();
            LblTitulo = new Label();
            pnlcontenedor = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnltop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(216, 225, 235);
            panelMenu.Controls.Add(btnsalir);
            panelMenu.Controls.Add(btntratamiento);
            panelMenu.Controls.Add(btnpago);
            panelMenu.Controls.Add(btncitas);
            panelMenu.Controls.Add(btnPaciente);
            panelMenu.Controls.Add(btnmenu);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnsalir
            // 
            btnsalir.Dock = DockStyle.Bottom;
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.FromArgb(51, 51, 51);
            btnsalir.Image = Properties.Resources.entry_door_open_exit_icon_208826;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(0, 405);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(220, 45);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "Cerrar Sesión";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += BotonMenu;
            // 
            // btntratamiento
            // 
            btntratamiento.Dock = DockStyle.Top;
            btntratamiento.FlatAppearance.BorderSize = 0;
            btntratamiento.FlatStyle = FlatStyle.Flat;
            btntratamiento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntratamiento.ForeColor = Color.FromArgb(51, 51, 51);
            btntratamiento.Image = Properties.Resources.link_chain_attach_icon_261456;
            btntratamiento.ImageAlign = ContentAlignment.MiddleLeft;
            btntratamiento.Location = new Point(0, 280);
            btntratamiento.Name = "btntratamiento";
            btntratamiento.Size = new Size(220, 45);
            btntratamiento.TabIndex = 6;
            btntratamiento.Text = "Tratamiento";
            btntratamiento.UseVisualStyleBackColor = true;
            btntratamiento.Click += BotonMenu;
            // 
            // btnpago
            // 
            btnpago.Dock = DockStyle.Top;
            btnpago.FlatAppearance.BorderSize = 0;
            btnpago.FlatStyle = FlatStyle.Flat;
            btnpago.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpago.ForeColor = Color.FromArgb(51, 51, 51);
            btnpago.Image = Properties.Resources.pay_payment_bill_dollar_cash_icon_143281;
            btnpago.ImageAlign = ContentAlignment.MiddleLeft;
            btnpago.Location = new Point(0, 235);
            btnpago.Name = "btnpago";
            btnpago.Size = new Size(220, 45);
            btnpago.TabIndex = 5;
            btnpago.Text = "Pagos";
            btnpago.UseVisualStyleBackColor = true;
            btnpago.Click += BotonMenu;
            // 
            // btncitas
            // 
            btncitas.Dock = DockStyle.Top;
            btncitas.FlatAppearance.BorderSize = 0;
            btncitas.FlatStyle = FlatStyle.Flat;
            btncitas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncitas.ForeColor = Color.FromArgb(51, 51, 51);
            btncitas.Image = Properties.Resources._269333_calendar_icon;
            btncitas.ImageAlign = ContentAlignment.MiddleLeft;
            btncitas.Location = new Point(0, 190);
            btncitas.Name = "btncitas";
            btncitas.Size = new Size(220, 45);
            btncitas.TabIndex = 4;
            btncitas.Text = "Citas";
            btncitas.UseVisualStyleBackColor = true;
            btncitas.Click += BotonMenu;
            // 
            // btnPaciente
            // 
            btnPaciente.Dock = DockStyle.Top;
            btnPaciente.FlatAppearance.BorderSize = 0;
            btnPaciente.FlatStyle = FlatStyle.Flat;
            btnPaciente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaciente.ForeColor = Color.FromArgb(51, 51, 51);
            btnPaciente.Image = Properties.Resources._4105943_accounts_group_people_user_user_group_users_113923;
            btnPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaciente.Location = new Point(0, 145);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(220, 45);
            btnPaciente.TabIndex = 3;
            btnPaciente.Text = "Pacientes";
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Click += BotonMenu;
            // 
            // btnmenu
            // 
            btnmenu.Dock = DockStyle.Top;
            btnmenu.FlatAppearance.BorderSize = 0;
            btnmenu.FlatStyle = FlatStyle.Flat;
            btnmenu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenu.ForeColor = Color.FromArgb(51, 51, 51);
            btnmenu.Image = Properties.Resources.home_house_icon_icons_com_49851;
            btnmenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnmenu.Location = new Point(0, 100);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(220, 45);
            btnmenu.TabIndex = 2;
            btnmenu.Text = "Dashboard";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += BotonMenu;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.double_arrow_horizontal_symbol_icon_icons_com_73277;
            pictureBox2.Location = new Point(184, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Clinica_Dental_Integral_Guadalupe_Logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnltop
            // 
            pnltop.BackColor = Color.FromArgb(216, 225, 235);
            pnltop.Controls.Add(LblSubtitulo);
            pnltop.Controls.Add(LblTitulo);
            pnltop.Dock = DockStyle.Top;
            pnltop.Location = new Point(220, 0);
            pnltop.Name = "pnltop";
            pnltop.Size = new Size(580, 100);
            pnltop.TabIndex = 1;
            pnltop.Paint += pnltop_Paint;
            // 
            // LblSubtitulo
            // 
            LblSubtitulo.AutoSize = true;
            LblSubtitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtitulo.Location = new Point(68, 67);
            LblSubtitulo.Name = "LblSubtitulo";
            LblSubtitulo.Size = new Size(0, 20);
            LblSubtitulo.TabIndex = 1;
            LblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(57, 22);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(0, 32);
            LblTitulo.TabIndex = 0;
            // 
            // pnlcontenedor
            // 
            pnlcontenedor.Dock = DockStyle.Fill;
            pnlcontenedor.Location = new Point(220, 100);
            pnlcontenedor.Name = "pnlcontenedor";
            pnlcontenedor.Size = new Size(580, 350);
            pnlcontenedor.TabIndex = 2;
            // 
            // FormMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlcontenedor);
            Controls.Add(pnltop);
            Controls.Add(panelMenu);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuAdmin";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnltop.ResumeLayout(false);
            pnltop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnmenu;
        private Button btnsalir;
        private Button btntratamiento;
        private Button btnpago;
        private Button btncitas;
        private Button btnPaciente;
        private Panel pnltop;
        private Panel pnlcontenedor;
        private Label LblSubtitulo;
        private Label LblTitulo;
    }
}