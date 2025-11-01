using System;
using System.Drawing;
using System.Windows.Forms;

namespace EntregaFinal
{
    public partial class MainMenu : Form
    {
        private Label[] labels;
        private Button[] botones;

        public MainMenu()
        {
            InitializeComponent();
            this.Load += (s, e) => CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            // Configuración general del formulario
            this.Text = "Menú principal";
            this.BackColor = Color.FromArgb(230, 240, 255);
            this.ClientSize = new Size(1280, 900);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Título principal
            var titulo = new Label
            {
                Text = "MENÚ DE MÉTODOS NUMÉRICOS",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 60, 150),
                Dock = DockStyle.Top,
                Height = 100,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(245, 250, 255)
            };
            this.Controls.Add(titulo);

            // Contenedor principal
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 4,
                Padding = new Padding(40),
                BackColor = Color.Transparent,
                AutoSize = false,
                AutoScroll = true,
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // más espacio para labels
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // botones

            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25));

            this.Controls.Add(layout);

            // Textos de las secciones
            string[] textos =
            {
                "Sistemas de ecuaciones lineales:\n" +
                "  • Cramer\n" +
                "  • Eliminación de Gauss\n" +
                "  • Inversa por Gauss-Jordan\n" +
                "  • Inversa por cofactores",

                "Raíces de polinomios:\n" +
                "  • Bolzano (bisección)\n" +
                "  • Regula Falsi\n" +
                "  • Newton-Raphson\n" +
                "  • Secante",

                "Derivación numérica:\n" +
                "  • Fórmulas progresivas\n" +
                "  • Centradas\n" +
                "  • De orden superior",

                "Integración numérica:\n" +
                "  • Rectángulos\n" +
                "  • Trapecio\n" +
                "  • Simpson 1/3\n" +
                "  • Simpson 3/8"
            };

            string[] nombresBotones =
            {
                "Sistemas de ecuaciones lineales",
                "Raíces de polinomios",
                "Derivación numérica",
                "Integración numérica"
            };

            labels = new Label[4];
            botones = new Button[4];

            for (int i = 0; i < 4; i++)
            {
                labels[i] = new Label
                {
                    Text = textos[i],
                    AutoSize = false,
                    Font = new Font("Segoe UI", 13, FontStyle.Regular),
                    ForeColor = Color.Black,
                    BackColor = Color.FromArgb(245, 250, 255),
                    BorderStyle = BorderStyle.FixedSingle,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter, // centrado
                    Padding = new Padding(20),
                    Margin = new Padding(5)
                };

                botones[i] = new Button
                {
                    Text = nombresBotones[i],
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(80, 110, 200),
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Fill,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(10)
                };
                botones[i].FlatAppearance.BorderSize = 0;

                botones[i].MouseEnter += (s, e) => ((Button)s).BackColor = Color.FromArgb(100, 130, 220);
                botones[i].MouseLeave += (s, e) => ((Button)s).BackColor = Color.FromArgb(80, 110, 200);

                int index = i;
                botones[i].Click += (s, e) => AbrirFormulario(index);

                layout.Controls.Add(labels[i], 0, i);
                layout.Controls.Add(botones[i], 1, i);
            }
        }

        private void AbrirFormulario(int index)
        {
            Form formDestino = null;

            switch (index)
            {
                case 0: formDestino = new SistemaLineal(); break;
                case 1: formDestino = new RaicesPolinomio(); break;
                case 2: formDestino = new DerivacionNumerica(); break;
                case 3: formDestino = new IntegracionNumerica(); break;
            }

            if (formDestino != null)
            {
                formDestino.StartPosition = FormStartPosition.CenterScreen;
                formDestino.Show();
                this.Hide();  // Para esconder este menú cuando abres otro form
            }
        }
    }
}
