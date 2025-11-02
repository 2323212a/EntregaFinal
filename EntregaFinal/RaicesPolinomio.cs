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
            this.FormClosed += (s, e) => VolverMenu();
        }

        private void CrearInterfaz()
        {
            // Configuración del formulario
            this.Text = "Raíces de Polinomios";
            this.BackColor = Color.FromArgb(240, 245, 255);
            this.ClientSize = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Layout principal
            var layoutPrincipal = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1,
                BackColor = Color.Transparent,
                Padding = new Padding(20),
                AutoScroll = true
            };
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Add(layoutPrincipal);

            // Título
            var lblTitulo = new Label
            {
                Text = "Métodos para encontrar raíces de polinomios",
                Font = new Font("Segoe UI", 26, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 60, 150),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0, 30, 0, 30),
                BackColor = Color.FromArgb(245, 250, 255)
            };
            layoutPrincipal.Controls.Add(lblTitulo, 0, 0);

            // Panel para los botones
            var panelBotones = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = false,
                Padding = new Padding(0, 20, 0, 20),
                BackColor = Color.Transparent
            };
            layoutPrincipal.Controls.Add(panelBotones, 0, 1);

            // Botones
            panelBotones.Controls.Add(CrearBoton("Método de Bolzano (Bisección)", () => AbrirFormulario(new Bolzano())));
            panelBotones.Controls.Add(CrearBoton("Método de Regula Falsi", () => AbrirFormulario(new Falsi())));
            panelBotones.Controls.Add(CrearBoton("Método de Newton-Raphson", () => AbrirFormulario(new Newton1())));
            panelBotones.Controls.Add(CrearBoton("Método de la Secante", () => AbrirFormulario(new Secante1())));
            panelBotones.Controls.Add(CrearBoton("⬅ Volver al Menú Principal", () => VolverMenu(), true));
        }

        private Button CrearBoton(string texto, Action accion, bool botonVerde = false)
        {
            var btn = new Button
            {
                Text = texto,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(700, 90), // Más ancho y alto para que no se corte
                BackColor = botonVerde ? Color.FromArgb(90, 150, 90) : Color.FromArgb(80, 110, 200),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(15),
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (s, e) => accion();

            // Efecto hover
            btn.MouseEnter += (s, e) => btn.BackColor = botonVerde ? Color.FromArgb(110, 180, 110) : Color.FromArgb(100, 130, 220);
            btn.MouseLeave += (s, e) => btn.BackColor = botonVerde ? Color.FromArgb(90, 150, 90) : Color.FromArgb(80, 110, 200);

            return btn;
        }

        private void AbrirFormulario(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void VolverMenu()
        {
            var menu = new MainMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
            this.Hide();
        }
    }
}
