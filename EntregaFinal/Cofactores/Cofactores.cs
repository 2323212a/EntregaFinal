using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFinal
{
    public partial class Cofactores : Form
    {
        // 1. VARIABLES DE CLASE: Declaradas al inicio para que sean accesibles en todos los métodos.
        private int dimension;
        private double[,] matrizCoeficientes;
        private double[] vectorConstantes;

        public Cofactores()
        {
            InitializeComponent();
            InicializarDataGridView(2); // Inicia la aplicación con el sistema 2x2.
            dimension = 2; // Asigna el valor por defecto a la dimensión.
            this.FormClosed += (s, e) => VolverMenu();
        }
        private void VolverMenu()
        {
            var menu = new MainMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
            this.Hide();
        }
        // 2. MÉTODOS MANEJADORES DE EVENTOS
        private void rdb2x2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2x2.Checked)
            {
                // Si se selecciona el sistema 2x2, muestra su imagen y oculta la otra.
                pbSistema2x2.Visible = true;
                pbSistema3x3.Visible = false;

                // También ajusta la cuadrícula (DataGridView) a 2x2.
                InicializarDataGridView(2);
                dimension = 2;
            }
        }

        private void rdb3x3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3x3.Checked)
            {
                // Si se selecciona el sistema 3x3, muestra su imagen y oculta la de 2x2.
                pbSistema3x3.Visible = true;
                pbSistema2x2.Visible = false;

                // Ajusta la cuadrícula (DataGridView) a 3x3.
                InicializarDataGridView(3);
                dimension = 3;
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            // NUEVA VALIDACIÓN: Verifica si todas las celdas tienen datos válidos antes de continuar
            if (!ValidarDatosEnDataGridView())
            {
                MessageBox.Show("Por favor, rellena todos los campos con valores numéricos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si la validación falla
            }

            try
            {
                RecolectarDatos();
                // Mostrar los controles de confirmación
                lblConfirmacion.Visible = true;
                btnConfirmar.Visible = true;
                btnCorregir.Visible = true;
                btnResolver.Visible = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrate de ingresar solo números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Ocultar botones de confirmación
            lblConfirmacion.Visible = false;
            btnConfirmar.Visible = false;
            btnCorregir.Visible = false;
            btnResolver.Visible = true;

            if (dimension == 2)
            {
                Resolver2x2();
            }
            else
            {
                Resolver3x3();
            }
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            // Ocultar botones de confirmación y mostrar el de resolver
            lblConfirmacion.Visible = false;
            btnConfirmar.Visible = false;
            btnCorregir.Visible = false;
            btnResolver.Visible = true;
        }

        // 3. MÉTODOS DE LÓGICA
        private void InicializarDataGridView(int size)
        {
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();

            for (int i = 1; i <= size; i++)
            {
                dgvMatriz.Columns.Add($"x{i}", $"x{i}");
                dgvMatriz.Columns[i - 1].Width = 50;
            }
            dgvMatriz.Columns.Add("constantes", "Constantes");
            dgvMatriz.Columns[size].Width = 60;
            dgvMatriz.Rows.Add(size);
            dgvMatriz.AllowUserToAddRows = false;
            dgvMatriz.AllowUserToDeleteRows = false;
        }

        private void RecolectarDatos()
        {
            matrizCoeficientes = new double[dimension, dimension];
            vectorConstantes = new double[dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrizCoeficientes[i, j] = Convert.ToDouble(dgvMatriz.Rows[i].Cells[j].Value);
                }
                vectorConstantes[i] = Convert.ToDouble(dgvMatriz.Rows[i].Cells[dimension].Value);
            }
        }

        // NUEVO MÉTODO DE VALIDACIÓN
        private bool ValidarDatosEnDataGridView()
        {
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension + 1; j++)
                {
                    // Verifica si la celda es nula o si su valor es una cadena vacía
                    if (dgvMatriz.Rows[i].Cells[j].Value == null || string.IsNullOrEmpty(dgvMatriz.Rows[i].Cells[j].Value.ToString()))
                    {
                        return false; // Retorna falso si encuentra una celda vacía
                    }
                    // Opcional: También puedes validar que sea un número válido
                    if (!double.TryParse(dgvMatriz.Rows[i].Cells[j].Value.ToString(), out _))
                    {
                        return false;
                    }
                }
            }
            return true; // Retorna verdadero si todas las celdas están llenas
        }

        // 4. MÉTODOS DE RESOLUCIÓN
        private void Resolver2x2()
        {
            double det = matrizCoeficientes[0, 0] * matrizCoeficientes[1, 1] - matrizCoeficientes[0, 1] * matrizCoeficientes[1, 0];

            if (det == 0)
            {
                txtResultados.Text = "El determinante es 0. No hay solución única.";
                return;
            }

            double detX = vectorConstantes[0] * matrizCoeficientes[1, 1] - vectorConstantes[1] * matrizCoeficientes[0, 1];
            double detY = matrizCoeficientes[0, 0] * vectorConstantes[1] - matrizCoeficientes[1, 0] * vectorConstantes[0];

            double x1 = detX / det;
            double x2 = detY / det;

            txtResultados.Text = $"x1 = {x1:F5}\r\nx2 = {x2:F5}";
        }

        private void Resolver3x3()
        {
            double det = matrizCoeficientes[0, 0] * (matrizCoeficientes[1, 1] * matrizCoeficientes[2, 2] - matrizCoeficientes[1, 2] * matrizCoeficientes[2, 1])
                       - matrizCoeficientes[0, 1] * (matrizCoeficientes[1, 0] * matrizCoeficientes[2, 2] - matrizCoeficientes[1, 2] * matrizCoeficientes[2, 0])
                       + matrizCoeficientes[0, 2] * (matrizCoeficientes[1, 0] * matrizCoeficientes[2, 1] - matrizCoeficientes[1, 1] * matrizCoeficientes[2, 0]);

            if (det == 0)
            {
                txtResultados.Text = "El determinante es 0. No hay solución única.";
                return;
            }

            // Obtener la matriz de cofactores
            double[,] cofactores = ObtenerMatrizCofactores(matrizCoeficientes);

            // Obtener la matriz adjunta (transpuesta de la de cofactores)
            double[,] adjunta = TransponerMatriz(cofactores);

            // Calcular la inversa
            double[,] inversa = MultiplicarMatrizPorEscalar(adjunta, 1 / det);

            // Multiplicar la inversa por el vector de constantes para obtener las soluciones
            double[] soluciones = MultiplicarMatrizPorVector(inversa, vectorConstantes);

            txtResultados.Text = $"x1 = {soluciones[0]:F5}\r\nx2 = {soluciones[1]:F5}\r\nx3 = {soluciones[2]:F5}";
        }

        // 5. MÉTODOS AUXILIARES
        private double[,] ObtenerMatrizCofactores(double[,] m)
        {
            double[,] cofactores = new double[3, 3];
            cofactores[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]);
            cofactores[0, 1] = -(m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]);
            cofactores[0, 2] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
            cofactores[1, 0] = -(m[0, 1] * m[2, 2] - m[0, 2] * m[2, 1]);
            cofactores[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]);
            cofactores[1, 2] = -(m[0, 0] * m[2, 1] - m[0, 1] * m[2, 0]);
            cofactores[2, 0] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]);
            cofactores[2, 1] = -(m[0, 0] * m[1, 2] - m[0, 2] * m[1, 0]);
            cofactores[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]);
            return cofactores;
        }

        private double[,] TransponerMatriz(double[,] m)
        {
            double[,] transpuesta = new double[m.GetLength(1), m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    transpuesta[j, i] = m[i, j];
                }
            }
            return transpuesta;
        }

        private double[,] MultiplicarMatrizPorEscalar(double[,] m, double escalar)
        {
            double[,] resultado = new double[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    resultado[i, j] = m[i, j] * escalar;
                }
            }
            return resultado;
        }

        private double[] MultiplicarMatrizPorVector(double[,] m, double[] v)
        {
            double[] resultado = new double[m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    resultado[i] += m[i, j] * v[j];
                }
            }
            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el contenido de la DataGridView
            dgvMatriz.Rows.Clear();
            dgvMatriz.Rows.Add(dimension);

            // Limpiar el cuadro de texto de los resultados
            txtResultados.Clear();

            // Resetear las variables de clase
            matrizCoeficientes = null;
            vectorConstantes = null;

            // Opcional: Asegurarse de que los controles estén en su estado inicial
            lblConfirmacion.Visible = false;
            btnConfirmar.Visible = false;
            btnCorregir.Visible = false;
            btnResolver.Visible = true;
        }

        private void pbSistema2x2_Click(object sender, EventArgs e)
        {

        }

        private void pbSistema3x3_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Form mainMenu = Application.OpenForms["MainMenu"];

            if (mainMenu != null)
            {
                // Si ya existe, solo lo mostramos
                mainMenu.Show();
            }
            else
            {
                // Si no existe, lo creamos
                mainMenu = new MainMenu();
                mainMenu.Show();
            }

            // Cerrar este formulario
            this.Close();
        }
    }
}
