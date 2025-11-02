using System;
using System.Drawing;
using System.Windows.Forms;

namespace EntregaFinal
{
    public partial class DerivacionNumerica : Form
    {
        private PictureBox tumbleweed;
        private Timer timer;

        public DerivacionNumerica()
        {
            InitializeComponent();
            CrearInterfaz();

            // Al cerrar, volver al menú principal
            this.FormClosed += (s, e) =>
            {
                var menu = new MainMenu();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Show();
            };
        }

        private void CrearInterfaz()
        {
            this.Text = "Derivación numérica";
            this.BackColor = Color.FromArgb(240, 245, 255);
            this.ClientSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Label grande "Próximamente"
            Label lblTitulo = new Label
            {
                Text = "Próximamente",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(20, 20)
            };
            this.Controls.Add(lblTitulo);

            // Label con métodos de derivación
            Label lblMetodos = new Label
            {
                Text = "Derivación numérica:\n  • Progresivas\n  • Centradas\n  • Orden superior",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = false,
                Size = new Size(850, 150),
                Location = new Point(20, 100),
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(10)
            };
            this.Controls.Add(lblMetodos);

            // Botón de regresar al menú
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

            // PictureBox del arbusto
        
        }
    }
}
