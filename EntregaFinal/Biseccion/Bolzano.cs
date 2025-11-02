using System;
using System.Windows.Forms;

namespace EntregaFinal.Biseccion
{
    public partial class Bolzano : Form
    {
        public Bolzano()
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
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Grados formGrados = new Grados();
            formGrados.Show();
            this.Hide();
        }
    }
}
