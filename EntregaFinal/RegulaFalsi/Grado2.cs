using System;
using System.Windows.Forms;

namespace EntregaFinal.RegulaFalsi
{
    public partial class Grado2 : Form
    {
        public Grado2()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;
        }

        public Grado2(string funcion) : this()
        {
            lblFuncionRecibida.Text = funcion;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double a = 0, a1 = 0, a2 = 0;

            // Validar y convertir txta1 (término independiente)
            if (!string.IsNullOrWhiteSpace(txta1.Text) && !double.TryParse(txta1.Text, out a))
            {
                MessageBox.Show("El término independiente debe ser un número válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar y convertir txta2 (coeficiente de x)
            if (!string.IsNullOrWhiteSpace(txta2.Text) && !double.TryParse(txta2.Text, out a1))
            {
                MessageBox.Show("El coeficiente de x debe ser un número válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar y convertir txta3 (coeficiente de x²)
            if (!string.IsNullOrWhiteSpace(txta3.Text) && !double.TryParse(txta3.Text, out a2))
            {
                MessageBox.Show("El coeficiente de x² debe ser un número válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que no estén todos en 0
            if (a == 0 && a1 == 0 && a2 == 0)
            {
                MessageBox.Show("La función no puede ser 0 en todos los términos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que al menos a1 o a2 tengan valor
            if (a1 == 0 && a2 == 0)
            {
                MessageBox.Show("La función debe tener al menos un término con x o x².", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar paneles si pasa validaciones
            panel3.Visible = true;
            panel4.Visible = true;

            // Construir la expresión formateada
            string resultado = "";

            if (a2 != 0)
                resultado += (a2 == 1 ? "x²" : a2 == -1 ? "-x²" : a2.ToString("0.##") + "x²");

            if (a1 != 0)
            {
                if (resultado != "")
                    resultado += (a1 > 0 ? " + " : " - ");
                resultado += (Math.Abs(a1) == 1 ? "x" : Math.Abs(a1).ToString("0.##") + "x");
            }

            if (a != 0)
            {
                if (resultado != "")
                    resultado += (a > 0 ? " + " : " - ");
                resultado += Math.Abs(a).ToString("0.##");
            }

            lblResultado.Text = resultado == "" ? "0" : resultado;
        }

        private void lblLimpiar1_Click(object sender, EventArgs e)
        {
            txta1.Clear();
            txta2.Clear();
            txta3.Clear();
            lblResultado.Text = "Inserta de nuevo";
        }

        private void lblLimpiar2_Click(object sender, EventArgs e)
        {
            txtL1.Clear();
            txtL2.Clear();
        }

        private void btnContinuar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtL1.Text) || string.IsNullOrWhiteSpace(txtL2.Text))
            {
                MessageBox.Show("Debes ingresar los límites (L1 y L2).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtL1.Text, out double l1) || !double.TryParse(txtL2.Text, out double l2))
            {
                MessageBox.Show("Los límites deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double a = double.TryParse(txta1.Text, out double ta) ? ta : 0;
            double a1 = double.TryParse(txta2.Text, out double ta1) ? ta1 : 0;
            double a2 = double.TryParse(txta3.Text, out double ta2) ? ta2 : 0;

            // Pasar valores a Soluciones
            Soluciones solForm = new Soluciones(lblResultado.Text, lblFuncionRecibida.Text, a, a1, a2, l1, l2);
            solForm.Show();
            this.Hide();
        }
    }
}
