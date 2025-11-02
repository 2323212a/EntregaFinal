using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFinal.Newton
{
    public partial class Newton1: Form
    {
        public Newton1()
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


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
            this.DialogResult = DialogResult.Cancel;

            // Cerramos este formulario.
            this.Close();

        }
    }
}
