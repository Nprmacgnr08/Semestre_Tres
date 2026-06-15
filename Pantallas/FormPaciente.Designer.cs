namespace Semestre_Tres.Pantallas
{
    partial class FormPaciente
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
            btnagregar = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            btnEliminar = new Button();
            btneditar = new Button();
            BtnVer = new Button();
            dtgpaciente = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColIdCard = new DataGridViewTextBoxColumn();
            ColPhone = new DataGridViewTextBoxColumn();
            ColBirthdate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgpaciente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnagregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 91);
            panel1.TabIndex = 0;
            // 
            // btnagregar
            // 
            btnagregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregar.BackColor = Color.FromArgb(127, 164, 201);
            btnagregar.Cursor = Cursors.Hand;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnagregar.Image = Properties.Resources._269362_plus_icon;
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(770, 23);
            btnagregar.Margin = new Padding(5);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(241, 51);
            btnagregar.TabIndex = 2;
            btnagregar.Text = "Nuevo Paciente";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.magnifying_glass_search_icon_208829;
            pictureBox1.Location = new Point(614, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(27, 27);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por cédula";
            textBox1.Size = new Size(581, 42);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btneditar);
            panel2.Controls.Add(BtnVer);
            panel2.Controls.Add(dtgpaciente);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 91);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1039, 509);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(848, 345);
            btnEliminar.Margin = new Padding(0, 0, 0, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 53);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = SystemColors.ActiveCaption;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneditar.Location = new Point(848, 195);
            btneditar.Margin = new Padding(5);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(114, 53);
            btneditar.TabIndex = 2;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // BtnVer
            // 
            BtnVer.Anchor = AnchorStyles.Right;
            BtnVer.BackColor = SystemColors.ActiveCaption;
            BtnVer.FlatStyle = FlatStyle.Flat;
            BtnVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVer.Location = new Point(848, 46);
            BtnVer.Margin = new Padding(5);
            BtnVer.Name = "BtnVer";
            BtnVer.Size = new Size(114, 53);
            BtnVer.TabIndex = 1;
            BtnVer.Text = "Ver";
            BtnVer.UseVisualStyleBackColor = false;
            BtnVer.Click += BtnVer_Click;
            // 
            // dtgpaciente
            // 
            dtgpaciente.AllowUserToAddRows = false;
            dtgpaciente.AllowUserToResizeRows = false;
            dtgpaciente.BackgroundColor = Color.Beige;
            dtgpaciente.BorderStyle = BorderStyle.None;
            dtgpaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgpaciente.Columns.AddRange(new DataGridViewColumn[] { ColID, ColName, ColIdCard, ColPhone, ColBirthdate });
            dtgpaciente.Location = new Point(51, 35);
            dtgpaciente.Margin = new Padding(10);
            dtgpaciente.Name = "dtgpaciente";
            dtgpaciente.ReadOnly = true;
            dtgpaciente.RowHeadersVisible = false;
            dtgpaciente.RowHeadersWidth = 51;
            dtgpaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgpaciente.Size = new Size(557, 408);
            dtgpaciente.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.FillWeight = 50F;
            ColID.HeaderText = "Id";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Width = 50;
            // 
            // ColName
            // 
            ColName.HeaderText = "Nombre";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            ColName.Width = 125;
            // 
            // ColIdCard
            // 
            ColIdCard.HeaderText = "Cédula";
            ColIdCard.MinimumWidth = 6;
            ColIdCard.Name = "ColIdCard";
            ColIdCard.ReadOnly = true;
            ColIdCard.Width = 125;
            // 
            // ColPhone
            // 
            ColPhone.HeaderText = "Teléfono";
            ColPhone.MinimumWidth = 6;
            ColPhone.Name = "ColPhone";
            ColPhone.ReadOnly = true;
            ColPhone.Width = 125;
            // 
            // ColBirthdate
            // 
            ColBirthdate.HeaderText = "Nacimiento";
            ColBirthdate.MinimumWidth = 6;
            ColBirthdate.Name = "ColBirthdate";
            ColBirthdate.ReadOnly = true;
            ColBirthdate.Width = 125;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPaciente";
            Text = "FormPaciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgpaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnagregar;
        private Panel panel2;
        private DataGridView dtgpaciente;
        private Button btnEliminar;
        private Button btneditar;
        private Button BtnVer;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColIdCard;
        private DataGridViewTextBoxColumn ColPhone;
        private DataGridViewTextBoxColumn ColBirthdate;
    }
}