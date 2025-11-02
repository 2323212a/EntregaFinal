using System;
using System.Drawing;
using System.Windows.Forms;

namespace EntregaFinal
{
    public partial class IntegracionNumerica : Form
    {
        private PictureBox tumbleweed;
        private Timer timer;

        public IntegracionNumerica()
        {
            InitializeComponent();
            CrearInterfaz();

            // Evento para regresar al menú si se cierra el formulario
            this.FormClosed += (s, e) =>
            {
                var menu = new MainMenu();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Show();
            };
        }

        private void CrearInterfaz()
        {
            this.Text = "Integración numérica (rectángulos, trapecio, Simpson 1/3 y 3/8)";
            this.BackColor = Color.FromArgb(240, 245, 255);
            this.ClientSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Label grande "Próximamente"
            Label lbl = new Label
            {
                Text = "Próximamente",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(20, 30)
            };
            this.Controls.Add(lbl);

            // Texto explicativo
            Label txtInfo = new Label
            {
                Text = "Aquí se implementarán los métodos de integración numérica:\n" +
                       "• Rectángulos\n• Trapecio\n• Simpson 1/3\n• Simpson 3/8",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(20, 100)
            };
            this.Controls.Add(txtInfo);

            // Botón de regresar
            Button btnRegresar = new Button
            {
                Text = "⬅ Volver al Menú Principal",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Size = new Size(300, 50),
                Location = new Point(20, 500),
                BackColor = Color.FromArgb(80, 110, 200),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.Click += (s, e) =>
            {
                var menu = new MainMenu();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Show();
                this.Hide();
            };
            btnRegresar.MouseEnter += (s, e) => btnRegresar.BackColor = Color.FromArgb(100, 130, 220);
            btnRegresar.MouseLeave += (s, e) => btnRegresar.BackColor = Color.FromArgb(80, 110, 200);
            this.Controls.Add(btnRegresar);

        }
    }
}
