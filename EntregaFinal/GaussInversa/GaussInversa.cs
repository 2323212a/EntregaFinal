using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFinal
{
    public partial class GaussInversa : Form
    {
        public GaussInversa()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => VolverMenu();
        }
        private void VolverMenu()
        {
            var menu = new MainMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
            this.Hide();
        }
        private void btnmatriz2x2_Click(object sender, EventArgs e)
        {
            this.Hide();
            matriz2x2 form = new matriz2x2();
            form.ShowDialog();
            this.Close();
        }

        private void btnmatriz3x3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            matrz3x3 form = new matrz3x3();
            form.ShowDialog();
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GaussInversa_Load(object sender, EventArgs e)
        {

        }
    }
}
