using System;
using System.Drawing;
using System.Windows.Forms;
using EntregaFinal.Metodoslineales;

namespace EntregaFinal
{
    public partial class SistemaLineal : Form
    {
        public SistemaLineal()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            // === CONFIGURACIÓN GENERAL ===
            this.Text = "Sistemas de Ecuaciones Lineales";
            this.BackColor = Color.FromArgb(230, 240, 255);
            this.ClientSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // === TÍTULO ===
            Label lblTitulo = new Label
            {
                Text = "Métodos para resolver sistemas de ecuaciones lineales",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 60, 150),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 90
            };
            this.Controls.Add(lblTitulo);

            // === CONTENEDOR ===
            var panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(0, 40, 0, 0),
                WrapContents = false,
                AutoScroll = true
            };
            this.Controls.Add(panel);

            // === BOTONES ===
            Button btnCramer = CrearBoton("Método de Cramer", () => AbrirFormulario(new Cramer()));
            Button btnGauss = CrearBoton("Eliminación de Gauss", () => AbrirFormulario(new Gauss()));
            Button btnGaussJordan = CrearBoton("Inversa por Gauss-Jordan", () => AbrirFormulario(new GaussInversa()));
            Button btnCofactores = CrearBoton("Inversa por Cofactores", () => AbrirFormulario(new Cofactores()));
            Button btnVolver = CrearBoton("Volver al Menú Principal", () => VolverMenu());

            // Agregamos los botones al panel
            panel.Controls.AddRange(new Control[]
            {
                btnCramer,
                btnGauss,
                btnGaussJordan,
                btnCofactores,
                btnVolver
            });
        }

        // === FUNCIÓN PARA CREAR BOTONES ===
        private Button CrearBoton(string texto, Action accion)
        {
            Button btn = new Button
            {
                Text = texto,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Size = new Size(400, 60),
                BackColor = Color.FromArgb(80, 110, 200),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(10),
                TextAlign = ContentAlignment.MiddleCenter
            };
            btn.FlatAppearance.BorderSize = 0;

            btn.Click += (s, e) => accion();

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(100, 130, 220);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(80, 110, 200);

            return btn;
        }

        // === ABRIR FORMULARIO ===
        private void AbrirFormulario(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        // === VOLVER AL MENÚ PRINCIPAL ===
        private void VolverMenu()
        {
            MainMenu menu = new MainMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            // Si no usas el diseñador de Visual Studio, puedes dejar este método vacío.
            // Si usas el diseñador, asegúrate de que este método sea generado automáticamente.
        }
    }
}
