using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EntregaFinal.RegulaFalsi
{
    public partial class Grados : Form
    {
        public Grados()
        {
            InitializeComponent();
            panel1.Visible = false;
            radioButton1.Visible = false;
            radioButton1.Checked = true;
            btnEvaluarGrado1.Visible = false;
            btnEvaluar.Visible = false;
            btnEvaluar2.Visible = false;
            btnEvaluar3.Visible = false;

        }

        private void btnEvaluarGrado1_Click_1(object sender, EventArgs e)
        {
            string funcion = lblFuncion.Text;

            if (string.IsNullOrWhiteSpace(funcion))
            {
                MessageBox.Show("No hay ninguna función para verificar.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = $"Verifica tu función:\n{funcion}\n\n¿Deseas continuar?";
            DialogResult respuesta = MessageBox.Show(mensaje, "Confirmar función",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                Grado1 formGrado1 = new Grado1(funcion);
                formGrado1.ShowDialog();
                this.Hide();
            }
        }

        private void btnEvaluar3_Click_1(object sender, EventArgs e)
        {
            string funcion = lblFuncion.Text;

            if (string.IsNullOrWhiteSpace(funcion))
            {
                MessageBox.Show("No hay ninguna función para verificar.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = $"Verifica tu función:\n{funcion}\n\n¿Deseas continuar?";
            DialogResult respuesta = MessageBox.Show(mensaje, "Confirmar función",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                Grado4 formGrado4 = new Grado4(funcion);
                formGrado4.ShowDialog();
                this.Hide();
            }
        }

        private void btnEvaluar2_Click_1(object sender, EventArgs e)
        {
            string funcion = lblFuncion.Text;


            if (string.IsNullOrWhiteSpace(funcion))
            {
                MessageBox.Show("No hay ninguna función para verificar.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string mensaje = $"Verifica tu función:\n{funcion}\n\n¿Deseas continuar?";
            DialogResult respuesta = MessageBox.Show(mensaje, "Confirmar función",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (respuesta == DialogResult.OK)
            {

                Grado3 formGrado3 = new Grado3(funcion);
                formGrado3.ShowDialog();
                this.Hide();
            }
        }

        private void btnEvaluar_Click_1(object sender, EventArgs e)
        {
            string funcion = lblFuncion.Text;


            if (string.IsNullOrWhiteSpace(funcion))
            {
                MessageBox.Show("No hay ninguna función para verificar.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string mensaje = $"Verifica tu función:\n{funcion}\n\n¿Deseas continuar?";
            DialogResult respuesta = MessageBox.Show(mensaje, "Confirmar función",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (respuesta == DialogResult.OK)
            {

                Grado2 formGrado2 = new Grado2(funcion);
                formGrado2.ShowDialog();
                this.Hide();
            }
        }

        private void rbGrado1_CheckedChanged(object sender, EventArgs e)
        {
            btnEvaluarGrado1.Visible = true;
            btnEvaluar.Visible = false;
            btnEvaluar2.Visible = false;
            btnEvaluar3.Visible = false;
            if (rbGrado1.Checked)
            {
                panel1.Visible = true;
                lblFuncion.Text = "a₁x\u00B9 + a";

            }
        }

        private void rbGrado2_CheckedChanged(object sender, EventArgs e)
        {
            btnEvaluarGrado1.Visible = false;
            btnEvaluar.Visible = true;
            btnEvaluar2.Visible = false;
            btnEvaluar3.Visible = false;
            if (rbGrado2.Checked)
            {
                panel1.Visible = true;
                lblFuncion.Text = "a₂x² + a₁x + a";
            }
        }

        private void rbGrado3_CheckedChanged(object sender, EventArgs e)
        {
            btnEvaluarGrado1.Visible = false;
            btnEvaluar.Visible = false;
            btnEvaluar2.Visible = true;
            btnEvaluar3.Visible = false;
            if (rbGrado3.Checked)
            {
                panel1.Visible = true;
                lblFuncion.Text = "a₃x³ +a₂x² + a₁x + a";

            }
        }

        private void rbGrado4_CheckedChanged(object sender, EventArgs e)
        {
            btnEvaluarGrado1.Visible = false;
            btnEvaluar.Visible = false;
            btnEvaluar2.Visible = false;
            btnEvaluar3.Visible = true;
            if (rbGrado4.Checked)
            {
                panel1.Visible = true;
                lblFuncion.Text = "a₄x⁴ + a₃x³ +a₂x² + a₁x + a";

            }
        }
    }
}
