using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestre_Tres.Pantallas
{
    public partial class FormRol : Form
    {
        public FormRol()
        {
            InitializeComponent();

            btnadmin.MouseEnter += (s, e) => btnadmin.BackColor = Color.LightBlue;
            btnadmin.MouseLeave += (s, e) => btnadmin.BackColor = SystemColors.Control;

            btnmedico.MouseEnter += (s, e) => btnmedico.BackColor = Color.LightBlue;
            btnmedico.MouseLeave += (s, e) => btnmedico.BackColor = SystemColors.Control;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmedico_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();

        }
    }
}
