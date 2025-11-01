using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace EntregaFinal.Metodoslineales
{
    public partial class Cramer : Form
    {
        public Cramer()
        {
            InitializeComponent();
        }

        private void AnimacionBoton(Button btn, bool entrar)
        {
            if (entrar)
            {
                btn.BackColor = ControlPaint.Light(btn.BackColor);
                btn.Size = new Size(btn.Width + 8, btn.Height + 4);
                btn.Location = new Point(btn.Location.X - 4, btn.Location.Y - 2);
            }
            else
            {
                if (btn == btnEcuaciones2)
                    btn.BackColor = Color.FromArgb(0, 123, 255);
                else
                    btn.BackColor = Color.FromArgb(255, 85, 85);

                btn.Size = new Size(280, 70);
                btn.Location = new Point(60, btn == btnEcuaciones2 ? 100 : 190);
            }
        }

        private void btnEcuaciones2_MouseEnter(object sender, EventArgs e)
        {
            AnimacionBoton(btnEcuaciones2, true);
        }

        private void btnEcuaciones2_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBoton(btnEcuaciones2, false);
        }

        private void btnEcuaciones3_MouseEnter(object sender, EventArgs e)
        {
            AnimacionBoton(btnEcuaciones3, true);
        }

        private void btnEcuaciones3_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBoton(btnEcuaciones3, false);
        }

        private void btnEcuaciones2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Hide();
        }

        private void btnEcuaciones3_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();
            ventana.Show();
            this.Hide();
        }

        private void Cramer_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }
    }
}
