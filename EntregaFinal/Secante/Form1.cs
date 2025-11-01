using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using NCalc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EntregaFinal.Secante
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string ConvertirCaretAPow(string expr)
        {
            // Reemplaza patrones del tipo: base ^ exponente  => Pow(base,exponente)
            // base y exponente pueden ser: identificadores (x), números, o subexpresiones entre paréntesis
            string pattern = @"(?<base>\([^\(\)]+\)|[A-Za-z_]\w*|\d+(\.\d+)?)\s*\^\s*(?<exp>\([^\(\)]+\)|[A-Za-z_]\w*|\d+(\.\d+)?)";

            // Aplicar iterativamente hasta que no haya más ^ (para potencias anidadas)
            while (Regex.IsMatch(expr, pattern))
            {
                expr = Regex.Replace(expr, pattern, m =>
                {
                    string left = m.Groups["base"].Value;
                    string right = m.Groups["exp"].Value;
                    return $"Pow({left},{right})";
                });
            }

            return expr;
        }


        private double EvaluarFuncion(string funcionUsuario, double x)
        {
            try
            {
                // 1) Normalizar separador decimal (si el usuario usa coma por error)
                funcionUsuario = funcionUsuario.Replace(',', '.');

                // 2) Insertar multiplicaciones implícitas (ej. 3x → 3*x, 2(x+1) → 2*(x+1))
                funcionUsuario = Regex.Replace(funcionUsuario, @"(?<num>\d)(?=[A-Za-z\(])", "${num}*");
                funcionUsuario = Regex.Replace(funcionUsuario, @"(?<var>[A-Za-z\)])(?=\d)", "${var}*");

                // 3) Convertir '^' a Pow(...)
                string funcion = ConvertirCaretAPow(funcionUsuario);

                // 4) Evaluar con NCalc
                Expression expr = new Expression(funcion);
                expr.Parameters["x"] = x;

                var result = expr.Evaluate();
                return Convert.ToDouble(result);
            }
            catch (EvaluationException evEx)
            {
                MessageBox.Show("Error al evaluar la función: " + evEx.Message, "Error de evaluación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return double.NaN;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la función. Verifica la sintaxis. (" + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return double.NaN;
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Crear columnas solo una vez
            if (tablaResultados.Columns.Count == 0)
            {
                tablaResultados.Columns.Add("iteracion", "i");
                tablaResultados.Columns.Add("x0", "x₀");
                tablaResultados.Columns.Add("xi", "xᵢ");
                tablaResultados.Columns.Add("fx0", "f(x₀)");
                tablaResultados.Columns.Add("fxi", "f(xᵢ)");
                tablaResultados.Columns.Add("x", "x");
                tablaResultados.Columns.Add("e", "Error");
            }

            tablaResultados.Rows.Clear();

            string funcion = txtFuncion.Text;
            double x0, xi;
            if (!double.TryParse(txtX0.Text, out x0) || !double.TryParse(txtXi.Text, out xi))
            {
                MessageBox.Show("Introduce valores numéricos válidos para x₀ y xᵢ.");
                return;
            }

            double error = 1;
            double xNuevo = 0;
            int iteraciones = 0;
            const double tolerancia = 1e-6;

            while (error > tolerancia && iteraciones < 50)
            {
                double fx0 = EvaluarFuncion(funcion, x0);
                double fxi = EvaluarFuncion(funcion, xi);

                if (double.IsNaN(fx0) || double.IsNaN(fxi))
                    return;

                // 🔹 Detector de raíz exacta
                if (Math.Abs(fx0) < tolerancia)
                {
                    MessageBox.Show($"Se encontró una raíz exacta: f(x₀)=0 en x₀ = {x0:F6}", "Raíz encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablaResultados.Rows.Add(iteraciones + 1, x0.ToString("F4"), xi.ToString("F4"), fx0.ToString("F4"), fxi.ToString("F4"), "-", "-");
                    return;
                }

                if (Math.Abs(fxi) < tolerancia)
                {
                    MessageBox.Show($"Se encontró una raíz exacta: f(xᵢ)=0 en xᵢ = {xi:F6}", "Raíz encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablaResultados.Rows.Add(iteraciones + 1, x0.ToString("F4"), xi.ToString("F4"), fx0.ToString("F4"), fxi.ToString("F4"), "-", "-");
                    return;
                }

                double denom = (fxi - fx0);
                if (Math.Abs(denom) < 1e-14)
                {
                    MessageBox.Show("Denominador demasiado pequeño (f(xi) - f(x0) ≈ 0). El método de la secante falla aquí.", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Fórmula corregida del método de la secante
                xNuevo = x0 - fx0 * ((xi - x0) / denom);
                error = Math.Abs((xNuevo - xi) / xNuevo);

                // Agregar fila a la tabla
                tablaResultados.Rows.Add(
                    iteraciones + 1,                
                    x0.ToString("F4"),
                    xi.ToString("F4"),
                    fx0.ToString("F4"),
                    fxi.ToString("F4"),
                    xNuevo.ToString("F4"),
                    error.ToString("F4")
                );

                // Actualizar valores
                x0 = xi;
                xi = xNuevo;
                iteraciones++;
            }

            MessageBox.Show($"Resultado final: x ≈ {xNuevo:F4}", "Método de la Secante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtX0.Clear();
            txtXi.Clear();
            tablaResultados.Rows.Clear();
            tablaResultados.Columns.Clear(); 
            txtFuncion.Focus(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); 
        }
    }
}

