using System;
using System.Windows.Forms;

namespace EntregaFinal.RegulaFalsi
{
    public partial class Falsi : Form
    {
        public Falsi()
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
        private void Falsi_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar valores o configuraciones del formulario
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Ejemplo de navegación a otro formulario (como el de grados)
            Grados formGrados = new Grados();
            formGrados.Show();
            this.Hide();
        }
    }
}
