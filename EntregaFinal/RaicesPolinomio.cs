using System;
using System.Drawing;
using System.Windows.Forms;
using EntregaFinal.Biseccion;
using EntregaFinal.RegulaFalsi;
using EntregaFinal.Newton;
using EntregaFinal.Secante;

namespace EntregaFinal
{
    public partial class RaicesPolinomio : Form
    {
        public RaicesPolinomio()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            // Configuración general del formulario
            this.Text = "Raíces de Polinomios";
            this.BackColor = Color.FromArgb(240, 245, 255);
            this.ClientSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Título principal
            Label lblTitulo = new Label
            {
                Text = "Métodos para encontrar raíces de polinomios",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 60, 150),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 90
            };
            this.Controls.Add(lblTitulo);

            // Panel para los botones
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(0, 40, 0, 0),
                WrapContents = false,
                AutoScroll = true
            };
            this.Controls.Add(panel);

            // Botones
            Button btnBolzano = CrearBoton("Método de Bolzano (Bisección)", () => AbrirFormulario(new Bolzano()));
            Button btnRegulaFalsi = CrearBoton("Método de Regula Falsi", () => AbrirFormulario(new Falsi()));
            Button btnNewtonRaphson = CrearBoton("Método de Newton-Raphson", () => MessageBox.Show("Aún no implementado"));
            Button btnSecante = CrearBoton("Método de la Secante", () => MessageBox.Show("Aún no implementado"));
            Button btnVolver = CrearBoton("Volver al Menú Principal", () => VolverMenu());

            panel.Controls.AddRange(new Control[]
            {
                btnBolzano,
                btnRegulaFalsi,
                btnNewtonRaphson,
                btnSecante,
                btnVolver
            });
        }

        private Button CrearBoton(string texto, Action accion)
        {
            Button btn = new Button
            {
                Text = texto,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Size = new Size(450, 60),
                BackColor = Color.FromArgb(80, 110, 200),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(10),
                TextAlign = ContentAlignment.MiddleCenter
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (s, e) => accion();

            // Hover
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(100, 130, 220);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(80, 110, 200);

            return btn;
        }

        private void AbrirFormulario(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide(); // Oculta el formulario actual
        }

        private void VolverMenu()
        {
            MainMenu menu = new MainMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
            this.Hide();
        }
    }
}
