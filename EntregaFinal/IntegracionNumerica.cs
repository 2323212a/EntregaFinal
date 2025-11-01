using System;
using System.Drawing;
using System.Windows.Forms;

namespace EntregaFinal
{
    public partial class IntegracionNumerica : Form
    {
        public IntegracionNumerica()
        {
            this.Text = "Integración numérica (rectángulos, trapecio, Simpson 1/3 y 3/8) - Próximamente";
            this.BackColor = Color.FromArgb(240, 245, 255);
            this.ClientSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lbl = new Label
            {
                Text = "Próximamente",
                Font = new Font("Arial", 14, FontStyle.Italic),
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(20, 50)
            };
            this.Controls.Add(lbl);
        }
    }
}
