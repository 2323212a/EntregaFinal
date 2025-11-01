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
    public partial class Gauss : Form
    {
        public Gauss()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int numVariables = 3;
            int numEcuaciones = 3;

            // Configurar el DataGridView
            dgvMatriz.ColumnCount = numVariables + 1;
            dgvMatriz.RowCount = numEcuaciones;

            // Asignar los encabezados de las columnas (x1, x2, x3, etc.)
            for (int i = 0; i < numVariables; i++)
            {
                dgvMatriz.Columns[i].HeaderText = $"x{i + 1}";
            }
            dgvMatriz.Columns[numVariables].HeaderText = "a";

            // Permitir al usuario rellenar los datos
            dgvMatriz.AllowUserToAddRows = false;
            dgvMatriz.AllowUserToDeleteRows = false;
            dgvMatriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnCrearMatriz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtVariables.Text, out int var) && int.TryParse(txtEcuaciones.Text, out int ec))
            {
                if (ec != var)
                {
                    MessageBox.Show("Esta aplicación solo resuelve sistemas cuadrados (mismo número de variables y ecuaciones).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Configurar el DataGridView con el tamaño especificado
                dgvMatriz.ColumnCount = var + 1;
                dgvMatriz.RowCount = ec;

                for (int i = 0; i < var; i++)
                {
                    dgvMatriz.Columns[i].HeaderText = $"x{i + 1}";
                }
                dgvMatriz.Columns[var].HeaderText = "a";

                dgvMatriz.AllowUserToAddRows = false;
                dgvMatriz.AllowUserToDeleteRows = false;
                dgvMatriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Limpiar resultados anteriores
                txtResultados.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos para variables y ecuaciones.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnResolver_Click(object sender, EventArgs e)
        {
            txtResultados.Clear();

            int var = dgvMatriz.ColumnCount - 1;
            int ec = dgvMatriz.RowCount;

            if (var == 0 || ec == 0)
            {
                MessageBox.Show("Primero crea la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            float[,] cons = new float[ec, var + 1];

            try
            {
                for (int i = 0; i < ec; i++)
                {
                    for (int j = 0; j <= var; j++)
                    {
                        if (dgvMatriz.Rows[i].Cells[j].Value == null || dgvMatriz.Rows[i].Cells[j].Value.ToString() == "")
                        {
                            MessageBox.Show("Por favor, rellena todas las celdas de la matriz.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        cons[i, j] = Convert.ToSingle(dgvMatriz.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todas las celdas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lógica de Gauss-Jordan 
            for (int h = 0; h < ec; h++)
            {
                if (Math.Abs(cons[h, h]) < 1e-6)
                {
                    bool filaIntercambiada = false;
                    for (int j = h + 1; j < ec; j++)
                    {
                        if (Math.Abs(cons[j, h]) > 1e-6)
                        {
                            for (int k = 0; k <= var; k++)
                            {
                                float temp = cons[h, k];
                                cons[h, k] = cons[j, k];
                                cons[j, k] = temp;
                            }
                            filaIntercambiada = true;
                            break;
                        }
                    }

                    if (!filaIntercambiada)
                    {
                        int zeroCons = 0;
                        for (int m = 0; m < var; m++)
                        {
                            if (Math.Abs(cons[h, m]) < 1e-6)
                            {
                                zeroCons++;
                            }
                        }
                        if (zeroCons == var)
                        {
                            if (Math.Abs(cons[h, var]) > 1e-6)
                            {
                                txtResultados.Text = "El sistema es inconsistente (no tiene solución).";
                                return;
                            }
                            else
                            {
                                txtResultados.Text = "El sistema tiene soluciones infinitas.";
                                return;
                            }
                        }
                    }
                }

                float divsr = cons[h, h];
                if (Math.Abs(divsr) > 1e-6)
                {
                    for (int i = 0; i <= var; i++)
                    {
                        cons[h, i] /= divsr;
                    }
                }
                else
                {
                    txtResultados.Text = "El sistema es inconsistente o tiene infinitas soluciones.";
                    return;
                }

                for (int y = 0; y < ec; y++)
                {
                    if (y != h)
                    {
                        float multply = cons[y, h] * -1;
                        for (int i = 0; i <= var; i++)
                        {
                            cons[y, i] += multply * cons[h, i];
                        }
                    }
                }
            }

            txtResultados.AppendText("Matriz en forma de Gauss-Jordan:\n");
            for (int i = 0; i < ec; i++)
            {
                for (int j = 0; j < var; j++)
                {
                    txtResultados.AppendText($"{cons[i, j]:F2}\t");
                }
                txtResultados.AppendText($"| {cons[i, var]:F2}\n");
            }

            txtResultados.AppendText("\nSoluciones:\n");
            for (int i = 0; i < var; i++)
            {
                txtResultados.AppendText($"x_{i + 1} = {cons[i, var]:F2}\n");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia las celdas del DataGridView
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();

            // Limpia el RichTextBox de resultados
            txtResultados.Clear();

        }
    }
}


