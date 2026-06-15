namespace Semestre_Tres.Pantallas
{
    partial class FormRol
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnmedico = new Button();
            btnadmin = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.76923F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.23077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.Size = new Size(1032, 600);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Clinica_Dental_Integral_Guadalupe_Logo;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1026, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.0403023F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9551659F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.861599F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.00195F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.446394F));
            tableLayoutPanel2.Controls.Add(btnmedico, 1, 0);
            tableLayoutPanel2.Controls.Add(btnadmin, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 294);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1026, 222);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // btnmedico
            // 
            btnmedico.BackColor = Color.FromArgb(224, 224, 224);
            btnmedico.Cursor = Cursors.Hand;
            btnmedico.FlatStyle = FlatStyle.Flat;
            btnmedico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmedico.Image = Properties.Resources.Doctor_Female_icon_icons_com_75050;
            btnmedico.ImageAlign = ContentAlignment.TopCenter;
            btnmedico.Location = new Point(228, 4);
            btnmedico.Margin = new Padding(3, 4, 3, 4);
            btnmedico.Name = "btnmedico";
            btnmedico.Size = new Size(208, 214);
            btnmedico.TabIndex = 0;
            btnmedico.Text = "Médico";
            btnmedico.TextAlign = ContentAlignment.BottomCenter;
            btnmedico.UseVisualStyleBackColor = false;
            btnmedico.Click += btnmedico_Click;
            // 
            // btnadmin
            // 
            btnadmin.BackColor = Color.FromArgb(224, 224, 224);
            btnadmin.Cursor = Cursors.Hand;
            btnadmin.FlatStyle = FlatStyle.Flat;
            btnadmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadmin.Image = Properties.Resources.admin_person_user_man_2839;
            btnadmin.ImageAlign = ContentAlignment.TopCenter;
            btnadmin.Location = new Point(614, 4);
            btnadmin.Margin = new Padding(3, 4, 3, 4);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(219, 214);
            btnadmin.TabIndex = 1;
            btnadmin.Text = "Administrador";
            btnadmin.TextAlign = ContentAlignment.BottomCenter;
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnadmin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 554);
            label1.Name = "label1";
            label1.Size = new Size(290, 23);
            label1.TabIndex = 2;
            label1.Text = "Seleccione su rol para entrar al sistema";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 225, 235);
            ClientSize = new Size(1032, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRol";
            Text = "FormRol";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnmedico;
        private Button btnadmin;
        private Label label1;
    }
}